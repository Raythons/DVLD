import { apiSlice } from "./apiSlice";
// import { handleRtkQueryErrors } from "../helpers";
export const TestTypesEndPoint = "TestType"


export type TestType  = {
    Id: number,
    TestTypeTitle:string,
    TestTypeDescription: string,
    TestTypeFees: number,
}

export const TestTypesApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getAllTestTypes: builder.query({
                query:  () => ({
                    url: `${TestTypesEndPoint}`,
                    method: "GET"
                }),
                keepUnusedDataFor: Infinity,
                transformResponse : (QueryReturnValue: TestType[])  => {
                    return QueryReturnValue
                },
        })
    })
})

export const {useGetAllTestTypesQuery} = TestTypesApi;