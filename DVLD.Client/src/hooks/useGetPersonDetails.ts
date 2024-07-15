import { useEffect } from "react"
import { GetPersonDataResponse, useLazyGetPersonDetailsByNationalNumberQuery, useLazyGetPersonDetailsQuery } from "../redux/api/peopleApi"
import { FetchBaseQueryError } from "@reduxjs/toolkit/query"
import { SerializedError } from "@reduxjs/toolkit"

export type SearchBy =  "NationalNo" | "Id"

type returnType =  {
    data: GetPersonDataResponse | undefined,
    isError: boolean,
    isLoading: boolean,
    error?: FetchBaseQueryError  | SerializedError | undefined
}

export const useGetPersonDetails = (searchTerm: string, SearchBy: SearchBy): returnType => {

    const [getPersonDetails, {data: IdResult, isError: isIdError, isLoading : isIdLoading, error: IdError} ] = useLazyGetPersonDetailsQuery()
    const [getPersonDetailsByNo, {data: NoResult, isError: isNoError, isLoading : isNoLoading, error: NoError}] 
            = useLazyGetPersonDetailsByNationalNumberQuery()
    // const [returnState, setReturnState] = useState<returnType>();
    
    useEffect(() => {
        if (SearchBy === "NationalNo") 
            getPersonDetailsByNo(Number(searchTerm))
        else if (SearchBy === "Id"){
            getPersonDetails(Number(searchTerm))
        }
    }, [getPersonDetails, getPersonDetailsByNo, searchTerm, SearchBy])

    console.log(IdResult);
    
    if(SearchBy === "NationalNo")
        return {data: NoResult, isError: isNoError, isLoading: isNoLoading,  error: NoError};
    else if (SearchBy === "Id")
        return {data : NoResult, isError: isIdError, isLoading: isIdLoading,  error: IdError};

    return {data : NoResult, isError: isIdError, isLoading: isIdLoading,  error: IdError};
}