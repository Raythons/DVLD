import React from 'react'
import { ApiError } from '../../redux/api/peopleApi'


type props = {
    error:  ApiError | undefined ,
    Icon? : React.ReactNode ,
}
const CustomError = ({error}: props) => {

    const GenerateErrorHeader = (status : number | undefined ): string => {
        if (status === 404)
            return "Not Found"
        else if (status === 400)
            return "Bad Request"
        return "Error"
    }


    return (
    <div  className=' flex flex-col justify-center items-center gap-2'>
        <h2 className='text-red-600  text-lg' >{GenerateErrorHeader(error?.status)}</h2>
        <div>
            <p className=' text-sm text-gray-700'>{error?.Message} error Code is : <span className=' text-rose-600'> {`${error?.Code || "NoCode"}`}</span></p>
            <p></p>
        </div>
    </div>
  )
}

export default CustomError