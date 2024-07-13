import { FetchBaseQueryError } from '@reduxjs/toolkit/query'
import { ApiError, MainApiResponse } from './api/peopleApi'
/**
 * Type predicate to narrow an unknown error to `FetchBaseQueryError`
 */
export function isFetchBaseQueryError(
  error: unknown,
): error is FetchBaseQueryError {
  return typeof error === 'object' && error != null && 'status' in error
}

/**
 * Type predicate to narrow an unknown error to an object with a string 'message' property
 */
export function isApiError(
  error: unknown,
): error is ApiError {
  return (
    typeof error === 'object' &&
    error != null &&
    'Errors' in error 
  )
}
export function handleRtkQueryErrors(error: FetchBaseQueryError): ApiError {
          if(error.status ===  "FETCH_ERROR" ){
            return  { 
                        Message:"SomeThing Went Wrong Please try again later",
                        Code: "",
                        Reasons: []
                    } as ApiError
          } 
          else if (error.status === "TIMEOUT_ERROR") {
                  return {
                          Message: "Couldn't Get The Result Due To The Long Process Time Please Try Again Later",
                          Code: "",
                          Reasons: []
                  }
          }
          else if (error.status ===  "PARSING_ERROR") {
              return {
                      Message: `${error.data}`,
                      Code: "",
                      Reasons: []
              }
          }
          const errorData = error.data as MainApiResponse
          return errorData.Errors[0] as ApiError
}