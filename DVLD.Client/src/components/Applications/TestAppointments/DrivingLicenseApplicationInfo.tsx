import React from 'react'
import { IconContext } from 'react-icons';
import { BsCardChecklist } from 'react-icons/bs';
import { CiCreditCard1 } from "react-icons/ci";
import { BsCardText } from "react-icons/bs";


const DrivingLicenseApplicationInfo = () => {
  return (
    <div className='flex relative justify-center items-center flex-col gap-3 border-solid border-gray-500 border-2 p-6 mt-4 rounded-md'>
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
                <span className=' text-lg'> 41</span>
            </div>

            <div className='flex - justify-center items-center gap-1'>
                <div className='flex - justify-center items-center gap-1'>
                    <p className='font-bold'>Applied License:</p>
                    <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                    < BsCardText/>
                    </IconContext.Provider>
                </div>
                <span className=' text-lg'> class 3 - Ordinary driving License</span>
            </div>
        </div>
        <div className=' flex justify-center  items-center gap-3'>

            <div className='flex - justify-center items-center gap-1'>
                show license Info
            </div>

            <div className='flex - justify-center items-center gap-1'>
                <div className='flex - justify-center items-center gap-1'>
                    <p className='font-bold'>L.DL.APP ID:</p>
                    <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                    <BsCardChecklist/>
                    </IconContext.Provider>
                </div>
                <span className=' text-lg'> 0/3</span>
            </div>

        </div>
    </div>
  )
}

export default DrivingLicenseApplicationInfo