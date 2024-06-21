import React from 'react'


type props =   {
    children: React.ReactNode
} 
const WhiteContainer = ( {children} : props) => {

  return (
    <div className=" flex justify-start  gap-4 items-center   flex-col  rounded-lg  h-[85vh]
    bg-slate-200  w-[80%] container mx-auto white xl:px-26 lg:px-26   md:px-26  sm:px-26 ">
            {children}
    </div>
  )
}

export default WhiteContainer