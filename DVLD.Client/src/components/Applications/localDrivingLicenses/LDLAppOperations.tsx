import React, { MouseEventHandler, useState } from 'react'
import { IconContext } from 'react-icons'
import { FaUserEdit } from 'react-icons/fa'
import { TiUserDelete } from 'react-icons/ti'
import { useNavigate } from 'react-router-dom'
// import DeletePopUp from '../../common/DeletePopUp'
import { LuClipboardList } from 'react-icons/lu'
import { RiCalendarScheduleFill } from "react-icons/ri";
import { GoIssueClosed } from "react-icons/go";
import { MdOutlineManageHistory } from "react-icons/md";
import { TbLicense } from "react-icons/tb";
import { FcCancel } from "react-icons/fc";



type props = {
    show: boolean,
    AppId: number
}

type  AppOperations = {
    OperationName: string,
    OperationIcon: React.ReactNode
    clickHandler?: MouseEventHandler<HTMLButtonElement>,
    clickable?: boolean 
}

const LDLAppOperations = ({show, AppId} : props) => {
    
    const navigate = useNavigate();
    const [showDeletePopUp, setShowDeletePopUp] = useState<boolean>(false)

    const LDLApplicationOperations: AppOperations[] = [
        {
            OperationName: "Show Details",
            OperationIcon:  <LuClipboardList /> ,
            clickHandler: () => {navigate(`Details/${AppId}`)}
        },
        {
            OperationName: "Edit",
            OperationIcon:  <FaUserEdit />, 
            clickHandler: () => {navigate(`Edit/${AppId}` , {state: AppId})}
        },
        {
            OperationName: "Delete",
            OperationIcon:  
                    <IconContext.Provider value={{className: "hover: text-red-600"}}> 
                        <TiUserDelete />
                    </IconContext.Provider>,
            clickHandler: () => {setShowDeletePopUp(!showDeletePopUp)}
        },
        {
            OperationName: "Cancel ",
            OperationIcon:  <FcCancel />, 
            clickHandler: () => {console.log("Email Clicked")}
        },
        {
            OperationName: "Schedule Test",
            OperationIcon:  <RiCalendarScheduleFill /> ,
            clickHandler: () => {console.log("Phone Clicked")}
        },
        {
            OperationName: "Issue License",
            OperationIcon:  <GoIssueClosed /> ,
            clickHandler: () => {console.log("Phone Clicked")}
        },
        {
            OperationName: "Show License",
            OperationIcon:  <TbLicense /> ,
            clickHandler: () => {console.log("Phone Clicked")}
        },
        {
            OperationName: "License History",
            OperationIcon:  <MdOutlineManageHistory /> ,
            clickHandler: () => {console.log("Phone Clicked")}
        },
    ]

    return (
        <ul className={`absolute  ${show ? "flex" : "hidden"} flex-col justify-center items-center
                absolute  transition  duration-500 right-10 top-[-11px]  rounded-md   bg-slate-50    border-solid border-2`}>
            {
                LDLApplicationOperations.map((operation) => (
                    <li  key={operation.OperationName} className={`
                        ${operation.OperationName == "Delete" ?  "text-red-600   " : "text-blue-600 hover:text-white"}
                        px-1 py-1  50 flex items-center transition duration-300 
                        gap-1  border-solid border-b  border-cyan-400 flex-nowrap hover:bg-blue-500 
                        min-w-full`}>
                        {operation.OperationIcon}
                        <button  onClick = {operation.clickHandler} type="button" className="text-lg  min-w-32  justify-self-start">
                            {operation.OperationName}
                        </button>
                    </li>
                ))
            }
            {/* <DeletePopUp   
                show ={showDeletePopUp} deletionId={AppId} 
                isLoading={isLoading}
                isError={isError}
                error={error as ApiError}
                setShowPopUp={setShowDeletePopUp} type='Person'
                mutation = {deletePerson}/> */}
        </ul>
    )
}

export default LDLAppOperations