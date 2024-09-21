import React, { useEffect, useState } from 'react'
import SearchLicenseComponent from '../../components/Liccense/SearchLicenseComponent'
import GetLicenseInfo from '../../components/Liccense/GetLicenseInfo'
import { Button, Label, Textarea } from 'flowbite-react'
import { useGetAllApplicationsTypeQuery } from '../../redux/api/Applications/ApplicationsTypeApi'
import { EnApplicationTypes } from '../../enums/applicationTypes'
import ApplicationNewLicenseInfo from '../../components/Applications/ApplicationNewLicenseInfo'
import { ApplicationNewLicenseInfoRequest, useRenewLicenseMutation } from '../../redux/api/LicenseApi'
import SuccessPopUp from '../../components/common/SuccessPopUp'
import CustomError from '../../components/common/CustomError'
import { ApiError } from '../../redux/api/peopleApi'


const RenewLicense = () => {
    const [LicenseID, setLicenseID] = useState<number>(0);
    const {data : ApplicationsTypes, isSuccess: applicationsTypesSuccess} =  useGetAllApplicationsTypeQuery({});
    const [applicationNewLicenseInfoRequest, setApplicationNewLicenseInfoRequest] = useState({LicenseFees: 20, TotalFees: 0, Notes: ""} as ApplicationNewLicenseInfoRequest)
  
    const [renewLicense, {isError, isSuccess, error}] = useRenewLicenseMutation();
    useEffect(()=>{
      if(applicationsTypesSuccess) {
        console.log(ApplicationsTypes.find(type => type.ApplicationTypeId === Number(EnApplicationTypes.RenewDrivingLicenseService))!.ApplicationTypeFees,);

        setApplicationNewLicenseInfoRequest(
          {
            ...applicationNewLicenseInfoRequest,
            ApplicationTypeId: EnApplicationTypes.RenewDrivingLicenseService,
            ApplicationFees: ApplicationsTypes.find(type => type.ApplicationTypeId === Number(EnApplicationTypes.RenewDrivingLicenseService))!.ApplicationTypeFees,
            PreviousLicenseId: LicenseID,
          }
        )
      }
  },[LicenseID, applicationNewLicenseInfoRequest.ApplicationFees])

  useEffect(() => {
    setApplicationNewLicenseInfoRequest(
      {
        ...applicationNewLicenseInfoRequest,
        TotalFees: applicationNewLicenseInfoRequest.ApplicationFees + applicationNewLicenseInfoRequest.LicenseFees
      })
  }, [applicationNewLicenseInfoRequest.ApplicationFees])
  const [showSuccessModal, setShowSuccessModal] = useState(false);
  
  const handleRenewLicense = async () =>{
    try {
      const response =  await renewLicense(applicationNewLicenseInfoRequest);
      setApplicationNewLicenseInfoRequest({...applicationNewLicenseInfoRequest
                                          ,RenewedLicenseId: Number(response.data?.NewLicenseId),
                                            RenewApplicationId: Number(response.data?.ApplicationId)
                                          })
    } catch (error) {
      console.log(error);
    }
  }

  const handleNotesChange = (value : string): void => {
    setApplicationNewLicenseInfoRequest({...applicationNewLicenseInfoRequest, Notes: value })
  }

    console.log(applicationNewLicenseInfoRequest);
    
    return (
    <div  className=" flex flex-col items-center gap-1 justify-center  w-[90%]">
        <SearchLicenseComponent setLicenseId={setLicenseID} />
        <GetLicenseInfo LicenseId={LicenseID} />
        {
        applicationNewLicenseInfoRequest.ApplicationFees &&
        <ApplicationNewLicenseInfo ApplicationNewLicenseInfo={applicationNewLicenseInfoRequest}  />
        }
          <div className="min-w[80%] w-[80%]">
                    <div className="mb-2 block">
                        <Label htmlFor="Note" value="Your Note" />
                    </div>
                    <Textarea   onChange={(e) => handleNotesChange(e.target.value)}  id="Note" placeholder="Leave a Note..." required rows={4} />
                </div>
        <Button className='p-1 mt-2 ' color={"blue"} onClick={handleRenewLicense} >
            Create
        </Button>
        {   isSuccess && !isError && <SuccessPopUp show = {showSuccessModal}
                                                        setShowPopUp={setShowSuccessModal}
                                                        operation= 'ReNew'
                                                        creationId={applicationNewLicenseInfoRequest.RenewedLicenseId} 
                                                        type='License'/>
        }
        {isError && <CustomError error={error ? error as ApiError : error} />}    
    </div>
  )
}

export default RenewLicense