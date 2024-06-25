import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
import { CreatePersonFormFields } from "../../types/AddPersonType";
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

// type EditPersonBody = CreatePersonBody;

export const peopleApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getAll: builder.query<GetPersonListData[], GetAllPeopleQueryParams>({
            query: (getALLQueryParams) => ({
                url: `${PeopleEndPoint}/`,
                params: getALLQueryParams,
            }),
            transformResponse: (response: {Response: GetPersonListData[] }) => {
                return response.Response
            },
        }),
        createPerson: builder.mutation<number, CreatePersonBody>({
            query: (createPersonBody) => {
                const formData = fillFormFiles(createPersonBody);
                return {
                    url: `${PeopleEndPoint}/`,
                    method: "POST",
                    body: formData
                }
            },
            transformResponse(response: {Response: number }) {
                return response.Response
            },
            // transformErrorResponse: (response) => {
            //     console.log(response.status)
            // },
        }),
        editPerson: builder.mutation<boolean, EditPersonBody>( )
    })
})

export const {useGetAllQuery, useCreatePersonMutation } = peopleApi