import React, { useEffect, useState } from 'react'
import SearchLicenseComponent from '../../Liccense/SearchLicenseComponent';
import GetLicenseInfo from '../../Liccense/GetLicenseInfo';
import { Button } from 'flowbite-react';
import { useGetAllApplicationsTypeQuery } from '../../../redux/api/Applications/ApplicationsTypeApi';
import { IssueInternationalLicenseRequest, useIssueInterNationalLicenseMutation } from '../../../redux/api/internationalLicenseApi';
import { EnApplicationTypes } from '../../../enums/applicationTypes';
import { useLazyGetLicenseInfoQuery } from '../../../redux/api/LicenseApi';
import SuccessPopUp from '../../common/SuccessPopUp';
import CustomError from '../../common/CustomError';
import { ApiError } from '../../../redux/api/peopleApi';

const IssueInternationalLicense = () => {
    const [LicenseID, setLicenseID] = useState<number>(0);
    
    const [getLicenseInfoQuery] = useLazyGetLicenseInfoQuery();
    const [issueInternationalLicense, {isError: issueInterNationalLicenseError, isSuccess, error }] = useIssueInterNationalLicenseMutation();
    const  {data: ApplicationsTypes, isSuccess: ApplicationsTypesSuccess }= useGetAllApplicationsTypeQuery({})
    
    const [issueInternationalLicenseParams , setIssueInternationalLicenseParams] = useState<IssueInternationalLicenseRequest>({ApplicationTypeFees: -1, ApplicationTypeId : -1 , DriverId: -1, LicenseId: LicenseID} as IssueInternationalLicenseRequest);
    
  
    useEffect(() => {
      const func  = async () => {
        if  (ApplicationsTypesSuccess  && LicenseID != 0) {
          try 
          {
              const GetLicenseInfoRes = await getLicenseInfoQuery(LicenseID).unwrap()
              setIssueInternationalLicenseParams({
                ...issueInternationalLicenseParams,
                ApplicationTypeId: EnApplicationTypes.NewInternationalLicense,
                ApplicationTypeFees: ApplicationsTypes.find(type => type.ApplicationTypeId === Number(EnApplicationTypes.NewInternationalLicense))!.ApplicationTypeFees,
                LicenseId: LicenseID,
                DriverId: GetLicenseInfoRes.DriverId
              })
              console.log(issueInternationalLicenseParams);
              
          } catch (error) {
              console.log(error);  
          }
        }
      } 
      func();
    }, [LicenseID, ApplicationsTypesSuccess])

    const [showSuccessModal, setShowSuccessModal] = useState(false);

  

    const handleIssueLicense =  async () => {
      try {
          const isIssued = await issueInternationalLicense(issueInternationalLicenseParams);
          console.log(isIssued);
      } catch (error) {
          console.log(error);
      }
  }
  console.log(issueInternationalLicenseParams);
  
  issueInterNationalLicenseError
    return (
    <div  className=" flex flex-col items-center gap-1 justify-center  w-[90%]">
        <SearchLicenseComponent setLicenseId={setLicenseID} />
        <GetLicenseInfo LicenseId={LicenseID} />
        <Button className='p-1 mt-2 ' color={"blue"} onClick={handleIssueLicense} >
          Create
        </Button>
        {   isSuccess && !issueInterNationalLicenseError && <SuccessPopUp show = {showSuccessModal}
                                                        setShowPopUp={setShowSuccessModal}
                                                        operation= 'Created'
                                                        creationId={0} 
                                                        type='Test'/>
                }
                {issueInterNationalLicenseError && <CustomError error={error ? error as ApiError : error} />}    
    </div>
)}

export default IssueInternationalLicense