import { useEffect } from "react"
import { GetPersonDataResponse, useLazyGetPersonDetailsByNationalNumberQuery, useLazyGetPersonDetailsQuery } from "../redux/api/peopleApi"
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

export const useGetPersonDetails = (searchTerm: string | undefined, SearchBy: SearchBy): returnType => {

    const [getPersonDetails, {data: IdResult, isError: isIdError, isLoading : isIdLoading, isSuccess: isIdSuccess, error: IdError} ] = useLazyGetPersonDetailsQuery()
    const [getPersonDetailsByNo, {data: NoResult, isError: isNoError, isLoading : isNoLoading, error: NoError}] 
            = useLazyGetPersonDetailsByNationalNumberQuery()
    // const [returnState, setReturnState] = useState<returnType>();
    
    useEffect(() => {
        if (SearchBy === "NationalNo" && searchTerm ) 
            getPersonDetailsByNo(Number(searchTerm))
        else if (SearchBy === "Id" && searchTerm){
            getPersonDetails(Number(searchTerm))
        }

    }, [getPersonDetails, getPersonDetailsByNo, searchTerm, SearchBy])


    
    if(SearchBy === "NationalNo")
        return {data: NoResult, isError: isNoError, isLoading: isNoLoading, isSuccess: isIdSuccess,  error: NoError};
    else if (SearchBy === "Id")
        return {data : IdResult, isError: isIdError, isLoading: isIdLoading, isSuccess:isIdSuccess ,  error: IdError};

    return {data : undefined, isError: false, isLoading: false, isSuccess: false,  error: IdError};
}