import useLocalStorage from "../hooks/useLocalStorage";
import { MouseEvent, useEffect, useState } from "react";
import { FaUser } from "react-icons/fa6";

// import { useEffect, useState } from "react";
import { useDispatch } from "react-redux";
import { setLoggedInUser } from "../redux/Slices/authSlice";
import { useLoginMutation } from "../redux/api/authApiSlice";
import { LoginCredentials } from "../types/AuthTypes";
import {  useNavigate } from "react-router-dom";

import { IconContext } from "react-icons";
import { IoLockClosed } from "react-icons/io5";


type UserInfo = { UserName: string; Password: string };

  function SignIn() {
    
    // const token = useSelector(selectAuthToken)
    const dispatch = useDispatch();
    const [login] = useLoginMutation();
    const navigate = useNavigate();

    useEffect(() => {
    })
    
    const {
      getItem: getUserInfo,
        //   setItem: setUserInfo,
        //   deleteItem: deleteUserInfo,
    } = useLocalStorage("user");
    
    const UserInfo: UserInfo | undefined = getUserInfo();
    const [userName, setUserName] = useState(UserInfo?.UserName ?? "");
    const [password, setPassword] = useState(UserInfo?.Password ?? "");

  
  
    const handleSubmit = async  (e: MouseEvent<HTMLButtonElement>) => { 
        e.preventDefault()
        if (userName && password) {
          const credentials: LoginCredentials  = {userName, password} 
          try {
                const loginInfo = await login(credentials).unwrap()
                dispatch(setLoggedInUser(loginInfo))
                setUserName("");
                setPassword("");
                navigate("home")
          } catch (error) {
              console.log(error)
          }
      }
    };
    
    return (
        <div className="bg-gradient-to-r  from-cyan-500 to-blue-500 min-h-screen  flex flex-col justify-center  items-center ">

          <form  
          className="flex items-center justify-around flex-col bg-slate-50  min-h-400px min-w-400px  rounded-md">
          <div className=" flex flex-col justify-center items-center">
            <p className=" text-blue-500  text-lg">
                Login 
            </p>
            <h1 className="text-blue-500 text-2xl  ">
                Please Login
            </h1>
          
        </div>

          <div className="flex items-center justify-center flex-col min-w-p80">
            <div className="mb-5 ">
                
                <label htmlFor="userName" className="block mb-2 text-sm font-medium relative   text-blue-500 ">UserName
                  <IconContext.Provider value={{className:"text-blue-500 absolute min-w-9 top-10 "}} >
                  <FaUser  />
                  </IconContext.Provider>
                </label>
                <input type="userName" id="userName" onChange={(e) => setUserName(e.target.value)} className="bg-gray-50  pl-8 border  border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 " placeholder="UserName" required  />
              </div>
              <div className="mb-5">
              
                <label htmlFor="password" className="block mb-2 text-sm font-medium relative  text-blue-500">Your password
                <IconContext.Provider value={{className:"text-blue-500 absolute min-w-9 top-10 "}} >
                  <IoLockClosed />
                </IconContext.Provider>
                </label>
                <input type="password" id="password" onChange={(e) => setPassword(e.target.value)}  placeholder= "Password" className="bg-gray-50 border  pl-8 border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 " required />
              </div>
          </div>
            <button type="button" onClick={handleSubmit} className="text-white bg-blue-500 transition duration-300 hover:bg-blue-700 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-center ">Login</button>
          </form>
        </div>
        
    );
  }

export default SignIn;


{/* <form  className=" flex items-center justify-around flex-col bg-slate-50  min-h-400px min-w-400px  rounded-md">
<div className=" flex flex-col justify-center items-center">
    <p className=" text-blue-500  text-lg">
        Login 
    </p>
    <h1 className="text-blue-500 text-2xl  ">
        Please Login
    </h1>
  
</div>

<div className="flex items-center justify-center flex-col min-w-p80">

    <label htmlFor="username" className="   text-stone-500">User Name</label>
    <input className="min-w-80p " title="username" type="text" name="username" id="" />

    <label htmlFor="password" className=" text-slate-500"> Password</label>
    <input className="min-w-80p "  title="password"  type="text" name="password" />
</div>

  <button type="submit"> Login </button>
</form> */}