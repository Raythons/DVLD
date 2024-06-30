import React, { ReactNode } from 'react'
import { Datepicker, Modal, ModalBody, ModalHeader } from "flowbite-react";
import { FileInput, Label } from "flowbite-react";
import { Avatar } from "flowbite-react";
import { SubmitHandler, useForm } from "react-hook-form";
import { zodResolver } from '@hookform/resolvers/zod';
import { useNavigate } from 'react-router-dom';
import { useCreatePersonMutation } from '../../redux/api/peopleApi';
import { AddPersonSchema } from '../../schema/AddPersonSchema';
import { CreatePersonFormFields } from '../../types/AddPersonType';
import { useHandleFileChange } from '../../hooks/useHandleFileChange';
import SuccessPopUp from '../../layout/SuccessPopUp';
import { Spinner } from "flowbite-react";


const AddPerson = () => {

  const [currentPersonImage, setCurrentPersonImage] = React.useState<string>(""); // Initially no image
  const navigate = useNavigate();

  const {handleFileChanges} = useHandleFileChange();

  const {
      register,
      handleSubmit,
      formState:{errors, isSubmitting}} = useForm<CreatePersonFormFields>
      (
        {
          resolver: zodResolver(AddPersonSchema),
          mode: "onBlur"
        },
      );

  const [createPerson, {isSuccess, isLoading, error}] = useCreatePersonMutation();
  const [createdPersonId , setCreatedPersonId] = React.useState<number | undefined>()

  const [showSuccessModal, setShowSuccessModal] = React.useState<boolean>(isSuccess);
  const [birthDate, setBirthDate] = React.useState<Date>(new Date(2003,3,3));
  const UserImageField = register("Image", { required: true });



  const onSubmit: SubmitHandler<CreatePersonFormFields>  = async (data) => {
      data.Image = data.Image[0]
      data.BirthDate =  birthDate.toISOString();
      try {
      const res = await createPerson(data).unwrap();
      setShowSuccessModal(!isSuccess)
      setCreatedPersonId(res);
    } catch (err) {
        console.log(err);
        console.log(error)
    }
  }


  const customTheme ={
    popup : {
      root: {
        inner: " absolute rounded-lg bg-white p-4 shadow-lg -top-[375px] "
      },
    }
  }
  
  return (
      <div className='flex flex-col justify-around  items-center w-[100%] h-full  '>
          <h1 className='text-sky-700 text-3xl'>Add New Person</h1>
        <form className=" w-[80%] mx-auto " onSubmit={handleSubmit(onSubmit)}>
        <div className=' flex  items-center gap-4 p-1 w-[100%]'>
          <p className=' font-medium'>Name:</p>
          <div className="grid md:grid-cols-4 md:gap-6 w-full">
              <div className="relative z-0 w-full mb-5 group">
                  <input {...register("FirstName")} type="text" id="FirstName" className="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none  dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer" placeholder=" "  />
                  <label htmlFor="FirstName" className="peer-focus:font-medium absolute text-sm text-gray-500 dark:text-gray-400 duration-300 transhtmlForm -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6">First name</label>
                  {errors.FirstName && <span className="text-red-700">{errors.FirstName.message}</span>}
              </div>
              <div className="relative z-0 w-full mb-5 group">
                  <input  {...register("SecondName")} type="text" name="SecondName" id="SecondName" className="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none  dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer" placeholder=" "  />
                  <label htmlFor="SecondName" className="peer-focus:font-medium absolute text-sm text-gray-500 dark:text-gray-400 duration-300   -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-500  peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6">Second name</label>
                  {errors.SecondName && <span className="text-red-700">{errors.SecondName.message}</span>}

              </div>
              <div className="relative z-0 w-full mb-5 group">
                  <input type="text"  {...register("ThirdName")} id="ThirdName" className="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none  dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer" placeholder=" "  />
                  <label htmlFor="ThirdName" className="peer-focus:font-medium absolute text-sm text-gray-500 dark:text-gray-400 duration-300 transhtmlForm -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6">Third name</label>
                  {errors.ThirdName && <span className="text-red-700">{errors.ThirdName.message}</span>}

              </div>
              <div className="relative z-0 w-full mb-5 group">
                  <input type="text"  {...register("LastName")} id="LastName" className="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none  dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer" placeholder=" "  />
                  <label htmlFor="LastName" className="peer-focus:font-medium absolute text-sm text-gray-500 dark:text-gray-400 duration-300 transhtmlForm -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6">Last name</label>
                  {errors.LastName && <span className="text-red-700">{errors.LastName.message}</span>}

              </div>
          </div>
        </div>
        <div className="grid md:grid-cols-2 md:gap-16 w-[100%]">
            <div className='flex justify-center items-center gap-4 p-1'>
              <p className='font-medium'>Email:</p>
                <div className="relative z-0 w-full mb-0 group">
                  <input type="text" {...register("Email")} id="Email" className="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none  dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer" placeholder=" "  />
                  <label htmlFor="Email" className="peer-focus:font-medium absolute text-sm text-gray-500 dark:text-gray-400 duration-300 transhtmlForm -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 rtl:peer-focus:left-auto peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6">Email address</label>
                  {errors.Email && <span className="text-red-700">{errors.Email.message}</span>}

                </div>
              </div>
              <div className='flex justify-center items-center gap-4 p-1'>
                  <p className='font-medium whitespace-nowrap'>National No:</p>
                  <div className="relative z-0 w-full mb-5 group">
                      <input type="text" {...register("NationalNo")} id="NationalNo" className="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none  dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer" placeholder=" "  />
                      <label htmlFor="NationalNo" className="peer-focus:font-medium absolute text-sm text-gray-500 dark:text-gray-400 duration-300 transhtmlForm -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6">National No</label>
                      {errors.NationalNo && <span className="text-red-700">{errors.NationalNo.message}</span>}
                  </div>
              </div>
        </div>
        <div className="grid md:grid-cols-3 md:gap-16">
              <div className='flex  items-center gap-4 p-1  grid-cols-2'>
                <p className='font-medium whitespace-nowrap'>BirthDate</p>
                <Datepicker 
                            maxDate={new Date(2004,1,1)}
                            theme= {customTheme} 
                            id='BirthDate'
                            onSelectedDateChanged={
                              (e) => setBirthDate(e)
                            }
                            
                            {...register("BirthDate")} />
                  {errors.BirthDate && <p>{errors.BirthDate.message} </p>}
              </div>
              <div className='flex justify-center items-center gap-4 p-1 relative'>
                    <label htmlFor="NationalityCountryId" className="">Country:</label>
                    <select {...register("NationalityCountryId", {valueAsNumber: true})} id='NationalityCountryId'   title= "countries"  className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
                      <option defaultValue={0}>Choose a country</option>
                      <option value={1} >{1}</option>
                      <option value={2}>Canada</option>
                      <option value={3}>France</option>
                      <option value={4}>Germany</option>
                    </select>
                    {errors.NationalityCountryId && <span className="text-red-700 absolute top-11 whitespace-nowrap">{errors.NationalityCountryId.message}</span>}
              </div>

              <div className="flex flex-wrap items-center">
                <p className='font-medium whitespace-nowrap' >Gender:</p>
                <div className=" ml-4 flex items-center me-4">
                    <input id="male-radio" type="radio" value="Male" {...register("Gender")} className="w-4 h-4 text-sky-600 bg-gray-100 border-gray-300  focus:ring-blue-500  dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
                    <label htmlFor="male-radio" className="ms-2 text-sm font-medium text-gray-900 dark:text-gray-300">Male</label>
                </div>
                <div className="flex items-center me-4">
                    <input id="female-radio" type="radio" value="Female" {...register("Gender")} className="w-4 h-4  text-rose-600 bg-gray-100 border-gray-300  focus:ring-red-500 dark:focus:ring-green-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
                    <label htmlFor="female-radio" className="ms-2 text-sm font-medium text-gray-900 dark:text-gray-300">Female</label>
                </div>
                {errors.Gender && <span className="text-red-700 whitespace-nowrap">{errors.Gender.message}</span>}

              </div>
        </div>
        <div className="grid md:grid-cols-2 md:gap-16 mt-1">
              <div className='flex justify-center items-center gap-4 p-1'>
                  <p className='font-medium whitespace-nowrap'>Phone: </p>
                  <div className="relative z-0 w-full mb-5 group">
                      <input type="text" {...register("Phone")} id="Phone" className="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none  dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer" placeholder=" "  />
                      <label htmlFor="Phone" className="peer-focus:font-medium absolute text-sm text-gray-500 dark:text-gray-400 duration-300 transhtmlForm -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6">Phone:</label>
                      {errors.Phone && <span className="text-red-700">{errors.Phone.message}</span>}

                  </div>
              </div>
              <div className='flex justify-center items-center gap-4 p-1'>
                  <p className='font-medium whitespace-nowrap'>Address: </p>
                  <div className="relative z-0 w-full mb-5 group">
                      <input type="text" {...register("Address")} id="Address" className="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none  dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer" placeholder=" "  />
                      <label htmlFor="Address" className="peer-focus:font-medium absolute text-sm text-gray-500 dark:text-gray-400 duration-300 transhtmlForm -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6">Address:</label>
                      {errors.Address && <span className="text-red-700">{errors.Address.message}</span>}
                  </div>
              </div>
        </div>
        <div className='w-[90%]  flex justify-between items-center'>
            <div>
              <div className='flex justify-start items-center gap-7'>
                  <Label htmlFor="file-upload-helper-text" value="Upload Picture" />
                    {errors.Image && <span className="text-red-700">Image Required</span>}
                </div>
                <FileInput  id="file-upload-helper-text" helperText="" {...UserImageField} onChange={(e) => {UserImageField.onChange(e); handleFileChanges(e, setCurrentPersonImage)}}  />
            </div>
                <Avatar img= {currentPersonImage || "../../../public/UnknownUser.jpg"}   size="lg"  rounded={true}  className='w-1/4 h-1/4  p-4 pb-0  self-end  place-self-end'/>
          </div>
          <div  className='flex items-center justify-between'>
            <button type="submit" disabled={isSubmitting ? true : false} className="text-white mt-3 bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">
              {isSubmitting ? "loading" : "Submit"}
            </button>
            <button type="button" onClick={() => {navigate("..")}}  className="text-white mt-3 bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">
              Go Back
            </button>
          </div>
        </form>
        <SuccessPopUp show={showSuccessModal} type="Person" creationId={createdPersonId} setShowPopUp={setShowSuccessModal} />
        {isSubmitting ? <Modal show={isLoading}>
                          <ModalHeader />
                            <ModalBody>
                              <Spinner className=''/>
                            </ModalBody>
                          </Modal> : 
        <></>}
      </div>
  )
}

export default AddPerson