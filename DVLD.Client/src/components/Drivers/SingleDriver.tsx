import React from 'react'


type props = {
    DriverId: number,
    PersonId: number,
    NumberOfActiveLicenses: number,
    CreatedAt: string,
    FullName: string,
}
const SingleDriver = ({DriverId,PersonId,NumberOfActiveLicenses,CreatedAt,FullName}: props) => {
    return (
        <div className='flex   max-h-full  w-full justify-between items-center p-2 
          rounded-md bg-gray-700  text-slate-50    transition-all duration-300 hover:p-3'>
            <div className=' flex justify-center items-center p-1'>
                <p className=' font-bold  mr-1'> 
                  ID: 
                </p>
                <p className='p-1'>
                  {DriverId}
                </p>
            </div>
            <div className=' flex justify-center items-center p-1'>
                <p className=' font-bold  mr-1'> 
                  FullName:  
                </p>
                <p className='p-1'>
                  {FullName}
                </p>
            </div>
            <div className=' flex justify-center items-center p-1'>
                <p className=' font-bold mr-1  '> 
                PersonId: 
                </p>
                <p className='p-1 '>
                  {PersonId}
                </p>
            </div>
            <div className=' flex justify-center items-center p-1'>
                <p className=' font-bold  mr-1'> 
                NumberOfActiveLicenses: 
                </p>
                <p className='p-1 '>
                    {NumberOfActiveLicenses}
                </p>
            </div>
            <div className=' flex justify-center items-center p-1'>
                <p className=' font-bold  mr-1'> 
                CreatedAt: 
                </p>
                <p className='p-1 '>
                    {CreatedAt}
                </p>
            </div>
        </div>
      )
    }

export default SingleDriver