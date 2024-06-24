import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
import { CreatePersonFormFields } from "../../Pages/Person/AddPerson";
import fillFormFiles from "../../utils/fillFormFiles";

export const PeopleEndPoint = "Person"

export type GetAllPeopleQueryParams = PaginatedQueryParams;

export type GetPersonListData = {
    Id: number,
    FullName: string,
    Age: string,
    Gender: string
}


type CreatePersonBody = CreatePersonFormFields;

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
        }),
        createPerson: builder.mutation<boolean, CreatePersonBody>({
            query: (createPersonBody) => {
                console.log("formdata here")
                const formData = fillFormFiles(createPersonBody);
                console.log(formData)
                return {
                    url: `${PeopleEndPoint}/`,
                    method: "POST",
                    body: formData
                }
            },
            transformErrorResponse: (response) => {
                console.log(response)
            }
        })
    })
})

export const {useGetAllQuery, useCreatePersonMutation } = peopleApi