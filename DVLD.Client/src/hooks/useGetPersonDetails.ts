import { useEffect } from "react"
import { GetPersonDataResponse, GetPersonDetailsParams,useLazyGetPersonDetailsQuery } from "../redux/api/peopleApi"
import { FetchBaseQueryError } from "@reduxjs/toolkit/query"
import { SerializedError } from "@reduxjs/toolkit"

export type SearchBy =  "NationalNo" | "Id"

type returnType =  {
    data: GetPersonDataResponse | undefined,
    isError: boolean,
    isLoading: boolean,
    isSuccess: boolean,
    error?: FetchBaseQueryError  | SerializedError | undefined
}

export const useGetPersonDetails = (searchTerm: string | undefined, searchBy: SearchBy): returnType => {

    const [getPersonDetails, {data: IdResult, isError: isIdError, isLoading : isIdLoading, isSuccess: isIdSuccess, error: IdError} ] = useLazyGetPersonDetailsQuery()

    
    useEffect(() => {
        if (searchBy !== undefined && searchTerm ) 
            getPersonDetails({ searchTerm, searchBy } as unknown as GetPersonDetailsParams)


    }, [getPersonDetails, searchTerm, searchBy])

    return {data : IdResult, isError: isIdError, isLoading: isIdLoading, isSuccess: isIdSuccess,  error: IdError};
}