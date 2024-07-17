import React from 'react'
import { Outlet } from 'react-router-dom'


// type props =   {
//     children?: React.ReactNode
// } 
const WhiteContainer = ( ) => {

  return (
    <div className=" flex overflow-y-scroll justify-start  gap-4 items-center   flex-col  rounded-lg  h-[85vh]
    bg-slate-200  w-[80%] container mx-auto white xl:px-26 lg:px-26   md:px-26  sm:px-26 ">
            <Outlet />
    </div>
  )
}

export default WhiteContainer