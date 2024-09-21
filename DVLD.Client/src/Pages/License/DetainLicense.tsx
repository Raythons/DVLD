import React, { useEffect, useState } from 'react'
import SearchLicenseComponent from '../../components/Liccense/SearchLicenseComponent'
import GetLicenseInfo from '../../components/Liccense/GetLicenseInfo'
import { Button,  } from 'flowbite-react'
import { DetainLicenseInfoRequest, useDetainLicenseMutation } from '../../redux/api/LicenseApi'
import SuccessPopUp from '../../components/common/SuccessPopUp'
import CustomError from '../../components/common/CustomError'
import { ApiError } from '../../redux/api/peopleApi'
import DetainLicenseInfo from '../../components/Applications/DetainLicenseInfo'


const DetainLicense = () => {
    const [LicenseID, setLicenseID] = useState<number>(0);
    const [detainLicenseInfoRequest, setDetainLicenseInfoRequest] = useState({} as DetainLicenseInfoRequest)

    const [DetainLicense, {isError, isSuccess, error}] = useDetainLicenseMutation();

    useEffect(()=>{
        setDetainLicenseInfoRequest(
                {
                    ...detainLicenseInfoRequest,
                    PreviousLicenseId: LicenseID,
                }
            )
    },[LicenseID])


    const [showSuccessModal, setShowSuccessModal] = useState(false);

    const handleDetainLicense = async () =>{
        try {
            const response =  await DetainLicense(detainLicenseInfoRequest);
            setDetainLicenseInfoRequest({...detainLicenseInfoRequest
                                            ,RenewedLicenseId: Number(response.data?.NewLicenseId),
                                            RenewApplicationId: Number(response.data?.ApplicationId)
                                            })
            setShowSuccessModal(!showSuccessModal)
        } catch (error) {
        console.log(error);
    }   
}

    return (
    <div  className=" flex flex-col items-center gap-1 justify-center  w-[90%]">
        <SearchLicenseComponent setLicenseId={setLicenseID} />
        <GetLicenseInfo LicenseId={LicenseID} />
        {
        detainLicenseInfoRequest.PreviousLicenseId &&
        <DetainLicenseInfo detainLicenseInfoRequest={detainLicenseInfoRequest} setDetainInfoRequest = {setDetainLicenseInfoRequest} />
        }
        <Button className='p-1 mt-2 ' color={"blue"} onClick={handleDetainLicense} >
            Create
        </Button>
        {   isSuccess && !isError && <SuccessPopUp show = {showSuccessModal}
                                                        setShowPopUp={setShowSuccessModal}
                                                        operation= 'Detained'
                                                        creationId={detainLicenseInfoRequest.RenewedLicenseId} 
                                                        type='License'/>
        }
        {isError && <CustomError error={error ? error as ApiError : error} />}    
    </div>
  )
}

export default DetainLicense