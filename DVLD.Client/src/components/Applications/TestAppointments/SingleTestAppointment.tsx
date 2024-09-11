import React from 'react'
import { IconContext } from 'react-icons';
import { FaLock } from "react-icons/fa";
import { FaUnlock } from "react-icons/fa";



type props =  {
    AppointmentId: number
    AppointmentDate: string
    PaidFees: number
    IsLocked: boolean
}
const SingleTestAppointment = ({AppointmentId ,AppointmentDate , PaidFees, IsLocked}: props) => {
  return (
    <div className='flex   max-h-full  w-full justify-between items-center p-2 
      rounded-md bg-gray-700  text-slate-50    transition-all duration-300 hover:p-3'>
        <div className=' flex justify-center items-center p-1'>
            <p className=' font-bold  mr-1'> 
              ID: 
            </p>
            <p className='p-1'>
              {AppointmentId}
            </p>
        </div>
        <div className=' flex justify-center items-center p-1'>
            <p className=' font-bold  mr-1'> 
                AppointmentDate:  
            </p>
            <p className='p-1'>
              {AppointmentDate}
            </p>
        </div>
        <div className=' flex justify-center items-center p-1'>
            <p className=' font-bold mr-1  '> 
            PaidFees: 
            </p>
            <p className='p-1 '>
              {PaidFees}
            </p>
        </div>
        <div className=' flex justify-center items-center p-1'>
            <p className=' font-bold  mr-1'> 
            IsLocked: 
            </p>
            <p className='p-1    '>
              { 
                IsLocked 
                ?
                <IconContext.Provider  value={{className: "text-red-600"  , size: ""}}>
                  <FaLock />              
                </IconContext.Provider>
                : 
                <IconContext.Provider  value={{className: "text-green-600"  , size: ""}}>
                  <FaUnlock />              
                </IconContext.Provider>
              }
            </p>
        </div>
      </div>
  )
}

export default SingleTestAppointment