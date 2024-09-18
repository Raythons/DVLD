import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
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
    isActive: boolean;
    CreatedByUserId: number,
    ImagePath: string
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
        getLicenseInfo: builder.query<GetLicenseInfoResponse, number>({
            query: (licenseId) => ({
                url: `${LicensesEndPoint}/${licenseId}`,
                method: "Get",
            }),
            transformResponse: (QueryReturnValue: {Response: GetLicenseInfoResponse }) => {
                return QueryReturnValue.Response
            },
        }),
    })
})

export const {
        useIssueLicenseMutation,
        useGetLicenseInfoQuery,
        useLazyGetLicenseInfoQuery
    } = LicenseApi