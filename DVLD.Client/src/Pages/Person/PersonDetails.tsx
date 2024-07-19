import {  useParams } from 'react-router-dom'
import { ApiError } from '../../redux/api/peopleApi';
import { Avatar } from 'flowbite-react';
import { Spinner } from 'flowbite-react';
import CustomError from '../../components/common/CustomError';
import EditButton from '../../components/common/EditButton';
import { SearchBy, useGetPersonDetails } from '../../hooks/useGetPersonDetails';

type props = {
  personIdProp?: number ,
  SearchBy: SearchBy
}
const  PersonDetails = ({personIdProp, SearchBy = "Id" } : props) => {

    let {personId} = useParams();


    if(personId === undefined )
      personId = personIdProp?.toString();
    
    const {data: PersonDetails, isError, isLoading, isSuccess, error} = 
      useGetPersonDetails(personId, SearchBy);
    // console.log(PersonDetails, isError , isLoadingPersonDetails);
    
      
    // const {data : PersonDetails ,isLoading: isLoadingPersonDetails, error, isError} = useGetPersonDetailsQuery(Number(personId));
    
  return (
  
    isLoading 
    ?  
    <div className=' flex flex-col justify-center  items-center w-[100%]  h-[100%] gap-4'>
      <Spinner  aria-label='loading Person Data' size={"xl"}/>
    </div>
    :
      <div className=' flex flex-col justify-center  items-center w-[100%]  h-[100%] gap-4'>
        {
          isError &&  !isSuccess &&  <CustomError  error={error ? error as ApiError : undefined}    />
              
        }
          <h1 className='text-sky-700 text-3xl'>Person Details</h1>
        
          <div className="flex ml-4  justify-center items-center w-[90%]">
            <p className=' font-medium'>Id:</p>
            <div className="w-full group">
                <p  className=' whitespace-nowrap' > {!isError ?  PersonDetails?.Id  :  "???"}</p>
            </div>
          </div>

          <div className="flex   ml-4 justify-center items-center w-[90%]">
            <p className=' font-medium'>Name:</p>
            <div className="w-full  ">
                <p  className=' whitespace-nowrap' > { !isError ? PersonDetails?.FullName : "?????"}</p>
            </div>
          </div>



      <div className=' flex   items-start justify-between gap-4 p-1 w-[90%]'>
        
        <div className="flex   flex-col items-start justify-between gap-4 p-1 ">
            <div className='flex justify-center items-center  gap-4 p-1'>
                <p className='font-medium'>Country:</p>
                <p >{ !isError ? PersonDetails?.Country : "?????"} </p>
              </div>

              <div className='flex justify-center items-center  gap-4 p-1'>
                <p className='font-medium'>Gender:</p>
                <p >{ !isError ? PersonDetails?.Gender : "?????"}</p>
              </div>

              <div className='flex justify-center items-center  gap-4 p-1'>
                <p className='font-medium'>Phone :</p>
                <p >{ !isError ? PersonDetails?.Phone : "?????"}</p>
              </div>
              
              
        </div>
          <div className="flex  flex-col items-start justify-between gap-4 p-1 ">
            <div className='flex justify-center items-center  gap-4 p-1'>
                <p className='font-medium'>Email:</p>
                <p >{ !isError ? PersonDetails?.Email : "???????"}</p>
            </div>

              <div className='flex justify-center items-center gap-4 p-1'>
                  <p className='font-medium whitespace-nowrap'>National No:</p>
                  <p >{ !isError ? PersonDetails?.NationalNo : "?????"}</p>
              </div>
              <div className='flex justify-center items-center gap-4  p-1'>
                  <p className='font-medium whitespace-nowrap'>Age :</p>
                  <p className='font-medium whitespace-nowrap'>{ !isError ? PersonDetails?.Age : "?????"}</p>
              </div>
              
          </div>

        <div className="flex flex-col  items-start justify-between gap-4 p-1 ">
            <div className='flex justify-center items-center  gap-4 p-1'>
                <p className='font-medium'>Phone:</p>
                <p >{ !isError ? PersonDetails?.Phone : "?????"} </p>
              </div>

              <div className='flex justify-center items-center  gap-4 mr-4 p-1'>
                <p className='font-medium '>Address:</p>
                <p >{ !isError ? PersonDetails?.Address : "?????"}</p>
              </div>

              <EditButton    goTo='People'  Id={!isError ? PersonDetails?.Id as number: 0}/>
        </div>
      </div>
        <div className='w-[90%]  flex justify-between items-center'>
                <Avatar img = {`/${!isError ?PersonDetails?.Image : "UnknownUser.jpg "}`}     size="lg"  rounded={true}  className='w-1/4 h-1/4  p-4 pb-0  self-end  place-self-end'/>
        </div>
      </div>
  )
}

export default PersonDetails