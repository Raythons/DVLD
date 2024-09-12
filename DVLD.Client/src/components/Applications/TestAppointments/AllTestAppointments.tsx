import React, { ReactNode } from 'react'
import { useGetLDLApplicationTestAppointmentsListQuery } from '../../../redux/api/TestAppointmentsApi'
import SingleTestAppointment from './SingleTestAppointment';
import { Spinner } from 'flowbite-react';




type props  = {
  LDLApplicationID: number,
  testTypeId: number;
  TestTypeIcon: ReactNode,
  TestTypeTitle: string
}

const AllTestAppointments = ({LDLApplicationID , testTypeId ,TestTypeIcon, TestTypeTitle} : props) => {

   const { data : TestAppointmentsList , isLoading } 
   = useGetLDLApplicationTestAppointmentsListQuery({
                                                    localDrivingLicenseApplicationId: LDLApplicationID, 
                                                    testTypeId
                                                  });
    
  return (
    <div className='flex  flex-col  justify-start items-center gap-2 p-6 mt-5  overflow-y-scroll 
          bg-slate-100 rounded-md w-[90%] h-[90%]  relative overflow-hidden  '>
      {
        isLoading ? <Spinner size = "xl" className="" /> 
        :
        TestAppointmentsList?.map((appointment) => (
          <SingleTestAppointment 
            key={appointment.AppointmentId}
            LDLApplicationID = {LDLApplicationID}
            AppointmentId ={appointment.AppointmentId}
            AppointmentDate = {appointment.AppointmentDate}
            PaidFees = {appointment.PaidFees}
            IsLocked = {appointment.IsLocked}
            TestTypeIcon = {TestTypeIcon}
            TestTypeTitle = {TestTypeTitle}
          />
        ))
      }
    </div>
  )
}

export default AllTestAppointments