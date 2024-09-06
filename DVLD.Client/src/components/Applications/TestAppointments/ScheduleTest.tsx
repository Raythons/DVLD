import React, { useEffect, useState } from 'react'
import { IconContext } from 'react-icons'
import { BiPaperclip, BiStreetView } from 'react-icons/bi'
import { FaEye } from 'react-icons/fa6'
import { useLocation, useParams } from 'react-router-dom'
import DrivingLicenseApplicationInfo from './DrivingLicenseApplicationInfo'
import ApplicationBasicInfo from './ApplicationBasicInfo'
import { useGetLDLApplicationIdQuery } from '../../../redux/api/Applications/LDLApplicationsApi'
import AllTestAppointments from './AllTestAppointments'
import { Button } from 'flowbite-react'
import { TbPlaylistAdd } from 'react-icons/tb'
import CreateTestAppointmentModal from './CreateTestAppointmentModal'

type TestTypeInfo = {
    Id: number,
    Type :  "Vision" | "Written" | "Street",
    Title: string,
    TestTypeIcon: React.ReactNode
}

type State =  {
  title : "Vision" | "Written" | "Street"
}

// type CreateTestAppointmentRequest = CreateTestAppointmentRequestParams


const ScheduleTest = () => {

  const [currentTestType, setCurrentTestType] = useState<TestTypeInfo>({Id: 1, Type :"Vision" ,Title: "Vision Test TestAppointment" , TestTypeIcon : <FaEye /> })
  const TestTypesData  : TestTypeInfo[]=  
  [
    {
      Id: 1,
      Type : "Vision",
      Title: "Vision Test TestAppointment",
      TestTypeIcon : <FaEye />
    } ,
    {
      Id: 2,
      Type : "Written",
      Title: "Written Test TestAppointment",
      TestTypeIcon : <BiPaperclip />
    } ,
    {
      Id: 3,
      Type : "Street",
      Title: "Street Test TestAppointment",
      TestTypeIcon : < BiStreetView />
    } ,
  ]

  const {LDLApplicationID} = useParams();
  const Location = useLocation()
  const state = Location.state as State ?? "Vision"
  
  const {data : ApplicationID, isSuccess} = useGetLDLApplicationIdQuery(Number(LDLApplicationID));
  
  useEffect (() => {
      TestTypesData.map((TestType) => {
          if (TestType.Type ===  state.title)
            setCurrentTestType(TestType);
      })
  }, [state]) 

  const [showCreateTestAppointmentModal,setShowCreateTestAppointmentModal ] = useState(false);
  const handleAddTestAppointmentClick = () => {
    setShowCreateTestAppointmentModal(!showCreateTestAppointmentModal);
  } 

  
  return (
    <div  className=" flex flex-col items-center justify-center  w-[100%]">
        <IconContext.Provider  value={{className: "text-sky-700" , size: "120"}}>
                {currentTestType.TestTypeIcon}
        </IconContext.Provider>
        <h2 className=' text-rose-600 text-2xl font-medium'>{currentTestType.Title}</h2>

        <DrivingLicenseApplicationInfo  LDLApplicationID = { Number(LDLApplicationID) } />
        <ApplicationBasicInfo  ApplicationID = { isSuccess? ApplicationID : 0 }  />

        <div className='flex justify-between items-center  w-[90%]'>
            <p>Appointments:</p>
            <button onClick={handleAddTestAppointmentClick}className ="bg-gray-700 rounded-lg  transition-all duration-300 hover:bg-slate-50   p-1" type="button" title="Add Person">
              <IconContext.Provider value={{className: "text-slate-50 hover:text-sky-700 transition-all duration-300 ", size:"26",  }}>
                <TbPlaylistAdd />
              </IconContext.Provider>
            </button>
            <CreateTestAppointmentModal 
                      showModal={showCreateTestAppointmentModal}
                      setShowModal = {setShowCreateTestAppointmentModal}
                      LDLApplicationID = {Number(LDLApplicationID)}
                      ApplicationId={ isSuccess? ApplicationID : 0}
                      TestAppointmentIcon = {currentTestType.TestTypeIcon}
                      TestTypeId={currentTestType.Id}
                      TestTypeTitle = {currentTestType.Type}
                      /> 
        </div>

        < AllTestAppointments testTypeId={currentTestType.Id} LDLApplicationID={Number(LDLApplicationID)}  />

        <div className='flex justify-between items-center  w-[90%] p-4'>
          <span>Records:##</span>
          <Button color='failure'>
            Close
          </Button>
        </div>
    </div>
  )
}

export default ScheduleTest