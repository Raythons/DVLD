import React, { MouseEventHandler, useState, MouseEvent } from 'react'
import { IconContext } from 'react-icons'
import { FaUserEdit } from 'react-icons/fa'
import { TiUserDelete } from 'react-icons/ti'
import { useNavigate } from 'react-router-dom'
import { LuClipboardList } from 'react-icons/lu'
import { RiCalendarScheduleFill } from "react-icons/ri";
import { GoIssueClosed } from "react-icons/go";
import { MdOutlineManageHistory } from "react-icons/md";
import { TbLicense } from "react-icons/tb";
import { FcCancel } from "react-icons/fc";
import { useUpdateLDLApplicationsStatusMutation } from '../../../redux/api/Applications/LDLApplicationsApi'
import { ApiError } from '../../../redux/api/peopleApi'
import DeletePopUp from '../../common/DeletePopUp'
import { FaEye } from 'react-icons/fa6'
import { IoNewspaperOutline } from "react-icons/io5";
import SubOperations from './SubOperations'
import { ClassListBehavior } from '../../Header/MainMenu'
import { FaCarAlt } from "react-icons/fa";
import { Button } from 'flowbite-react'
import IssueLicenseModal from '../../Liccense/IssueLicenseModal'


type props = {
    show: boolean,
    AppId: number,
    passedTests: number
}

export type  AppOperations = {
    OperationName: string,
    OperationIcon: React.ReactNode
    clickHandler?: MouseEventHandler<HTMLElement>,
    clickable?: boolean ,
    subOperations?: AppOperations[]
}

const LDLAppOperations = ({show, AppId, passedTests} : props) => {
    
    const navigate = useNavigate();
    const [showDeletePopUp, setShowDeletePopUp] = useState<boolean>(false)

    const [updateLDLApplication, {isLoading, isError,  error}] = useUpdateLDLApplicationsStatusMutation();

    const handleClassBehavior = (behavior: ClassListBehavior ,element: HTMLElement) => {
        if(behavior == ClassListBehavior.AddFirst) {
        element.lastElementChild?.classList.add("flex")
        element.lastElementChild?.classList.remove("hidden")
        }
        else 
        {
            element.lastElementChild?.classList.remove("flex")
            element.lastElementChild?.classList.add("hidden")
        }
  }

  const isLastCHildMenu = (target: HTMLElement): boolean =>{
      return target.lastElementChild?.tagName.toLocaleLowerCase() === "menu"
  } 

  const handleMouseEnter = (e: MouseEvent<HTMLLIElement>) => {
    if(isLastCHildMenu(e.currentTarget))
        handleClassBehavior(ClassListBehavior.AddFirst , e.currentTarget)
  };

  const handleMouseLeave = (e: MouseEvent<HTMLLIElement>) => {
    if(isLastCHildMenu(e.currentTarget))
      handleClassBehavior(ClassListBehavior.RemoveFirst , e.currentTarget)
  };

//   const handleMenuMouseLeave = (e: MouseEvent) => {
//     e.currentTarget.classList.remove("flex")
//     e.currentTarget.classList.add("hidden")
//     // handleClassBehavior(ClassListBehavior.RemoveFirst,  e.currentTarget)
//   }

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
            clickHandler: () => {console.log("Phone Clicked")},
            subOperations: [
                {
                    OperationName: "Schedule Vision Test",
                    OperationIcon: <FaEye />,
                    clickHandler: () => {navigate(`Tests/Add/${AppId}` , {state: {title:"Vision"},  })},
                    clickable: true
                } ,
                {
                    OperationName: "Schedule Written Test",
                    OperationIcon: <IoNewspaperOutline />,
                    clickHandler: () => {navigate(`Tests/Add/${AppId}` , {state: {title:"Written"},  })},
                    clickable: true
                },
                {
                    OperationName: "Schedule Street Test",
                    OperationIcon: <FaCarAlt />,
                    clickHandler: () => {navigate(`Tests/Add/${AppId}` , {state: {title:"Street"},})},
                    clickable: true
                }
            ]
        },
        {
            OperationName: "Issue License",
            OperationIcon:  <GoIssueClosed /> ,
            clickHandler: () => {setIssueLicenseModal(!issueLicenseModal)},
            clickable: passedTests  === 4,
        },
        {
            OperationName: "Show License",
            OperationIcon:  <TbLicense /> ,
            clickHandler: () => {console.log("Phone Clicked")},
            clickable: true
        },
        {
            OperationName: "License History",
            OperationIcon:  <MdOutlineManageHistory /> ,
            clickHandler: () => {console.log("Phone Clicked")},
            clickable: true

        },
    ]
    const [issueLicenseModal, setIssueLicenseModal] = useState<boolean>(false)
    
    return (
        <ul className={`absolute  ${show ? "flex" : "hidden"} flex-col justify-center items-center
                absolute  transition  duration-500 right-10 top-[-11px]  rounded-md   bg-slate-50    border-solid border-2`}>
            {
                LDLApplicationOperations.map((operation) => (
                    
                    <li  key={operation.OperationName} 
                        onMouseEnter={handleMouseEnter}
                        onMouseLeave={handleMouseLeave}
                        className={`
                        ${operation.OperationName == "Delete" ?  "text-red-600   " : "text-blue-600 hover:text-white"}
                        px-1 py-1  50 flex items-center transition duration-300 
                        gap-1  border-solid border-b  border-cyan-400 flex-nowrap hover:bg-blue-500 
                        min-w-full`}>
                        {operation.OperationIcon}
                        <Button color={"blue"} disabled = {!operation.clickable && operation.OperationName.split(" ")[0].toLocaleLowerCase() === "issue"}  onClick = {operation.clickHandler} type="button" className="text-lg  min-w-32  justify-self-start">
                            {operation.OperationName}
                        </Button>
                        {
                            operation.subOperations ? 
                            <SubOperations operations = {operation.subOperations} passedTests = {passedTests} />
                            : <></>
                        }
                    </li>
                ))
            }
            <DeletePopUp   
                show ={showDeletePopUp} deletionId={AppId} 
                isLoading={isLoading}
                isError={isError}
                error={error as ApiError}
                setShowPopUp={setShowDeletePopUp} type='Person'
                mutation = {updateLDLApplication}/>
            <IssueLicenseModal 
                        showModal = {issueLicenseModal}
                        setShowModal={setIssueLicenseModal}
                        LDLApplicationID={AppId}
                    />
        </ul>
    )
}

export default LDLAppOperations