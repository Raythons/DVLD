import React from 'react'
import { IconContext } from 'react-icons';
import { FaClipboardUser } from "react-icons/fa6";
import { FaUserEdit } from "react-icons/fa";
import { TiUserDelete } from "react-icons/ti";
import { MdEmail } from "react-icons/md";
import { FaPhoneVolume } from "react-icons/fa6";

type props = {
    show: boolean,
    PersonId: number
}

type  PersonOperation = {
    OperationName: string,
    OperationIcon: React.ReactNode
}
const PersonOperations = ({show, PersonId} : props) => {
    console.log(PersonId)
    const personOperations: PersonOperation[] = [
        {
            OperationName: "Show Details",
            OperationIcon:  <FaClipboardUser /> 
        },
        {
            OperationName: "Edit",
            OperationIcon:  <FaUserEdit /> 
        },
        {
            OperationName: "Delete",
            OperationIcon:  
                    <IconContext.Provider value={{className: "hover: text-red-600"}}> 
                        <TiUserDelete />
                    </IconContext.Provider>
        },
        {
            OperationName: "Send Email",
            OperationIcon:  <MdEmail /> 
        },
        {
            OperationName: "Call Phone",
            OperationIcon:  <FaPhoneVolume /> 
        },
    ]

    return (

        <ul className={`absolute  ${show ? "flex" : "hidden"} flex-col justify-center items-center
                absolute  transition  duration-500 right-10 top-[-11px]  rounded-md   bg-slate-50    border-solid border-2`}>
            {
                personOperations.map((operation) => (
                    <li  className={`
                        ${operation.OperationName == "Delete" ?  "text-red-600   " : "text-blue-600 hover:text-white"}
                        px-1 py-1  50 flex items-center transition duration-300 
                        gap-1  border-solid border-b  border-cyan-400 flex-nowrap hover:bg-blue-500 
                        min-w-full`}>
                        {operation.OperationIcon}
                        <button type="button" className="text-lg  min-w-32  justify-self-start">
                            {operation.OperationName}
                        </button>
                    </li>
                ))
            }
        </ul>
    )
}

export default PersonOperations

