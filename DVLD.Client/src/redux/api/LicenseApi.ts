import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
import { handleRtkQueryErrors } from "../helpers";
import { ApiError } from "./peopleApi";
import { isNumber } from "../../utils/isNumber";
import { EnReplacementType } from "../../enums/ReplacmentType";
// import { handleRtkQueryErrors } from "../helpers";
// import { isNumber } from "../../utils/isNumber";

export const LicensesEndPoint = "License"

export type GetAllPeopleQueryParams = PaginatedQueryParams;



// export type ApiError = {
//     Code?: string,
//     Message: string,
//     Reasons: string[],
//     status?: number;
// }

// export type MainApiResponse  =  {
//     Errors: ApiError[]
//     IsSuccess: boolean,
//     Response: unknown,
// }

export type issueLicenseParams = {
    ApplicationTypeId: number,
    LocalDrivingLicenseApplicationId: number,
    Notes : string,
    PaidFees: number,
    IssueReason?: string
}

export type GetLicenseInfoResponse = {
    Id: number,
    DriverId: number,
    LicenseClass : string,
    Name: string,
    IssueReason?: string
    Gender: string,
    NationalNo: string,
    DateOfBirth: string,
    IssueDate: string,
    ExpirationDate: string,
    Notes : string,
    IsActive: boolean;
    CreatedByUserId: number,
    ImagePath: string
}


export type ApplicationNewLicenseInfoRequest = {
    RenewApplicationId: number,
    ApplicationDate: string,
    IssueDate : string
    ApplicationTypeId: number,
    ApplicationFees: number,
    LicenseFees: number,
    RenewedLicenseId: number,
    PreviousLicenseId : number,
    CreatedBy: string,
    TotalFees : number 
    Notes: string
}

export type ApplicationReplacementLicenseInfoRequest = {
    RenewApplicationId: number,
    ApplicationDate: string,
    ApplicationTypeId: number,
    ApplicationFees: number,
    RenewedLicenseId: number,
    PreviousLicenseId : number,
    ReplacementType: EnReplacementType
    CreatedBy: string,
}


export type ReleaseLicenseRequest = {
    ReleaseId: number,
    DetainId: number,
    FineFees: number,
    DetainDate: string,
    ApplicationTypeId: number,
    ApplicationFees: number,
    LicenseId: number,
    CreatedBy: string,
}

export type DetainLicenseInfoRequest = {
    DetainedLicenseId: number,
    FineFees: number,
    LicenseId : number,
    CreatedBy: string,
}


export type  ReplaceLicenseResponse = RenewLicenseResponse ;

export type DetainLicenseResponse = {
    DetainLicenseId: number
}
export type  RenewLicenseResponse = {
    ApplicationId:number,
    PreviousLicenseId: number,
    NewLicenseId: number,
}
export type ReleaseLicenseResponse = {
    ReleaseId: number,
}
export type GetDetainedLicenseInfoResponse = {
    DetainDate: string
    CreatedBy: string
    FineFees: number,
}

export const LicenseApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        issueLicense: builder.mutation<boolean, issueLicenseParams>({
            query: (body) => ({
                url: `${LicensesEndPoint}/`,
                method: "POST",
                body
            }),
            transformResponse: (response: {Response: boolean }) => {
                return response.Response
            },
        }),
        replaceLicense: builder.mutation<ReplaceLicenseResponse, ApplicationReplacementLicenseInfoRequest>({
            query: (body) => ({
                url: `${LicensesEndPoint}/replace`,
                method: "PUT",
                body
            }),
            transformResponse: (response: {Response: RenewLicenseResponse }) => {
                return response.Response
            },
            transformErrorResponse: (error) : ApiError  =>{
                console.log(error);
                const errorData = handleRtkQueryErrors(error)
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            }
        }),
        getDetainedLicenseInfo: builder.query<GetDetainedLicenseInfoResponse, number>({
            query: (licenseId) => ({
                url: `${LicensesEndPoint}/detain/${licenseId}`,
                method: "Get",
            }),
            transformResponse: (QueryReturnValue: {Response: GetDetainedLicenseInfoResponse }) => {
                return QueryReturnValue.Response
            },
        }),
        detainLicense: builder.mutation<DetainLicenseResponse, DetainLicenseInfoRequest>({
            query: (body) => ({
                url: `${LicensesEndPoint}/detain`,
                method: "POST",
                body
            }),
            transformResponse: (response: {Response: DetainLicenseResponse }) => {
                console.log(response.Response);
                
                return response.Response
            },
            transformErrorResponse: (error) : ApiError  =>{
                console.log(error);
                const errorData = handleRtkQueryErrors(error)
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            }
        }),
        releaseLicense: builder.mutation<number, ReleaseLicenseRequest>({
            query: (body) => ({
                url: `${LicensesEndPoint}/release`,
                method: "POST",
                body
            }),
            transformResponse: (response: {Response: number }) => {
                return response.Response
            },
            transformErrorResponse: (error) : ApiError  =>{
                const errorData = handleRtkQueryErrors(error)
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            }
        }),
        renewLicense: builder.mutation<RenewLicenseResponse, ApplicationNewLicenseInfoRequest>({
            query: (body) => ({
                url: `${LicensesEndPoint}/renew`,
                method: "POST",
                body
            }),
            transformResponse: (response: {Response: RenewLicenseResponse }) => {
                return response.Response
            },
            transformErrorResponse: (error) : ApiError  =>{
                console.log(error);
                
                const errorData = handleRtkQueryErrors(error)
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                return errorData
            }
        }),
        getLicenseInfo: builder.query<GetLicenseInfoResponse, number>({
            query: (licenseId) => ({
                url: `${LicensesEndPoint}/${licenseId}`,
                method: "Get",
            }),
            transformResponse: (QueryReturnValue: {Response: GetLicenseInfoResponse }) => {
                return QueryReturnValue.Response
            },
        }),
        getLicenseIdByApplicationId: builder.query<number, number>({
            query: (AppId) => ({
                url: `${LicensesEndPoint}/licenseid/${AppId}`,
                method: "Get",
            }),
            transformResponse: (QueryReturnValue: {Response: number }) => {
                console.log(QueryReturnValue.Response);
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
    })
})

export const {
        useIssueLicenseMutation,
        useGetLicenseInfoQuery,
        useLazyGetLicenseInfoQuery,
        useLazyGetLicenseIdByApplicationIdQuery,
        useRenewLicenseMutation,
        useReplaceLicenseMutation,
        useDetainLicenseMutation,
        useReleaseLicenseMutation,
        useLazyGetDetainedLicenseInfoQuery
    } = LicenseApi