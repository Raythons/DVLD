import React, { useState } from 'react'
import { IconContext } from 'react-icons'
import { TbDots } from 'react-icons/tb'
import LDLAppOperations from './LDLAppOperations'

type props = {
    LDLAppId: number,
    DrivingClass: string
    NationalNo:string
    FullName: string
    ApplicationDate: Date
    PassedTests:number
    Status: string
}

const SingleDLApplication = (
      {
          LDLAppId,
          DrivingClass,
          NationalNo,
          FullName,
          ApplicationDate,
          PassedTests,
          Status
        } : props
        ) => {

    const [showAppOperations, setShowAppOperations] = useState<boolean>(false)
    const CreatedAtDate = new Date(ApplicationDate)
    const statusColor = (Status: string) => {
        switch (Status) {
          case "Canceled":
              return "text-rose-500";
          case "Completed":
              return "text-green-500"
          default:
            return "text-cyan-500";
        }
    } 
    
  return (
    <div className='flex flex-col   max-h-full  w-full justify-between items-center p-2 
    rounded-md bg-gray-700  text-slate-50    transition-all duration-300 hover:p-3'>
      <div  className='flex w-full justify-between items-center '>
        <div className=' flex justify-center items-center '>
            <p className=' font-bold  mr-1'> 
              ID: 
            </p>
            <p className=''>
              {LDLAppId}
            </p>
        </div>
        <div className=' flex justify-center items-center '>
            <p className=' font-bold  mr-1'> 
              DrivingClass:  
            </p>
            <p className=''>
              {DrivingClass}
            </p>
        </div>
        <div className=' flex justify-center items-center '>
            <p className=' font-bold mr-1  '> 
              NationalNo: 
            </p>
            <p className=' '>
              {NationalNo}
            </p>
        </div>
        <div className=' flex justify-center items-center '>
          <p className=' font-bold  mr-1'> 
            PassedTets: 
          </p>
          <p className=' '>
            {PassedTests}
          </p>
        </div>
        <div className=' flex justify-center items-center '>
          <p className=' font-bold   mr-1'> 
            Status: 
          </p>
          <p className={` text-lg ${statusColor(Status)}`}>
            {Status}
          </p>
      </div>
        <div className='relative cursor-pointer' onClick={() => setShowAppOperations(!showAppOperations)} title='Person Config' >
          <IconContext.Provider value={{className: "hover:text-sky-700 transition-all duration-300", size: "40"}}>
            <TbDots />
          </IconContext.Provider>
          <LDLAppOperations show={showAppOperations} AppId={LDLAppId}/>
        </div>
      </div>
      <div  className='flex w-full justify-start gap-5 items-center '>
      <div className=' flex justify-center items-center '>
          <p className=' font-bold  mr-1'> 
            FullName: 
          </p>
          <p className=' '>
            {FullName}
          </p>
      </div>
      <div className=' flex justify-center items-center '>
          <p className=' font-bold  mr-1'> 
            AppDate: 
          </p>
          <p className='p-1 '>
            {`${CreatedAtDate.getFullYear()}/${CreatedAtDate.getMonth()}/${CreatedAtDate.getDay()}`}
          </p>
      </div>
      
      </div>
     
     
     
  </div>
  )
}

export default SingleDLApplication