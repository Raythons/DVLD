import { apiSlice } from "../apiSlice";
import { PaginatedQueryParams } from "../../../types/PaginatedQueryParams";
import  { CreateLdlBody } from "../../../Pages/Applications/LocalDrivvingLicense/CreateLDLApplication";
import { handleRtkQueryErrors } from "../../helpers";
import { isNumber } from "../../../utils/isNumber";
import { ApiError } from "../peopleApi";
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

export type  GetLDLApplicationBriefInfoResponse = {
    Id: number,
    LicenseClass : string,
    PassedTests : number,
    TestsCount: number
}

export const LDLApplicationsApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getLDLApplicationBriefInfo :  builder.query<GetLDLApplicationBriefInfoResponse, number>({
            query: (LDLApplicationId) => (
                {
                    url: `${LDLApplicationsEndPoint}/${LDLApplicationId}`,
                }
            ),
            providesTags: ["ApplicationBriefInfo"],
            transformResponse : (QueryReturnValue: {Response: GetLDLApplicationBriefInfoResponse})  => {
                return QueryReturnValue.Response
            },
            transformErrorResponse: (error) : ApiError  =>{
                const errorData = handleRtkQueryErrors(error)
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            }
        }),
        getLDLApplicationId:  builder.query<number, number>({
            query: (LDLApplicationId) => (
                {
                    url: `${LDLApplicationsEndPoint}/applicationId/${LDLApplicationId}`,
                }
            ),
            transformResponse : (QueryReturnValue: {Response: number})  => {                
                return QueryReturnValue.Response
            },
            transformErrorResponse: (error) : ApiError  =>{
                const errorData = handleRtkQueryErrors(error)
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            }
        }),
        getAllLDLApplications: builder.query<GetLDlListData[], GetAllLDLAppQueryParams>({
            query: (getALLQueryParams) => ({
                url: `${LDLApplicationsEndPoint}/`,
                params: getALLQueryParams,
            }),
            providesTags: ["AllLDLApplications"],
            transformResponse: (response: {Response:  {Items: GetLDlListData[] }}) => {
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
    })
})

export const {
        useGetLDLApplicationIdQuery,
        useGetLDLApplicationBriefInfoQuery,
        useGetAllLDLApplicationsQuery,
        useCreateLDLApplicationMutation,
        useUpdateLDLApplicationsStatusMutation,
    } = LDLApplicationsApi