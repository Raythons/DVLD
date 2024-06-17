import Header from "./Header"
import Footer from './Footer'

import {  Outlet, useNavigate } from "react-router-dom";
import { useSelector } from "react-redux";
import { selectAuthToken } from "../redux/features/authSlice"; 
import { useLayoutEffect } from "react";


const Layout = () => {
  const token = useSelector(selectAuthToken);
  const navigate = useNavigate();
  
  useLayoutEffect (()=> {
      if(!token) {
        navigate("/", {replace: true})
      }
  })
  return (
    <>
        <Header />
        {/* {token ? */}
                <Outlet />
                {/* : */}
                {/* navigate("/", {replace: true}) */}
        {/* } */}
        <Footer />
    </>
  )
}

export default Layout