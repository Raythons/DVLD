import React from 'react'

const AllTestAppointments = () => {
    
  return (
    <div className='flex  flex-col  justify-start items-center gap-2 p-4  overflow-y-scroll 
          bg-slate-100 rounded-md w-[90%]  relative overflow-hidden '>
             <div className='flex   max-h-full  w-full justify-between items-center p-2 
      rounded-md bg-gray-700  text-slate-50    transition-all duration-300 hover:p-3'>
        <div className=' flex justify-center items-center p-1'>
            <p className=' font-bold  mr-1'> 
              ID: 
            </p>
            <p className='p-1'>
              {2}
            </p>
        </div>
        <div className=' flex justify-center items-center p-1'>
            <p className=' font-bold  mr-1'> 
              FullName:  
            </p>
            <p className='p-1'>
              {3}
            </p>
        </div>
        <div className=' flex justify-center items-center p-1'>
            <p className=' font-bold mr-1  '> 
              Age: 
            </p>
            <p className='p-1 '>
              {22}
            </p>
        </div>
        <div className=' flex justify-center items-center p-1'>
            <p className=' font-bold  mr-1'> 
              Gender: 
            </p>
            <p className='p-1 '>
              {"f"}
            </p>
        </div>
      </div>
    </div>
  )
}

export default AllTestAppointments