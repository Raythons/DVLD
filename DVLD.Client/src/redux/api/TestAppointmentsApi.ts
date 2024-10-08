import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
import { handleRtkQueryErrors } from "../helpers";
import { isNumber } from "../../utils/isNumber";
import { ApiError } from "./peopleApi";
import { TestEndPoint } from "./TestsApi";
export const TestAppointmentsEndPoint = "TestAppointments"

export type GetAllPeopleQueryParams = PaginatedQueryParams;

type GetLDLApplicationTestAppointmentsListResponse = {
    AppointmentId: number
    AppointmentDate: string
    PaidFees: number
    IsLocked: boolean
} 

export type CreateTestAppointmentRequestParams = {
    TestTypeId: number,
    LocalDrivingLicenseApplicationId: number,
    AppointmentDate: string,
    PaidFees: number,
    CreatedByUserId: number,
    ApplicationsTypeId?: number,
    ApplicationTypeFees?: number
}

export type GetApplicationTestAppointmentsListParams = {
    localDrivingLicenseApplicationId: number,
    testTypeId: number
}


export type getLastTestTypeResult  = {
    TestResult : number
}

export type getLastTestTypeResultParams = {
    LocalDrivingLicenseApplicationId: number,
    TestTypeId: number
}
export const TestAppointmentApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getLDLApplicationTestAppointmentsList :  builder.query<GetLDLApplicationTestAppointmentsListResponse[] ,GetApplicationTestAppointmentsListParams>({
            query: (getApplicationTestAppointmentsListParams) => (
                {
                    url: `${TestAppointmentsEndPoint}/`,
                    method: "GET",
                    params: getApplicationTestAppointmentsListParams
                }
            ),
            transformResponse : (QueryReturnValue: {Response: {Items: GetLDLApplicationTestAppointmentsListResponse[]}} )  => {                
                
                return QueryReturnValue.Response.Items
            },
            providesTags: ["TestAppointments", `Tests`, ],
            transformErrorResponse: (error) : ApiError  =>{
                const errorData = handleRtkQueryErrors(error)
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            },
        }),
        createTestAppointment :  builder.mutation<boolean ,CreateTestAppointmentRequestParams>({
            query: (params) => (
                {
                    url: `${TestAppointmentsEndPoint}`,
                    method: "POST",
                    body: params
                }
            ),
            invalidatesTags: [`TestAppointments` , `Tests`],
            transformResponse : (QueryReturnValue: {IsSuccess: boolean} )  => {  
                return QueryReturnValue.IsSuccess
            },
            transformErrorResponse: (error) : ApiError  =>{
                console.log(`error %%%%%`);
                console.log(error.data);
                
                const errorData = handleRtkQueryErrors(error)
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                console.log(errorData.Reasons);

                return errorData
            },
        }),
        getLastTestTypeResult :  builder.query<getLastTestTypeResult ,getLastTestTypeResultParams>({
            query: (getLastTestTypeResultParams) => (
                {
                    url: `${TestEndPoint}/TestResult`,
                    method: "GET",
                    params: getLastTestTypeResultParams
                }
            ),
            keepUnusedDataFor: 1,
            providesTags: [`ApplicationBriefInfo`, `Tests`, `TestAppointments`, 'AllLDLApplications'],
            transformResponse : (QueryReturnValue: {Response: getLastTestTypeResult} )  => {   
                console.log("fromm repose");
                
                console.log(QueryReturnValue.Response);
                
                return QueryReturnValue.Response
            },
            transformErrorResponse: (error) : ApiError  =>{
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
    useGetLDLApplicationTestAppointmentsListQuery,
    useGetLastTestTypeResultQuery,
    useCreateTestAppointmentMutation
    } = TestAppointmentApi