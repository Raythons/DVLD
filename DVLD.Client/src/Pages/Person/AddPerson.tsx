import React from 'react'
import { Datepicker } from "flowbite-react";
import { FileInput, Label } from "flowbite-react";
import { Avatar } from "flowbite-react";
import { SubmitHandler, useForm } from "react-hook-form";
import {z} from "zod"
import { zodResolver } from '@hookform/resolvers/zod';

const schema = z?.object({
  FirstName:  z?.string({required_error: "FirstName Is Required"})
                .min(2, {  message: "minLength is 2"})
                .max(14, {message : "Maximum Length is 26 char"}),
  SecondName: z?.string({required_error: "SecondName Is Required"})
                .min(2, {  message: "minLength is 2"})
                .max(14, {message : "Maximum Length is 26 char"}),
  ThirdName: z?.string({required_error: "ThirdName Is Required"})
                .min(2, {  message: "minLength is 2"})
                .max(14, {message : "Maximum Length is 26 char"}),
  LastName: z?.string({required_error: "LastName Is Required"})
                .min(2, {  message: "minLength is 2"})
                .max(14, {message : "Maximum Length is 26 char"}),
  Email:    z?.string({required_error: "Email Is Required"})
              .email({message: "Invalid Email"}),
  NationalNo: z?.string({required_error: "NationalNo Is Required"}),

  BirthDate:  z?.date().optional(),

  CountryId : z.number(),
  Gender : z.union([
    z.literal("Male"),
    z.literal("Female"),
  ], {message:"Gender Is Required"}),

  Phone: z.string({required_error: "Phone Is Required"}),

  Address: z.string({required_error: "Address Is Required"})
            .min(8 , {message: "Address Length Must be More Than 8"})
            .max(40, {message: "Address Length Must be Less Than 40"}),
  Image: z.any()
          .refine((files) => files.Length >= 1, {message: "Photo is Required"})
})


type FormFelids = z.infer< typeof schema>

const AddPerson = () => {

  const {register,
      handleSubmit,
      watch,
      formState:{errors, isSubmitting}} = useForm<FormFelids>({resolver: zodResolver(schema)});

  const [birthDate, setBirthDate] = React.useState<Date>(new Date(2003,3,3));
    console.log(birthDate)



  const onSubmit: SubmitHandler<FormFelids>  = async (data) => {
    await new Promise((reso) => setTimeout(reso, 1000))
    data.BirthDate =  birthDate;
    console.log(data);  
  }

  const customTheme ={
    popup : {
      root: {
        inner: " absolute rounded-lg bg-white p-4 shadow-lg -top-[406px]"
      },
    }
  }
  
  return (
      <div className='flex flex-col justify-around  items-center w-[100%] h-full  '>
        <h1 className='text-sky-700 text-3xl'>Add New Person</h1>
        <form className=" w-[80%] mx-auto " onSubmit={handleSubmit(onSubmit)}>
        {/* <Avatar img="../../../public/daddy-henry.png" size="l" rounded  className='w-1/4 h-1/4  p-4 pb-0'/> */}
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
                <Datepicker maxDate={new Date(2004,1,1)}
                            theme= {customTheme} 
                            id='BirthDate'
                            onSelectedDateChanged={
                              (e) => setBirthDate(e)
                            }
                            {...register("BirthDate")} />
                  {errors.BirthDate && <p>{errors.BirthDate.message}</p>}
              </div>
              <div className='flex justify-center items-center gap-4 p-1 relative'>
                    <label htmlFor="country" className="">Country:</label>
                    <select {...register("CountryId")} title= "countries"  id="countries" className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
                      <option defaultValue={""}>Choose a country</option>
                      <option value={1}>United States</option>
                      <option value="2">Canada</option>
                      <option value="3">France</option>
                      <option value="4">Germany</option>
                    </select>
                    {errors.CountryId && <span className="text-red-700 absolute top-11 whitespace-nowrap">{errors.CountryId.message}</span>}
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
        <div className='w-[70%]  flex justify-between items-center'>
            <div>
              <div className='flex justify-start items-center gap-7'>
                  <Label htmlFor="file-upload-helper-text" value="Upload Picture" />
                    {errors.Image && <span className="text-red-700">Image Required</span>}
                </div>
                <FileInput id="file-upload-helper-text" {...register("Image")} helperText="" />
            </div>
                <Avatar img="../../../public/daddy-henry.png" size="l" rounded  className='w-1/4 h-1/4  p-4 pb-0  self-end  place-self-end'/>
          </div>

          <button type="submit" disabled={isSubmitting ? true : false} className="text-white mt-3 bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">
            {isSubmitting ? "loading" : "Submit"}
            </button>
        </form>
      </div>
  )
}

export default AddPerson