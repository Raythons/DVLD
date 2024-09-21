import React, { useEffect, useState } from 'react'
import SearchLicenseComponent from '../../components/Liccense/SearchLicenseComponent'
import GetLicenseInfo from '../../components/Liccense/GetLicenseInfo'
import { Button } from 'flowbite-react'
import { useGetAllApplicationsTypeQuery } from '../../redux/api/Applications/ApplicationsTypeApi'
import { EnApplicationTypes } from '../../enums/applicationTypes'
import {ApplicationReplacementLicenseInfoRequest, useReplaceLicenseMutation } from '../../redux/api/LicenseApi'
import SuccessPopUp from '../../components/common/SuccessPopUp'
import CustomError from '../../components/common/CustomError'
import { ApiError } from '../../redux/api/peopleApi'
import { EnReplacementType } from '../../enums/ReplacmentType'
import ApplicationReplacementLicenseInfo from '../../components/Applications/ApplicationReplacementLicenseInfo'



const ReplaceLicense = () => {
    const [LicenseID, setLicenseID] = useState<number>(0);

    const {data : ApplicationsTypes, isSuccess: applicationsTypesSuccess} =  useGetAllApplicationsTypeQuery({});
    
    const [applicationReplacementInfoRequest, setApplicationReplacementLicenseInfoRequest] = useState({ReplacementType: EnReplacementType.Lost} as ApplicationReplacementLicenseInfoRequest)

    const [replaceLicense, {isError, isSuccess, error}] = useReplaceLicenseMutation();

    useEffect(()=>{
        if(applicationsTypesSuccess) {
            setApplicationReplacementLicenseInfoRequest(
                {
                    ...applicationReplacementInfoRequest,
                    ApplicationTypeId: EnApplicationTypes.ReplacementLostDrivingLicense,
                    ApplicationFees: ApplicationsTypes.find(type => type.ApplicationTypeId === Number(EnApplicationTypes.ReplacementLostDrivingLicense))!.ApplicationTypeFees,
                    PreviousLicenseId: LicenseID,
                }
            )
        }
    },[LicenseID, applicationReplacementInfoRequest.ApplicationFees])

    const [showSuccessModal, setShowSuccessModal] = useState(false);

    const handleRenewLicense = async () =>{
        try {
            const response =  await replaceLicense(applicationReplacementInfoRequest).unwrap()
            setApplicationReplacementLicenseInfoRequest(
                {...applicationReplacementInfoRequest
                ,RenewedLicenseId: Number(response.NewLicenseId),
                RenewApplicationId: Number(response.ApplicationId)
                }
            )
            setShowSuccessModal(!showSuccessModal)
        } catch (error) {
            console.log(error);
        }
    }

    const handleChangeReplacementType =  (e: React.ChangeEvent<HTMLInputElement>) => {
        const ReplacementType = Number(e.currentTarget.value) as EnReplacementType
        const ApplicationType = (Number(e.currentTarget.value) as EnReplacementType ) === EnReplacementType.Damaged ? EnApplicationTypes.ReplacementDamagedDrivingLicense : EnApplicationTypes.ReplacementLostDrivingLicense 
        
        setApplicationReplacementLicenseInfoRequest(
            {
                ...applicationReplacementInfoRequest,
                ApplicationTypeId: ApplicationType,
                ApplicationFees: ApplicationsTypes!.find(type => type.ApplicationTypeId === Number(ApplicationType))!.ApplicationTypeFees,
                ReplacementType: ReplacementType,
            }
        )
    }
    
    console.log(applicationReplacementInfoRequest);
    
    return (
    <div  className=" flex flex-col items-center gap-1 justify-center  w-[90%]">
        <div className=' flex justify-center items-center '>
            <SearchLicenseComponent setLicenseId={setLicenseID} />
            <p className='font-medium whitespace-nowrap mr-2' >Replace Type:</p>
            <div className="flex flex-col items-center justify-center">
                    <div className=" ml-4 flex items-center me-4 w-full">
                        <input onChange={handleChangeReplacementType} checked = {applicationReplacementInfoRequest.ReplacementType === EnReplacementType.Lost} name="replace-type" id="male-radio" type="radio" value={EnReplacementType.Lost} className="w-4 h-4  bg-gray-100 border-gray-300    dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
                        <label htmlFor="male-radio" className="ms-2 text-sm font-medium text-gray-900 dark:text-gray-300">Lost</label>
                    </div>
                    <div className="flex items-center justify-center me-4 w-full">
                        <input onChange={handleChangeReplacementType} checked = {applicationReplacementInfoRequest.ReplacementType === EnReplacementType.Damaged}   name="replace-type"  id="female-radio" type="radio" value={EnReplacementType.Damaged}  className="w-4 h-4  text-rose-600 bg-gray-100 border-gray-300  focus:ring-red-500 dark:focus:ring-green-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
                        <label htmlFor="female-radio" className="ms-2 text-sm font-medium text-gray-900 dark:text-gray-300">Damaged</label>
                    </div>
            </div>
        </div>
        {
            applicationReplacementInfoRequest.ApplicationFees &&
            <GetLicenseInfo LicenseId={LicenseID} />
        }
        
        <ApplicationReplacementLicenseInfo ApplicationReplacementLicenseInfo={applicationReplacementInfoRequest}  />
        <Button className='p-1 mt-2 ' color={"blue"} onClick={handleRenewLicense} >
            Create
        </Button>
        { isSuccess && !isError && <SuccessPopUp show = {showSuccessModal}
                                                        setShowPopUp={setShowSuccessModal}
                                                        operation= 'ReNew'
                                                        creationId={applicationReplacementInfoRequest.RenewedLicenseId} 
                                                        type='License'/>
        }
        {isError && <CustomError error={error ? error as ApiError : error} />}    
    </div>
  )
}

export default ReplaceLicense