import React from 'react'
import { IconContext } from 'react-icons'
import { BsCardText } from 'react-icons/bs'
import { BsFillDatabaseFill } from "react-icons/bs";
import { FaClipboardQuestion } from "react-icons/fa6";
import { FaRegUser } from "react-icons/fa";
import { RxIdCard } from "react-icons/rx";
import { MdOutlineDateRange } from "react-icons/md";
import { RiAdminFill } from "react-icons/ri";



const ApplicationBasicInfo = () => {
  return (
    <div className='flex relative justify-center items-between flex-col gap-3 border-solid border-gray-500 border-2 w-[55%]   p-6  mt-6 rounded-md '>
        <div className = 'absolute -top-4 left-4  border-slate-200 bg-slate-200 border-solid  border-2 '>
                Basic Application Info
        </div>

        <div className='flex  justify-between  items-start  '>
            <div className='flex flex-col justify-center items-center ' >

                <div className='flex  items-center gap-1 p-1 w-full'>
                    <div className='flex  justify-center items-center gap-1    pt-1'>
                        <p className='font-bold'>ID:</p>
                        <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                        < RxIdCard />
                        </IconContext.Provider>
                    </div>
                    <span className=' text-lg'> 41</span>
                </div>

                <div className='flex  items-center gap-1 p-1 w-full'>
                    <div className='flex  justify-center items-center gap-1    pt-1'>
                        <p className='font-bold'>Status:</p>
                        <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                        < BsCardText />
                        </IconContext.Provider>
                    </div>
                    <span className=' text-lg'> 41</span>
                </div>


                <div className='flex  items-center gap-1 p-1 w-full'>
                    <div className='flex  justify-center items-center gap-1    pt-1'>
                        <p className='font-bold'>Fees:</p>
                        <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                        < BsFillDatabaseFill />
                        </IconContext.Provider>
                    </div>
                    <span className=' text-lg'> 41</span>
                </div>

                <div className='flex  items-center gap-1 p-1 w-full'>
                    <div className='flex  justify-center items-center gap-1    pt-1'>
                        <p className='font-bold'>Type:</p>
                        <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                        < FaClipboardQuestion />
                        </IconContext.Provider>
                    </div>
                    <span className=' text-lg'> 41</span>
                </div>

                <div className='flex  items-center gap-1 p-1 w-full'>
                    <div className='flex  justify-center items-center gap-1    pt-1'>
                        <p className='font-bold'>Applicant:</p>
                        <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                        < FaRegUser />
                        </IconContext.Provider>
                    </div>
                    <span className=' text-lg'> 41</span>
                </div>

            </div>

            <div className='flex flex-col justify-center items-center' >
                <div className='flex - justify-center items-center gap-1 p-1'>
                    <div className='flex - justify-center items-center gap-1  pt-1'>
                        <p className='font-bold'>Date</p>
                        <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                        < MdOutlineDateRange/>
                        </IconContext.Provider>
                    </div>
                    <span className=' text-lg'> 41</span>
                </div>
                <div className='flex - justify-center items-center gap-1 p-1'>
                    <div className='flex - justify-center items-center gap-1  pt-1'>
                        <p className='font-bold'>Status Date</p>
                        <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                        < MdOutlineDateRange/>
                        </IconContext.Provider>
                    </div>
                    <span className=' text-lg'> 41</span>
                </div>
                <div className='flex - justify-center items-center gap-1 p-1'>
                    <div className='flex - justify-center items-center gap-1  pt-1'>
                        <p className='font-bold'>Created By</p>
                        <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
                        < RiAdminFill/>
                        </IconContext.Provider>
                    </div>
                    <span className=' text-lg'> 41</span>
                </div>
            </div>
        </div>
    </div>
)}

export default ApplicationBasicInfo