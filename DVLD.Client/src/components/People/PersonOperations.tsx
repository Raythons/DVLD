import React, { MouseEventHandler, useState } from 'react'
import { IconContext } from 'react-icons';
import { FaClipboardUser } from "react-icons/fa6";
import { FaUserEdit } from "react-icons/fa";
import { TiUserDelete } from "react-icons/ti";
import { MdEmail } from "react-icons/md";
import { FaPhoneVolume } from "react-icons/fa6";
import { useNavigate } from 'react-router-dom';
import DeletePopUp from '../common/DeletePopUp';
import { ApiError, useDeletePersonMutation } from '../../redux/api/peopleApi';

type props = {
    show: boolean,
    PersonId: number
}

type  PersonOperation = {
    OperationName: string,
    OperationIcon: React.ReactNode
    clickHandler?: MouseEventHandler<HTMLButtonElement>
}

const PersonOperations = ({show, PersonId} : props) => {
    const navigate = useNavigate();
    const [showDeletePopUp, setShowDeletePopUp] = useState<boolean>(false)

    const [deletePerson, {isLoading, isError,  error}] = useDeletePersonMutation()
    const personOperations: PersonOperation[] = [
        {
            OperationName: "Show Details",
            OperationIcon:  <FaClipboardUser /> ,
            clickHandler: () => {navigate(`Details/${PersonId}`)}
        },
        {
            OperationName: "Edit",
            OperationIcon:  <FaUserEdit />, 
            clickHandler: () => {navigate(`Edit/${PersonId}` , {state: PersonId})}
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
            OperationName: "Send Email",
            OperationIcon:  <MdEmail />, 
            clickHandler: () => {console.log("Email Clicked")}
        },
        {
            OperationName: "Call Phone",
            OperationIcon:  <FaPhoneVolume /> ,
            clickHandler: () => {console.log("Phone Clicked")}
        },
    ]

    return (

        <ul className={`absolute  ${show ? "flex" : "hidden"} flex-col justify-center items-center
                absolute  transition  duration-500 right-10 top-[-11px]  rounded-md   bg-slate-50    border-solid border-2`}>
            {
                personOperations.map((operation) => (
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
            <DeletePopUp   
            show ={showDeletePopUp} deletionId={PersonId} 
            isLoading={isLoading}
            isError={isError}
            error={error as ApiError}
            setShowPopUp={setShowDeletePopUp} type='Person'
            mutation = {deletePerson}/>
        </ul>
    )
}

export default PersonOperations

