import { fetchBaseQuery,  FetchArgs, createApi, FetchBaseQueryError, BaseQueryFn } from "@reduxjs/toolkit/query/react";
import { RootState } from '../store';
import { setAuthToken, setLoggedOut } from "../features/authSlice";

export const BaseApi = "https://localhost:7270/api"

const myBaseQuery = fetchBaseQuery({
    baseUrl: BaseApi,
    // credentials: 'include',
    prepareHeaders: (headers , {getState}) => {
        const token = (getState() as RootState).auth.accessToken;
        if(token){
            headers.set("authorization", `Bearer ${token}`)
        }
        return headers
    }
    
})


// const baseQueryWithReauth: BaseQueryFn<
//   string | FetchArgs,
//   unknown,
//   FetchBaseQueryError
// > = async (args, api, extraOptions) => {
//   let result = await myBaseQuery(args, api, extraOptions)
//   if (result.error && result.error.status === 401) {
//     // try to get a new token
//     const refreshResult = await myBaseQuery('/refreshToken', api, extraOptions)
//     if (refreshResult.data) {
//       // store the new token
//       api.dispatch(setAuthToken({} as string))
//       // retry the initial query
//       result = await myBaseQuery(args, api, extraOptions)
//     } else {
//       api.dispatch(setLoggedOut())
//     }
//   }
//   return result
// }



const baseQueryWithReAuth: BaseQueryFn<
  string | FetchArgs,
  unknown,
  FetchBaseQueryError
>   = async  (args,  api,  extraOptions) =>{
        let result = await myBaseQuery(args , api, extraOptions)

        if  (result?.error?.status === 403){
            console.log("sending refresh Token")

            const refreshResult = await myBaseQuery('/refresh', api, extraOptions)
            if(refreshResult?.data){
                api.dispatch(setAuthToken(refreshResult.data as string))
                result = await myBaseQuery(args, api, extraOptions)
            }  else {
                api.dispatch(setLoggedOut())
            }
        }
        return result;
}

export const apiSlice = createApi({
    baseQuery : baseQueryWithReAuth,
    tagTypes: [`Person`, `AllPeople` ],
    endpoints: () => ({})
})