import { apiSlice } from "./apiSlice";
import { handleRtkQueryErrors } from "../helpers";
import { isNumber } from "../../utils/isNumber";
import { ApiError } from "./peopleApi";
import { ApplicationsEndPoint } from "./Applications/BasicApplicationsApi";
export const PeopleEndPoint = "Person"



const internationalLicenseApi = `${ApplicationsEndPoint}/InternationallDrivvingLicense`;

export type IssueInternationalLicenseRequest =  {
    ApplicationTypeId: number,
    ApplicationTypeFees: number,
    DriverId: number,
    LicenseId: number
}

export const interNationalLicenseApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        issueInterNationalLicense :  builder.mutation<boolean, IssueInternationalLicenseRequest>({
            query: (body) => (
                {
                    url: `${internationalLicenseApi}/`,
                    method: "POST",
                    body
                }
            ),
            transformResponse : (QueryReturnValue: {Response: boolean})  => {
                console.log(QueryReturnValue.Response);
                
                return QueryReturnValue.Response
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
    })
})

export const {
    useIssueInterNationalLicenseMutation,
    } = interNationalLicenseApi