import { apiSlice } from "../apiSlice"
// import { handleRtkQueryErrors } from "../helpers";

export const ApplicationTypeEndPoint = "ApplicationTypes"


export type ApplicationType  = {
    ApplicationTypeId: number,
    ApplicationTypeTitle: string,
    ApplicationTypeFees: number
}

export const ApplicationsTypes =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        getAllApplicationsType: builder.query({
                query:  () => ({
                    url: `${ApplicationTypeEndPoint}`,
                    method: "GET"
                }),
                providesTags: ['ApplicationBriefInfo', 'TestAppointments'],
                keepUnusedDataFor: Infinity,
                transformResponse : (QueryReturnValue: ApplicationType[])  => {                    
                    return QueryReturnValue
                },
        })
        // editPerson: builder.mutation<boolean, EditPersonBody>( )
    })
})

export const {useGetAllApplicationsTypeQuery, useLazyGetAllApplicationsTypeQuery} = ApplicationsTypes;