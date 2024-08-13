import React from 'react'
import { IconContext } from 'react-icons';
import { BsCardChecklist } from 'react-icons/bs';
import { CiCreditCard1 } from "react-icons/ci";
import { BsCardText } from "react-icons/bs";
import { useGetLDLApplicationBriefInfoQuery } from '../../../redux/api/Applications/LDLApplicationsApi';
import { Spinner } from 'flowbite-react';
import CustomError from '../../common/CustomError';
import { ApiError } from '../../../redux/api/peopleApi';

type props = {
    LDLApplicationID: number
}
const DrivingLicenseApplicationInfo = ( {LDLApplicationID}: props) => {

    const {data: LDLApplicationData, isError, isLoading, isSuccess, error} = 
    useGetLDLApplicationBriefInfoQuery(LDLApplicationID);
    
  return ( 
    isLoading 
    ? 
    <Spinner />
    :
    <div className='flex relative justify-center items-center flex-col gap-3 border-solid border-gray-500 border-2 p-6 mt-4 rounded-md'>
        {
            isError &&  !isSuccess &&  <CustomError  error={error ? error as ApiError : undefined}    />
        }

        <div className = 'absolute -top-4 left-4  border-slate-200 bg-slate-200 border-solid  border-2 '>
            Driving License Application Info
        </div>
        
        <div className='flex justify-center  items-center  gap-4'>
            <div className='flex - justify-center items-center gap-1'>
                <div className='flex - justify-center items-center gap-1'>
                    <p className='font-bold'>L.DL.APP ID:</p>
                    <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                    < CiCreditCard1/>
                    </IconContext.Provider>
                </div>
                <span className=' text-lg'>{LDLApplicationData?.Id}</span>
            </div>

            <div className='flex - justify-center items-center gap-1'>
                <div className='flex - justify-center items-center gap-1'>
                    <p className='font-bold'>Applied License:</p>
                    <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                    < BsCardText/>
                    </IconContext.Provider>
                </div>
                <span className=' text-lg'>{LDLApplicationData?.LicenseClass}</span>
            </div>
        </div>
        <div className=' flex justify-center  items-center gap-3'>

            <div className='flex - justify-center items-center gap-1'>
                show license Info
            </div>

            <div className='flex - justify-center items-center gap-1'>
                <div className='flex - justify-center items-center gap-1'>
                    <p className='font-bold'>Passed Tests:</p>
                    <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                    <BsCardChecklist/>
                    </IconContext.Provider>
                </div>
                <span className=' text-lg'>{`${LDLApplicationData?.PassedTests}/${LDLApplicationData?.TestsCount}`}</span>
            </div>

        </div>
    </div>
  )
}

export default DrivingLicenseApplicationInfo