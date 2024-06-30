import { apiSlice } from "./apiSlice";
import { CreatePersonFormFields } from "../../types/AddPersonType";
// import { handleRtkQueryErrors } from "../helpers";
export const PeopleEndPoint = "Person"




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

type CreatePersonBody = CreatePersonFormFields;

// type EditPersonBody = CreatePersonBody;
export type Country = {
    Id: number,
    CountryName: string,
} 
export const CountryEndPoint = "country"


export type getPersonEditDetailsResponse = CreatePersonBody

export const CountriesApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getAllCountries: builder.query({
                query:  () => ({
                    url: `${CountryEndPoint}`,
                }),
                transformResponse : (QueryReturnValue: Country[])  => {
                    return QueryReturnValue
                },
            
        })
        // editPerson: builder.mutation<boolean, EditPersonBody>( )
    })
})

export const {useGetAllCountriesQuery} = CountriesApi;