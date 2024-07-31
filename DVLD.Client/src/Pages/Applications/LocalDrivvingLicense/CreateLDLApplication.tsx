import React, { useEffect, useState } from 'react'
import LicenseClassesInput from '../../../components/common/LicenseClassesInput';
import { useLazyGetAllApplicationsTypeQuery } from '../../../redux/api/Applications/ApplicationsTypeApi';
import { Button, Modal, ModalBody, ModalHeader, Spinner } from 'flowbite-react';
import { useCreateLDLApplicationMutation } from '../../../redux/api/Applications/LDLApplicationsApi';
import SuccessPopUp from '../../../components/common/SuccessPopUp';
import CustomError from '../../../components/common/CustomError';
import { ApiError } from '../../../redux/api/peopleApi';


type props = {
    personId: number | undefined,
}
export type CreateLdlBody ={
  PersonId?: number | undefined,
  ApplicationTypeId?: number,
  LicenseCLassId?: number,
  CreatedByUserId: number,
}
const CreateLDLApplication = ({personId} : props) => {

  const [licenseCLassId, setLicenseClassId] = useState(1);

  const [LdlToCreate,  setLDLToCreate] = useState<CreateLdlBody>(
    { PersonId: personId as number,
      ApplicationTypeId: undefined,
      CreatedByUserId: 1,
      LicenseCLassId:  licenseCLassId
    }
  );

  
  const [getAllApplicationsType, {data}] = useLazyGetAllApplicationsTypeQuery();
  const [CreateLDLApplication, {isSuccess, isLoading, error} ] = useCreateLDLApplicationMutation();

  const [showSuccessModal, setShowSuccessModal] = React.useState<boolean>(isSuccess);

  useEffect(() => {
      getAllApplicationsType({});
      setLDLToCreate(
          {...LdlToCreate,PersonId: personId,
            ApplicationTypeId: data?.find((app) => app.ApplicationTypeId === 1)?.ApplicationTypeId,
            LicenseCLassId: licenseCLassId
          })
  }, [getAllApplicationsType, data, personId, licenseCLassId])

  // console.log(LdlToCreate);
  const handleCreateClick  = async () =>{
    try {
      const res = await CreateLDLApplication(LdlToCreate).unwrap();
      console.log(res);
      
      setShowSuccessModal(!showSuccessModal);
    } catch (error) {
        console.log(error);
        
    }

  }

  return (
      <form className='flex flex-col items-center justify-center  w-[30%] max-w-[30%]'>
        <div className="flex self-center  items-center  w-[100%]">
                <p className='font-medium whitespace-nowrap w-44'>LDL Application Id: </p>

              <div className='flex justify-center items-center w-[100%]'>
                  <p  className=' whitespace-nowrap' >   "???"</p>
              </div>
        </div>

        <div className="flex  self-center  items-center w-[100%]">
            <p className='font-medium whitespace-nowrap self-start  '>Application Date:</p>
            <div className='flex justify-center items-center w-[100%]'>
                  <p  className=' whitespace-nowrap ' > {`${new Date().getFullYear()}/${new Date().getMonth()}/${new Date().getDay()}`}</p>
            </div>
        </div>

        <div className="flex  items-center w-[100%]">
          <LicenseClassesInput setLicenseClassId={setLicenseClassId}  />
        </div>
        
        <div className="flex  self-center  items-center w-[100%]">
            <p className='font-medium whitespace-nowrap self-start  '>Application Fees:</p>
            <div className='flex justify-center items-center w-[100%]'>
                  <p  className=' whitespace-nowrap ' >15</p>
            </div>
        </div>
        <div className="flex  self-center  items-center w-[100%]">
            <p className='font-medium whitespace-nowrap self-start '>Created By User:</p>
            <div className='flex justify-center items-center w-[100%]'>
                  <p  className=' whitespace-nowrap ' >Allah</p>
            </div>
        </div>
        <Button type="button" color={`blue`} onClick={handleCreateClick} className='mt-4' >Create</Button>
        
        <SuccessPopUp operation='Created' show={showSuccessModal} type="Local Driving License Application" creationId={LdlToCreate.PersonId} setShowPopUp={setShowSuccessModal} />
        {isLoading ? <Modal show={isLoading}>
                          <ModalHeader />
                            <ModalBody>
                              <Spinner className='' size={"xl"}/>
                            </ModalBody>
                          </Modal> : 
        <></>}
        {error  &&  <CustomError   error={error ? error as ApiError : undefined}/>}
    </form>
  
  )
}

export default CreateLDLApplication