import { apiSlice } from "../apiSlice";
import { PaginatedQueryParams } from "../../../types/PaginatedQueryParams";
import  { CreateLdlBody } from "../../../Pages/Applications/LocalDrivvingLicense/CreateLDLApplication";
import { handleRtkQueryErrors } from "../../helpers";
import { isNumber } from "../../../utils/isNumber";
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

export type UpdateLDLApplicationStatusParams = {
    Status: "Cancel" | "New" | "Completed",
    LDLApplicationId : number,
}


// type CreatePersonBody = CreatePersonFormFields;
// export type UpdatePersonBody = CreatePersonBody;



// export type getPersonEditDetailsResponse = CreatePersonBody

export const LDLApplicationsApi =  apiSlice.injectEndpoints({
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
        CreateLDLApplication: builder.mutation<number, CreateLdlBody>({
            query: (createLDLBody) => {
                return {
                    url: `${LDLApplicationsEndPoint}/`,
                    method: "POST",
                    body: createLDLBody
                }
            },
            invalidatesTags: [`AllLDLApplications`],
            transformResponse(response: {Response: number }) {
                return response.Response
            },
            transformErrorResponse: (error) => {
                const errorData = handleRtkQueryErrors(error)
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            },
        }),
        updateLDLApplicationsStatus: builder.mutation<boolean, number>({
            query: (LDLApplicationId) => {
                return {
                    url: `Applications/${LDLApplicationId}/Status`,
                    method: "PUT",
                }
            },
            invalidatesTags: [`AllLDLApplications`],
            transformResponse(response: {Response: boolean }) {
                console.log(response);
                return response.Response
            },
            transformErrorResponse: (error) => {
                const errorData = handleRtkQueryErrors(error)
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            },
        }),
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
        useGetAllLDLApplicationsQuery,
        useCreateLDLApplicationMutation,
        useUpdateLDLApplicationsStatusMutation,
    } = LDLApplicationsApi