import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";

export const PeopleEndPoint = "Person"

export type GetAllPeopleQueryParams = PaginatedQueryParams;

export type GetPersonListData = {
    Id: number,
    FullName: string,
    Age: string,
    Gender: string
}


export const peopleApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getAll: builder.query<GetPersonListData[], GetAllPeopleQueryParams>({
            query: (getALLQueryParams) => ({
                url: `${PeopleEndPoint}/`,
                params: getALLQueryParams,
            }),
            transformResponse: (response: {Response: GetPersonListData[] }, meta, arg) => {
                console.log(response.Response)
                console.log(arg)
                return response.Response
            },

        })
    })
})

export const {useGetAllQuery} = peopleApi