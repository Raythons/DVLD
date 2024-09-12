import React, { MouseEventHandler, MouseEvent, useState, ReactNode } from 'react'
import { useNavigate } from 'react-router-dom'
// import SubOperations from './SubOperations'
import { ClassListBehavior } from '../../Header/MainMenu'
import { IoIosPaper } from 'react-icons/io'
import TakeTestModal from './TakeTestModal'



type props = {
    show: boolean,
    TestAppointmentId: number,
    LDLApplicationID: number,
    TestTypeIcon: ReactNode,
    TestTypeTitle: string,
}

export type  TestAppointmentOperations = {
    OperationName: string,
    OperationIcon: React.ReactNode
    clickHandler?: MouseEventHandler<HTMLElement>,
    clickable?: boolean,
 
}

const TestAppointmentOperations = ({show, TestAppointmentId, LDLApplicationID, TestTypeIcon, TestTypeTitle} : props) => {
    
    const navigate = useNavigate();
    const [showTakeTestModal, setShowTakeTestModal] = useState<boolean>(false)

    
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


    const TestAppointmentOperations: TestAppointmentOperations[] = [
        {
            OperationName: "TakeTest",
            OperationIcon:  <IoIosPaper />,
            clickHandler: () => setShowTakeTestModal(!showTakeTestModal)
        },
        {
            OperationName: "Edit",
            OperationIcon:  <IoIosPaper />, 
            clickHandler: () => {navigate(`Edit/${TestAppointmentId}` , {state: TestAppointmentId})}
        },
    ]


    
    return (
        <ul className={`absolute  ${show ? "flex" : "hidden"} flex-col justify-center items-center
                absolute  transition  duration-500 right-10 top-[-11px]  rounded-md   bg-slate-50    border-solid border-2`}>
            {
                TestAppointmentOperations.map((operation) => (
                    <li  key={operation.OperationName} 
                        onMouseEnter={handleMouseEnter}
                        onMouseLeave={handleMouseLeave}
                        className={`
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
            <TakeTestModal TestTypeIcon = {TestTypeIcon} TestTypeTitle = {TestTypeTitle} LDLApplicationID={LDLApplicationID} showModal = {showTakeTestModal}  setShowModal={setShowTakeTestModal}/> 
        </ul>
    )
}

export default TestAppointmentOperations