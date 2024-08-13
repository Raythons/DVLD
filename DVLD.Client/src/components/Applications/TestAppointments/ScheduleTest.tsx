import React, { useEffect, useState } from 'react'
import { IconContext } from 'react-icons'
import { BiPaperclip, BiStreetView } from 'react-icons/bi'
import { FaEye } from 'react-icons/fa6'
import { useLocation, useParams } from 'react-router-dom'
import DrivingLicenseApplicationInfo from './DrivingLicenseApplicationInfo'
import ApplicationBasicInfo from './ApplicationBasicInfo'

type TestTypeInfo = {
    Type :  "Vision" | "Written" | "Street",
    Title: string,
    TestTypeIcon: React.ReactNode
}

type State =  {
  title : "Vision" | "Written" | "Street"
}
const ScheduleTest = () => {

  const [currentTestType, setCurrentTestType] = useState<TestTypeInfo>({Type :"Vision" ,Title: "Vision Test TestAppointment" , TestTypeIcon : <FaEye /> })
  
  const TestTypesData  : TestTypeInfo[]=  
  [
    {
      Type : "Vision",
      Title: "Vision Test TestAppointment",
      TestTypeIcon : <FaEye />
    } ,
    {
      Type : "Written",
      Title: "Written Test TestAppointment",
      TestTypeIcon : <BiPaperclip />
    } ,
    {
      Type : "Street",
      Title: "Street Test TestAppointment",
      TestTypeIcon : < BiStreetView />
    } ,
  ]

  const {LDLApplicationID} = useParams();
  const Location = useLocation()
  const state = Location.state as State ?? "Vision"
  console.log(state.title);
  
  useEffect (() => {
      TestTypesData.map((TestType) => {
          if (TestType.Type ===  state.title)
            setCurrentTestType(TestType);
      })
  }, [state]) 
  
  console.log(LDLApplicationID);
  
  return (

    <div  className=" flex flex-col items-center justify-center  w-[100%]">
        <IconContext.Provider  value={{className: "text-sky-700" , size: "120"}}>
                {currentTestType.TestTypeIcon}
        </IconContext.Provider>
        <h2 className=' text-rose-600 text-2xl font-medium'>{currentTestType.Title}</h2>
        <DrivingLicenseApplicationInfo  LDLApplicationID = { Number(LDLApplicationID) } />
        <ApplicationBasicInfo  LDLApplicationID = { Number(LDLApplicationID) }  />
        <div>

        </div>

        <div>

        </div>
    </div>
  )
}

export default ScheduleTest