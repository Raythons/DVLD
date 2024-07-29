import {  createSlice } from '@reduxjs/toolkit'
import { PayloadAction } from '@reduxjs/toolkit'
import { ApplicationType } from '../api/ApplicationsTypeApi'

export type ApplicationsTypesState = {
    applicationsTypes: ApplicationType[]
}

const initialState = {
    applicationsTypes: []
} as ApplicationsTypesState

// type UserDisplayData  = Pick<authState, "UserName" | "Image">

const applicationsTypeSlice =  createSlice({
    name: 'applicationsTypes',
    initialState,
    reducers:  {
        setApplicationTypes(state, action : PayloadAction<ApplicationType[]>){
            state.applicationsTypes = action.payload
        },
    },
    selectors: {
        selectApplicationTypes: (state) => state.applicationsTypes,
        selectApplicationTypesById: (state, Id: number) => {
            return state.applicationsTypes.find((applicationType) => applicationType.ApplicationTypeId === Id)
        }
    }
})

export const {setApplicationTypes } = applicationsTypeSlice.actions

export  const {selectApplicationTypes  }  = applicationsTypeSlice.selectors
// export type AuthState = ReturnType<typeof  authSlice.selectSlice> 
export default applicationsTypeSlice.reducer;

