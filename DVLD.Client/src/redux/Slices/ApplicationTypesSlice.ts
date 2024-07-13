// import {  createSlice } from '@reduxjs/toolkit'
// import { PayloadAction } from '@reduxjs/toolkit'
// import { ApplicationType } from '../api/ApplicationsTypeApi'

// export type authState = {
//     applicationsTypes: ApplicationType[]
// }

// const initialState = {
//     applicationsTypes: []
// } as authState

// // type UserDisplayData  = Pick<authState, "UserName" | "Image">

// const applicationsTypeSlice =  createSlice({
//     name: 'applicationsTypes',
//     initialState,
//     reducers:  {
//         setApplicationTypes(state, action : PayloadAction<ApplicationType[]>){
//             state.applicationsTypes = action.payload
//         },
//     },
//     selectors: {
//         selectApplicationTypes: (state) => state.applicationsTypes,
//     }
// })

// export const {setApplicationTypes } = applicationsTypeSlice.actions

// export  const {selectApplicationTypes  }  = applicationsTypeSlice.selectors
// // export type AuthState = ReturnType<typeof  authSlice.selectSlice> 
// export default applicationsTypeSlice.reducer;

