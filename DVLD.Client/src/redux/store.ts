import { configureStore } from "@reduxjs/toolkit";
import authReducer from "./Slices/authSlice"
import { persistStore, persistReducer } from 'redux-persist'

import storage from 'redux-persist/lib/storage' // defaults to localStorage for web
import { apiSlice  } from "./api/apiSlice";

const persistConfig = {
    key: 'root',
    storage,
}

const authPersistedReducer = persistReducer(persistConfig, authReducer)

export const store = configureStore({
    reducer: {
        auth : authPersistedReducer,
        [apiSlice.reducerPath]: apiSlice.reducer,
    },
    middleware : getDefaultMiddleWare => getDefaultMiddleWare({serializableCheck: false}).concat(apiSlice.middleware),
    devTools: true
})

export type RootState = ReturnType<typeof store.getState>;

export type AppDispatch = typeof store.dispatch
// export const useAppDispatch = useDispatch.withTypes<AppDispatch>() 

export const persistor = persistStore(store)

