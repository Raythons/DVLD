import { apiSlice } from "./apiSlice";
import { PaginatedQueryParams } from "../../types/PaginatedQueryParams";
// import { handleRtkQueryErrors } from "../helpers";
// import { isNumber } from "../../utils/isNumber";

export const LicensesClassesEndPoint = "LicenseClass"

export type GetAllPeopleQueryParams = PaginatedQueryParams;

export type GetLicensesListData = {
    Id: number,
    ClassName: string,
}

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





// type EditPersonBody = CreatePersonBody;



export const peopleApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getAllLicensesClasses: builder.query<GetLicensesListData[], undefined>({
            query: () => ({
                url: `${LicensesClassesEndPoint}/`,
            }),
            providesTags: [`AllPeople`],
            transformResponse: (response: {Response: GetLicensesListData[] }) => {
                return response.Response
            },
        }),
    
    })
})

export const {
        useGetAllLicensesClassesQuery
    } = peopleApi