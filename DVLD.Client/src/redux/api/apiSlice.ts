import { fetchBaseQuery,  FetchArgs, createApi, FetchBaseQueryError, BaseQueryFn } from "@reduxjs/toolkit/query/react";
import { RootState } from '../store';
import { setAuthToken, setLoggedOut } from "../Slices/authSlice";

export const BaseApi = "https://localhost:7270/api"

const myBaseQuery = fetchBaseQuery({
    baseUrl: BaseApi,
    credentials: 'include',
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
//     let result = await myBaseQuery(args, api, extraOptions)

//     if (result.error && result.error.status === 401) {
//     // try to get a new token
//     console.log(result.error.status);
//     console.log(result.error);
    
    
//     const refreshResult = await myBaseQuery('/refreshToken', api, extraOptions)
//     if (refreshResult.data) {
//       // store the new token
//         api.dispatch(setAuthToken(refreshResult.data as string))
//       // retry the initial query
//       result = await myBaseQuery(args, api, extraOptions)
//     } else {
//       api.dispatch(setLoggedOut())
//     }
//   }
//   return result
// }


type AccessTokenResponse = {
    Response: string
}

const baseQueryWithReAuth: BaseQueryFn<
  string | FetchArgs,
  unknown,
  FetchBaseQueryError
>   = async  (args,  api,  extraOptions) =>{
        let result = await myBaseQuery(args , api, extraOptions)
        if  (result?.error?.status === 401){
            
            const refreshResult = await myBaseQuery('/Auth/Refresh', api, extraOptions)
            if(refreshResult?.data){
                api.dispatch(setAuthToken((refreshResult.data as AccessTokenResponse).Response))
                result = await myBaseQuery(args, api, extraOptions)
            }  else {
                api.dispatch(setLoggedOut())
            }
        }
        return result;
}

export const apiSlice = createApi({
    baseQuery : baseQueryWithReAuth,
    tagTypes: [`Person`, `AllPeople`, `AllLDLApplications` ],
    endpoints: () => ({})
})