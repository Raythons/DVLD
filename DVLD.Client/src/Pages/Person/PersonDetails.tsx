import React from 'react'
import {  useParams } from 'react-router-dom'
import { useGetPersonDetailsQuery } from '../../redux/api/peopleApi';
import { ApiError } from '../../redux/api/peopleApi';
import { Avatar } from 'flowbite-react';
import { Spinner } from 'flowbite-react';

import CustomError from '../../layout/CustomError';
import EditButton from '../../components/EditButton';
const PersonDetails = () => {

    const {personId} = useParams();

    const {data : PersonDetails ,isLoading: isLoadingPersonDetails, error,isError} = useGetPersonDetailsQuery(Number(personId));
    
  return (
  
    isLoadingPersonDetails 
    ?  
    <div className=' flex flex-col justify-center  items-center w-[100%]  h-[100%] gap-4'>
      <Spinner  aria-label='loading Person Data' size={"xl"}/>
    </div>
    :
      <div className=' flex flex-col justify-center  items-center w-[100%]  h-[100%] gap-4'>
        {
          isError &&  <CustomError error={error ? error as ApiError : error}    />
              
        }
          <h1 className='text-sky-700 text-3xl'>Person Details</h1>
        
          <div className="flex ml-4  justify-center items-center w-[90%]">
            <p className=' font-medium'>Id:</p>
            <div className="w-full group">
                <p  className=' whitespace-nowrap' > {PersonDetails?.Id}</p>
            </div>
          </div>

          <div className="flex   ml-4 justify-center items-center w-[90%]">
            <p className=' font-medium'>Name:</p>
            <div className="w-full  ">
                <p  className=' whitespace-nowrap' > {PersonDetails?.FullName}</p>
            </div>
          </div>



      <div className=' flex   items-start justify-between gap-4 p-1 w-[90%]'>
        
        <div className="flex   flex-col items-start justify-between gap-4 p-1 ">
            <div className='flex justify-center items-center  gap-4 p-1'>
                <p className='font-medium'>Country:</p>
                <p >{PersonDetails?.Country} </p>
              </div>

              <div className='flex justify-center items-center  gap-4 p-1'>
                <p className='font-medium'>Gender:</p>
                <p >{PersonDetails?.Gender}</p>
              </div>

              <div className='flex justify-center items-center  gap-4 p-1'>
                <p className='font-medium'>Phone :</p>
                <p >{PersonDetails?.Phone}</p>
              </div>
              
              
        </div>
          <div className="flex  flex-col items-start justify-between gap-4 p-1 ">
            <div className='flex justify-center items-center  gap-4 p-1'>
                <p className='font-medium'>Email:</p>
                <p >Email address</p>
            </div>

              <div className='flex justify-center items-center gap-4 p-1'>
                  <p className='font-medium whitespace-nowrap'>National No:</p>
                  <p >{PersonDetails?.NationalNo}</p>
              </div>
              <div className='flex justify-center items-center gap-4  p-1'>
                  <p className='font-medium whitespace-nowrap'>Age :</p>
                  <p className='font-medium whitespace-nowrap'>{PersonDetails?.Age}</p>
              </div>
              
           </div>

           
        <div className="flex flex-col  items-start justify-between gap-4 p-1 ">
            <div className='flex justify-center items-center  gap-4 p-1'>
                <p className='font-medium'>Phone:</p>
                <p >{PersonDetails?.Phone} </p>
              </div>

              <div className='flex justify-center items-center  gap-4 mr-4 p-1'>
                <p className='font-medium '>Address:</p>
                <p >{PersonDetails?.Address}</p>
              </div>

              <EditButton  goTo='People'  Id={PersonDetails?.Id ?? 0}/>
              
        </div>
       </div>

        <div className='w-[90%]  flex justify-between items-center'>
                <Avatar   img= {`../../../public/${PersonDetails?.Image}` || "../../../public/UnknownUser.jpg"}   size="lg"  rounded={true}  className='w-1/4 h-1/4  p-4 pb-0  self-end  place-self-end'/>
        </div>
        
      </div>
    
  )
}

export default PersonDetails