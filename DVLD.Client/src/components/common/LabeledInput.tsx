import React from 'react'
import { UseFormRegister } from 'react-hook-form'
import { EditPersonFormFields } from '../../types/AddPersonType'


type props =  {
  type: string,
  id: keyof EditPersonFormFields,
  errorMessage: string | undefined,
  register: UseFormRegister<EditPersonFormFields>
}

const LabeledInput = ({type,id,errorMessage, register} : props) => {
  return (
    <>
        <input  {...register(id)} type={type} id={id} className="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none  dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer" placeholder=" "  />
        <label htmlFor={id } className="peer-focus:font-medium absolute text-sm text-gray-500 dark:text-gray-400 duration-300 transhtmlForm -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6">{id}</label>
        {errorMessage && <span className="text-red-700">{errorMessage}</span>}
    </>
  )
}

export default LabeledInput