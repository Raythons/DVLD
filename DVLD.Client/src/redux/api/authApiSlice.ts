import { apiSlice } from "./apiSlice";
import { LoginCredentials } from "../../types/AuthTypes";
import { authState } from "../Slices/authSlice";

export const AuthEndPoint =  "/Auth"

export const authApiSlice =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        login: builder.mutation({
            query: (credentials : LoginCredentials ) => ({
                url: `${AuthEndPoint}/log-in`,
                method : "Post",
                body: {...credentials}
            }),
            transformResponse: (
                response
                ) => {
                    return response  as authState;
                }
        }),
    })
})


export const {useLoginMutation } = authApiSlice 