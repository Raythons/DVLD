import { apiSlice } from "../apiSlice";
import { PaginatedQueryParams } from "../../../types/PaginatedQueryParams";
import { handleRtkQueryErrors } from "../../helpers";
import { isNumber } from "../../../utils/isNumber";
import { ApiError } from "../peopleApi";
// import { CreatePersonFormFields } from "../../types/AddPersonType";
// import fillFormFiles from "../../utils/fillFormFiles";
// import { handleRtkQueryErrors } from "../helpers";
// import { isNumber } from "../../utils/isNumber";

export const ApplicationsEndPoint = "Applications"

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

export type  GetApplicationBasicInfo = {
    Id: number,
    FullName: string,
    ApplicationTypeTitle: string
    Status : string,
    CreatedAt : string,
    LastStatusDate: string
    PaidFees: number,   
    CreatedByUser: string
}


export const LDLApplicationsApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getApplicationBasicInfo :  builder.query<GetApplicationBasicInfo, number>({
            query: (LDLApplicationId) => (
                {
                    url: `${ApplicationsEndPoint}/${LDLApplicationId}`,
                }
            ),
            transformResponse : (QueryReturnValue: {Response: GetApplicationBasicInfo})  => {
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
    useGetApplicationBasicInfoQuery
    } = LDLApplicationsApi