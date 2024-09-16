import DrivingLicenseApplicationInfo from '../Applications/TestAppointments/DrivingLicenseApplicationInfo'
import ApplicationBasicInfo from '../Applications/TestAppointments/ApplicationBasicInfo'
import { Button, Label, Modal, Textarea } from 'flowbite-react';
import {  useGetLDLApplicationIdQuery } from '../../redux/api/Applications/LDLApplicationsApi';
import { useEffect, useState } from 'react';
import { issueLicenseParams, useIssueLicenseMutation } from '../../redux/api/LicenseApi';
import { EnApplicationTypes } from '../../enums/applicationTypes';
import { useGetAllApplicationsTypeQuery } from '../../redux/api/Applications/ApplicationsTypeApi';


type props = {
    showModal: boolean;
    setShowModal:  React.Dispatch<React.SetStateAction<boolean>>
    LDLApplicationID: number,
}

const IssueLicenseModal = ( {showModal, setShowModal, LDLApplicationID} : props) => {
    // const {data: LDLApplicationData} = useGetLDLApplicationBriefInfoQuery(LDLApplicationID);
    const {data : ApplicationID, isSuccess} = useGetLDLApplicationIdQuery(Number(LDLApplicationID));
    
    const [licenseToCreate, setLicenseToCreate] = useState<issueLicenseParams>({IssueReason: "None"} as issueLicenseParams);
    const [issueLicense , {isSuccess: isIssueSuccess, isError, error}] = useIssueLicenseMutation();

    const {data: ApplicationsTypes , isSuccess : ApplicationsTypesSuccess} = useGetAllApplicationsTypeQuery({});

    useEffect (() => {
            if(isSuccess && ApplicationsTypesSuccess) 
                setLicenseToCreate({
                        ...licenseToCreate, LocalDrivingLicenseApplicationId: LDLApplicationID, 
                        ApplicationTypeId: EnApplicationTypes.NewLocalDrivingLicenseService,
                        PaidFees: 15
                    })
    }, [LDLApplicationID, ApplicationID, ApplicationsTypes])

    console.log(licenseToCreate);
    console.log(error);
    
    const handleNotesChange = (value : string): void => {
        setLicenseToCreate({...licenseToCreate, Notes: value })
    }

    const handleIssueLicense =  async () => {
        try {
            const isIssued = issueLicense(licenseToCreate).unwrap();
            console.log(isIssued);
        } catch (error) {
            console.log(error);
        }
    }
    
return (
    <Modal   show={showModal} size="7xl" popup onClose={() => setShowModal(false)}>
            <Modal.Header className=' bg-slate-200'/>
            <Modal.Body className='flex flex-col justify-center items-center gap-3 p-14 bg-slate-200'>
                <DrivingLicenseApplicationInfo  LDLApplicationID = { Number(LDLApplicationID) } />
                <ApplicationBasicInfo  ApplicationID = { isSuccess? ApplicationID : 0 }  />
                <div className="min-w[80%] w-[80%]">
                    <div className="mb-2 block">
                        <Label htmlFor="Note" value="Your Note" />
                    </div>
                    <Textarea   onChange={(e) => handleNotesChange(e.target.value)}  id="Note"  placeholder="Leave a Note..." required rows={4} />
                </div>
                <Button color={"blue"} onClick={()=> handleIssueLicense()}>
                    Create
                </Button>
            </Modal.Body>
    </Modal>
    )}

export default IssueLicenseModal