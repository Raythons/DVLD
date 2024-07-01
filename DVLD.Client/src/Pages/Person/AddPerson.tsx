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
import LabeledInput from '../../layout/components/LabeledInput';
import CountriesInput from '../../layout/components/CountriesInput';


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
                  <LabeledInput  type='text' id='FirstName' errorMessage={errors.FirstName?.message} register={register}/>
              </div>
              <div className="relative z-0 w-full mb-5 group">
                  <LabeledInput  type='text' id='SecondName' errorMessage={errors.SecondName?.message} register={register}/>
              </div>
              <div className="relative z-0 w-full mb-5 group">
                  <LabeledInput  type='text' id='ThirdName' errorMessage={errors.ThirdName?.message} register={register}/>
              </div>
              <div className="relative z-0 w-full mb-5 group">
                  <LabeledInput  type='text' id='LastName' errorMessage={errors.LastName?.message} register={register}/>
              </div>
          </div>
        </div>
        <div className="grid md:grid-cols-2 md:gap-16 w-[100%]">
            <div className='flex justify-center items-center gap-4 p-1'>
              <p className='font-medium'>Email:</p>
                <div className="relative z-0 w-full mb-0 group">
                  <LabeledInput  type='text' id='Email' errorMessage={errors.Email?.message} register={register}/>
                </div>
              </div>
              <div className='flex justify-center items-center gap-4 p-1'>
                  <p className='font-medium whitespace-nowrap'>National No:</p>
                  <div className="relative z-0 w-full mb-5 group">
                      <LabeledInput  type='text' id='NationalNo' errorMessage={errors.NationalNo?.message} register={register}/>
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
                <CountriesInput  id='NationalityCountryId'  register={register}
                      errorMessage={errors.NationalityCountryId?.message} defaultCountryId={0} />
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
                      <LabeledInput  type='text' id='Phone' errorMessage={errors.Phone?.message} register={register}/>
                  </div>
              </div>
              <div className='flex justify-center items-center gap-4 p-1'>
                  <p className='font-medium whitespace-nowrap'>Address: </p>
                  <div className="relative z-0 w-full mb-5 group">
                      <LabeledInput  type='text' id='Address' errorMessage={errors.Address?.message} register={register}/>
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