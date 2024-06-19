import {  createSlice } from '@reduxjs/toolkit'
import { PayloadAction } from '@reduxjs/toolkit'


export type authState = {
    accessToken: string,
    UserName: string,
    Image: string
}

const initialState = {
    accessToken : "سسس",
    UserName: "",
    Image: ""
} as authState

// type UserDisplayData  = Pick<authState, "UserName" | "Image">

const authSlice =  createSlice({
    name: 'auth',
    initialState,
    reducers:  {
        setLoggedInUser(state, action: PayloadAction<authState> ){
            return  {...state, ...action.payload}
        },
        setAuthToken(state, action : PayloadAction<string>){
            state.accessToken = action.payload
        },
        setLoggedOut (state){
            state = {} as authState;
            return state;
        }
    },
    selectors: {
        selectAuthToken: (state) => state.accessToken,
        selectUserData: (state) => state
    }
})

export const {setAuthToken , setLoggedInUser, setLoggedOut} = authSlice.actions

export  const {selectAuthToken ,selectUserData }  = authSlice.selectors
// export type AuthState = ReturnType<typeof  authSlice.selectSlice> 
export default authSlice.reducer;

