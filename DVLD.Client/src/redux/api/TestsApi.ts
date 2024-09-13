import { apiSlice } from "./apiSlice";
import { handleRtkQueryErrors } from "../helpers";
import { isNumber } from "../../utils/isNumber";
import { ApiError } from "./peopleApi";

export const TestEndPoint = "Test";


export type TakeTestParams = {
    TestAppointmentId: number,
    TestResult: number
    CreatedByUserId: number
    Notes: string;
}

export const TestApi =  apiSlice.injectEndpoints({
    endpoints: (builder) => ({
        TakeTestTest :  builder.mutation<boolean ,TakeTestParams>({
            query: (body) => (
                {
                    url: `${TestEndPoint}`,
                    method: "POST",
                    body
                }
            ),
            invalidatesTags: [`TestAppointments`, `Tests`, `AllLDLApplications`],
            transformResponse : (QueryReturnValue: {Response: boolean} )  => {    
                console.log(`response ${QueryReturnValue.Response}`);
                console.log(QueryReturnValue.Response);
                return QueryReturnValue.Response
            },
            transformErrorResponse: (error) : ApiError  =>{
                console.log(`error %%%%%`);
                console.log(error.data);
                
                const errorData = handleRtkQueryErrors(error)
                
                if(isNumber(error.status)) {
                    errorData.status  = error.status as number;
                }   
                console.log(errorData.Reasons);

                return errorData
            },
        }),
    
    })
})

export const {
        useTakeTestTestMutation
    } = TestApi