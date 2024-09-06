import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
import { handleRtkQueryErrors } from "../helpers";
import { isNumber } from "../../utils/isNumber";
import { ApiError } from "./peopleApi";
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
}

export type GetApplicationTestAppointmentsListParams = {
    localDrivingLicenseApplicationId: number,
    testTypeId: number
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
                console.log(QueryReturnValue.Response.Items);
                
                return QueryReturnValue.Response.Items
            },
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
                    params
                }
            ),
            transformResponse : (QueryReturnValue: {Response: boolean} )  => {                
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
    useCreateTestAppointmentMutation
    } = TestAppointmentApi