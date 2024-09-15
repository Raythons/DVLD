import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
// import { handleRtkQueryErrors } from "../helpers";
// import { isNumber } from "../../utils/isNumber";

export const LicensesEndPoint = "License"

export type GetAllPeopleQueryParams = PaginatedQueryParams;



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

export type issueLicenseParams = {
    ApplicationTypeId: number,
    LocalDrivingLicenseApplicationId: number,
    Notes : string,
    PaidFees: number,
    IssueReason?: string
}

export const LicenseApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        issueLicense: builder.mutation<boolean, issueLicenseParams>({
            query: (body) => ({
                url: `${LicensesEndPoint}/`,
                method: "Post",
                body
            }),
            transformResponse: (response: {Response: boolean }) => {
                return response.Response
            },
        }),
    })
})

export const {
        useIssueLicenseMutation
    } = LicenseApi