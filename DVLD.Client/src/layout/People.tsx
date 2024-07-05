import { IconContext } from "react-icons";
import AllPeople from "../Pages/Person/AllPeople";
import {IoPeople } from "react-icons/io5";
import {IoPersonAddSharp } from "react-icons/io5";
import { useNavigate } from "react-router-dom";
import { IoCloseCircle } from "react-icons/io5";



export const People = () => {
  const navigate = useNavigate()

  const handleAddPersonClick = () => {
    navigate("Add")
  }
  const handleClose = () => {
    navigate("/");
  }

  return (
        <>
          <div  className=" flex flex-col items-center justify-center  w-[100%]">
            <IconContext.Provider  value={{className: "text-sky-700" , size: "120"}}>
                <IoPeople />
            </IconContext.Provider>
            <div className="flex  items-center justify-between  w-[90%]">
              <div className=" flex justify-center items-center  gap-2">
                <label  htmlFor="Filter" className="block w-fit  whitespace-nowrap  text-sm font-medium text-gray-900 ">Select  Filter</label>
                <select id="Filter" className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
                  <option defaultValue={"ID"}>ID</option>
                  <option defaultValue="Na">National No</option>
                  <option defaultValue="FN">First Name</option>
                </select>
              </div>
              <button onClick={handleAddPersonClick}className ="bg-gray-700 rounded-lg  transition-all duration-300 hover:bg-slate-50   p-1" type="button" title="Add Person">
              <IconContext.Provider value={{className: "text-slate-50 hover:text-sky-700 transition-all duration-300 ", size:"30",  }}>
                <IoPersonAddSharp />
              </IconContext.Provider>
              </button>
            </div>
        </div>
        <AllPeople />
        <div className="flex items-center  justify-between w-[90%] p-3 ">
            <p> Records : </p>
            <button  onClick= {handleClose} className= "flex justify-center text-slate-50 items-center bg-gray-700 rounded-lg  transition-all duration-300 hover:bg-slate-50 hover:text-sky-700  p-2 " type="button" title="close">
                  <IconContext.Provider  value={{className: "text-red-700" , size: "18"}}>
                      <IoCloseCircle />
                  </IconContext.Provider>
                    <p className=" text-lg">close</p>
            </button>
        </div>
        </>
  )
}
