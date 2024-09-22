import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
import { isNumber } from "../../utils/isNumber";
import { handleRtkQueryErrors } from "../helpers";
import { apiSlice } from "./apiSlice";
// import { handleRtkQueryErrors } from "../helpers";
export const DriversEndPoint = "Driver"




// type EditPersonBody = CreatePersonBody;
export type DriverBriefInfo = {
    DriverId: number,
    PersonId: number,
    NumberOfActiveLicenses: number,
    CreatedAt: string,
    FullName: string,
} 

type GetAllDriversQueryParams = PaginatedQueryParams


export const DriversApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getAllDrivers: builder.query< DriverBriefInfo[] ,GetAllDriversQueryParams>({
                query:  (params) => ({
                    url: `${DriversEndPoint}`,
                    params
                }),
                transformResponse : (response: {Response: {Items: DriverBriefInfo[]}})  => {
                    return response.Response.Items
                },
                transformErrorResponse: (error) => {
                    const errorData = handleRtkQueryErrors(error)
                    
                    if(isNumber(error.status)) {
                        errorData.status  = error.status as number;
                    }   
                    return errorData
                },
        })
    })
})

export const {useGetAllDriversQuery} = DriversApi;