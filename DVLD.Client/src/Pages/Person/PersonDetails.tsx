import React from 'react'
import {  useParams } from 'react-router-dom'

const PersonDetails = () => {
    const {personId} = useParams();

    
  return (
    <div   className=' flex flex-col justify-center  items-center w-[100%] '> {personId}    asddddddddddddddddddd</div>
  )
}

export default PersonDetails