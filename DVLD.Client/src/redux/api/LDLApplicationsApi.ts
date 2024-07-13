import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
// import { CreatePersonFormFields } from "../../types/AddPersonType";
// import fillFormFiles from "../../utils/fillFormFiles";
// import { handleRtkQueryErrors } from "../helpers";
// import { isNumber } from "../../utils/isNumber";

export const LDLApplicationsEndPoint = "Applications/LocalDrivingLicense"

export type GetAllLDLAppQueryParams = PaginatedQueryParams;

export type GetLDlListData = {
    Id: number,
    ClassName: string
    NationalNo:string
    FullName: string
    CreatedAt: Date
    PassedTestCount:number
    Status: string
}



// type CreatePersonBody = CreatePersonFormFields;
// export type UpdatePersonBody = CreatePersonBody;

// export type UpdatePersonMutationParams = {
//     body: UpdatePersonBody;
//     id: number; // Additional parameter for the ID
// }

// // type EditPersonBody = CreatePersonBody;
// export type GetPersonDataResponse = {
//     Id: number,
//     FullName: string,
//     NationalNo: string ,
//     Gender: string,
//     Country: string,
//     Age: number,
//     Address: string,
//     Phone:string,
//     Email: string,
//     Image: string
// } 

// export type getPersonEditDetailsResponse = CreatePersonBody

export const peopleApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        // getPersonDetails :  builder.query<GetPersonDataResponse, number>({
        //     query: (personId) => (
        //         {
        //             url: `${PeopleEndPoint}/${personId}`,
        //         }
        //     ),
        //     providesTags: [`Person`],
        //     transformResponse : (QueryReturnValue: {Response: GetPersonDataResponse})  => {
        //         return QueryReturnValue.Response
        //     },
        //     transformErrorResponse: (error) : ApiError  =>{
        //         const errorData = handleRtkQueryErrors(error)
                
        //         if(isNumber(error.status)) {
        //             errorData.status  = error.status as number;
        //         }   
        //         return errorData
        //     }
        // }),
        // getPersonEditDetails :  builder.query<getPersonEditDetailsResponse, number>({
        //     query: (personId) => (
        //         {
        //             url: `${PeopleEndPoint}/to-edit/${personId}`,
        //         }
                
        //     ),
        //     providesTags: [`Person`],
        //     transformResponse : (QueryReturnValue: {Response: getPersonEditDetailsResponse})  => {                
        //         return QueryReturnValue.Response
        //     },
        //     transformErrorResponse: (error) : ApiError  =>{
        //         const errorData = handleRtkQueryErrors(error)
                
        //         if(isNumber(error.status)) {
        //             errorData.status  = error.status as number;
        //         }   
        //         return errorData
        //     }
        // }),
        getAllLDLApplications: builder.query<GetLDlListData[], GetAllLDLAppQueryParams>({
            query: (getALLQueryParams) => ({
                url: `${LDLApplicationsEndPoint}/`,
                params: getALLQueryParams,
            }),
            transformResponse: (response: {Response:  {Items: GetLDlListData[] }}) => {
                console.log(response);
                return response.Response.Items
            },
        }),
        // createPerson: builder.mutation<number, CreatePersonBody>({
        //     query: (createPersonBody) => {
        //         const formData = fillFormFiles(createPersonBody);
        //         return {
        //             url: `${PeopleEndPoint}/`,
        //             method: "PUT",
        //             body: formData
        //         }
        //     },
        //     invalidatesTags: [`AllPeople`],
        //     transformResponse(response: {Response: number }) {
        //         return response.Response
        //     },
        //     transformErrorResponse: (error) => {
        //         const errorData = handleRtkQueryErrors(error)
                
        //         if(isNumber(error.status)) {
        //             errorData.status  = error.status as number;
        //         }   
        //         return errorData
        //     },
        // }),
        // updatePersonDetails: builder.mutation<boolean, UpdatePersonMutationParams>({
        //     query: ({body, id}) => {
        //         const formData = fillFormFiles(body); 
        //         return {
        //             url: `${PeopleEndPoint}/${id}`,
        //             method: "PUT",
        //             body: formData
        //         }
        //     },
        //     // invalidatesTags: [`AllPeople`, `Person`],
        //     transformResponse(response: {Response: boolean }) {
        //         console.log(response);
                
        //         return response.Response
        //     },
        //     transformErrorResponse: (error) => {
        //         const errorData = handleRtkQueryErrors(error)
                
        //         if(isNumber(error.status)) {
        //             errorData.status  = error.status as number;
        //         }   
        //         return errorData
        //     },
        // }),
        // deletePerson: builder.mutation<boolean, number>({
        //     query: (personId) => (
                
        //         {
        //             url: `${PeopleEndPoint}/${personId}`,
        //             method: `Delete`,   
        //         }
        //     ),
        //     invalidatesTags: [`AllPeople`, `Person`],
        //     transformResponse : (baseQueryReturnValue) => {
        //         return baseQueryReturnValue as boolean
        //     },
        //     transformErrorResponse: (error) =>  {
        //         const errorData = handleRtkQueryErrors(error)
                
        //         if(isNumber(error.status)) {
        //             errorData.status  = error.status as number;
        //         }                  
        //         return errorData;
        //     },
        // })
        // editPerson: builder.mutation<boolean, EditPersonBody>( )
    })
})

export const {
        useGetAllLDLApplicationsQuery
    } = peopleApi