import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
import { CreatePersonFormFields } from "../../types/AddPersonType";
import fillFormFiles from "../../utils/fillFormFiles";
import { handleRtkQueryErrors } from "../helpers";
import { isNumber } from "../../utils/isNumber";
export const PeopleEndPoint = "Person"

export type GetAllPeopleQueryParams = PaginatedQueryParams;

export type GetPersonListData = {
    Id: number,
    FullName: string,
    Age: string,
    Gender: string
}

export type ApiError = {
    Code?: string,
    Message: string,
    Reasons: string[],
    status?: number;
}

export type MainApiResponse  =  {
    Errors: ApiError[]
    IsSuccess: boolean,
    Response: unknown,
}

type CreatePersonBody = CreatePersonFormFields;
export type UpdatePersonBody = CreatePersonBody;

export type UpdatePersonMutationParams = {
    body: UpdatePersonBody;
    id: number; // Additional parameter for the ID
}

// type EditPersonBody = CreatePersonBody;
export type GetPersonDataResponse = {
    Id: number,
    FullName: string,
    NationalNo: string ,
    Gender: string,
    Country: string,
    Age: number,
    Address: string,
    Phone:string,
    Email: string,
    Image: string
} 

export type getPersonEditDetailsResponse = CreatePersonBody

export const peopleApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getPersonDetails :  builder.query<GetPersonDataResponse, number>({
            query: (personId) => (
                {
                    url: `${PeopleEndPoint}/${personId}`,
                }
            ),
            transformResponse : (QueryReturnValue: {Response: GetPersonDataResponse})  => {
                return QueryReturnValue.Response
            },
            transformErrorResponse: (error) : ApiError  =>{
                const errorData = handleRtkQueryErrors(error)
                console.log(error);
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            }
        }),
        getPersonEditDetails :  builder.query<getPersonEditDetailsResponse, number>({
            query: (personId) => (
                {
                    url: `${PeopleEndPoint}/to-edit/${personId}`,
                }
            ),
            transformResponse : (QueryReturnValue: {Response: getPersonEditDetailsResponse})  => {
                console.log(QueryReturnValue.Response);
                
                return QueryReturnValue.Response
            },
            transformErrorResponse: (error) : ApiError  =>{
                const errorData = handleRtkQueryErrors(error)
                console.log(error);
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            }
        }),
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
                    method: "PUT",
                    body: formData
                }
            },
            transformResponse(response: {Response: number }) {
                return response.Response
            },
            transformErrorResponse: (response) => {
                return response.status
            },
        }),
        UpdatePersonDetails: builder.mutation<boolean, UpdatePersonMutationParams>({
            query: ({body, id}) => {
                console.log("body");
                
                console.log(
                    body
                );
                
                console.log("formData");
                
                const formData = fillFormFiles(body);
                console.log(
                    formData
                );
                return {
                    url: `${PeopleEndPoint}/${id}`,
                    method: "PUT",
                    body: formData
                }
            },
            transformResponse(response: {Response: boolean }) {
                return response.Response
            },
            transformErrorResponse: (response) => {
                console.log(response);
                return response.status
            },
        }),
        // editPerson: builder.mutation<boolean, EditPersonBody>( )
    })
})

export const {
    useGetAllQuery,
    useGetPersonDetailsQuery,
    useGetPersonEditDetailsQuery,
    useCreatePersonMutation,
    useUpdatePersonDetailsMutation
     } = peopleApi