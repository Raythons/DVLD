import React from 'react'
import {  useParams } from 'react-router-dom'
import { useGetPersonDetailsQuery } from '../../redux/api/peopleApi';
import { ApiError } from '../../redux/api/peopleApi';
import CustomError from '../../layout/CustomError';
const PersonDetails = () => {

    const {personId} = useParams();

    const {data : PersonDetails , isLoading: isLoadingPersonDetails , error, isError} = useGetPersonDetailsQuery(Number(personId));
    
  return (
    <div className=' flex flex-col justify-center  items-center w-[100%] '> {personId}
        {
          isError &&  <CustomError error={error ? error as ApiError : error}    />
              
        }
        
        {isLoadingPersonDetails}
        {PersonDetails?.FullName}
    </div>
  )
}

export default PersonDetails