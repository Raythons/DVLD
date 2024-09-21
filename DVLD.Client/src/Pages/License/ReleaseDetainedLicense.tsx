import React, { useEffect, useState } from 'react'
import SearchLicenseComponent from '../../components/Liccense/SearchLicenseComponent'
import GetLicenseInfo from '../../components/Liccense/GetLicenseInfo'
import { Button } from 'flowbite-react'
import { useGetAllApplicationsTypeQuery } from '../../redux/api/Applications/ApplicationsTypeApi'
import { EnApplicationTypes } from '../../enums/applicationTypes'
import {ReleaseLicenseRequest, useLazyGetDetainedLicenseInfoQuery, useReleaseLicenseMutation } from '../../redux/api/LicenseApi'
import SuccessPopUp from '../../components/common/SuccessPopUp'
import CustomError from '../../components/common/CustomError'
import { ApiError } from '../../redux/api/peopleApi'
import ReleaseLicenseInfo from '../../components/Applications/ReleaseLicenseInfo'

const ReleaseDetainedLicense = () => {
    const [LicenseID, setLicenseID] = useState<number>(0);

    const {data : ApplicationsTypes, isSuccess: applicationsTypesSuccess} =  useGetAllApplicationsTypeQuery({});
    
    const [releaseLicenseInfoRequest, setReleaseLicenseInfoRequest] = useState({} as ReleaseLicenseRequest)

    const [releaseLicense, {isError, isSuccess, error}] = useReleaseLicenseMutation();
    // const {data: DetainedLicenseInfo, {isSuccess: isDetainedLicenseInfoSuccess}} 
    const [getDetainedLicenseInfo] =  useLazyGetDetainedLicenseInfoQuery({});

    useEffect(()=>{
        if(applicationsTypesSuccess ) {
            setReleaseLicenseInfoRequest(
                {
                    ...releaseLicenseInfoRequest,
                    ApplicationTypeId: EnApplicationTypes.ReleaseDetainedDrivingLicense,
                    ApplicationFees: ApplicationsTypes.find(type => type.ApplicationTypeId === Number(EnApplicationTypes.ReleaseDetainedDrivingLicense))!.ApplicationTypeFees,
                }
            )
        }
        const handleFetch =  async () => {
            if(LicenseID != 0){
                try {
                    const response = await getDetainedLicenseInfo(LicenseID).unwrap();
                    setReleaseLicenseInfoRequest({
                        ...releaseLicenseInfoRequest,
                        CreatedBy: response.CreatedBy,
                        DetainDate : response.DetainDate,
                        FineFees: response.FineFees,
                        LicenseId: LicenseID
                    })
                } catch (error) {
                    console.log(error);
                }
            }
        }
        handleFetch();
    },[LicenseID, releaseLicenseInfoRequest.ApplicationFees, applicationsTypesSuccess])

    const [showSuccessModal, setShowSuccessModal] = useState(false);
    

    const handleReleaseLicense = async () =>{
        try {
            const response =  await releaseLicense(releaseLicenseInfoRequest).unwrap()
            setReleaseLicenseInfoRequest(
                {
                    ...releaseLicenseInfoRequest,
                    ReleaseId: Number(response.ReleaseId)
                }
            )
            setShowSuccessModal(!showSuccessModal)
        } catch (error) {
            console.log(error);
        }
    }
    console.log(releaseLicenseInfoRequest);
    
    return (
    <div  className=" flex flex-col items-center gap-1 justify-center  w-[90%]">
        <SearchLicenseComponent setLicenseId={setLicenseID} setReleaseLicenseId = {setReleaseLicenseInfoRequest} />
        
        <GetLicenseInfo LicenseId={LicenseID} />
        
        <ReleaseLicenseInfo releaseLicenseLicenseInfo={releaseLicenseInfoRequest}   />
        <Button className='p-1 mt-2 ' color={"blue"} onClick={handleReleaseLicense} >
            Create
        </Button>
        { isSuccess && !isError && <SuccessPopUp show = {showSuccessModal}
                                                        setShowPopUp={setShowSuccessModal}
                                                        operation= 'Release'
                                                        creationId={releaseLicenseInfoRequest.ReleaseId} 
                                                        type='License'/>
        }
        {isError && <CustomError error={error ? error as ApiError : error} />}    
    </div>
  )
}

export default ReleaseDetainedLicense