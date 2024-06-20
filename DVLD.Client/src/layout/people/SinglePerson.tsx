import React from 'react'
import { GetPersonListData } from '../../redux/api/peopleApi'
import { TbDots } from "react-icons/tb";
import { IconContext } from 'react-icons';

type SinglePersonProps =   GetPersonListData
const SinglePerson = ({Id, FullName , Age, Gender}: SinglePersonProps) => {
  return (

    <div className='flex   max-h-full  w-full justify-between items-center p-2 
      rounded-md bg-gray-700  text-slate-50    transition-all duration-300 hover:p-3'>
        <div className=' flex justify-center items-center p-1'>
            <p className=' font-bold  mr-1'> 
              ID: 
            </p>
            <p className='p-1'>
              {Id}
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
              Age: 
            </p>
            <p className='p-1 '>
              {Age}
            </p>
        </div>
        <div className=' flex justify-center items-center p-1'>
            <p className=' font-bold  mr-1'> 
              Gender: 
            </p>
            <p className='p-1 '>
              {Gender}
            </p>
        </div>
        <button title='Person Config' type='button'>
          <IconContext.Provider value={{className: "hover:text-sky-700 transition-all duration-300", size: "40"}}>
            <TbDots />
          </IconContext.Provider>
        </button>
    </div>
  )
}

export default SinglePerson