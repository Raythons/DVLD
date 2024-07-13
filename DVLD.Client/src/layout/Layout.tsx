import Header from "./Header"

import {  Outlet, useNavigate } from "react-router-dom";
import { useSelector } from "react-redux";
import { selectAuthToken } from "../redux/Slices/authSlice"; 
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
        <div className="flex justify-center items-center h-[91vh] bg-slate-800 ">
          <Outlet />
        </div>
    </>
  )
}

export default Layout