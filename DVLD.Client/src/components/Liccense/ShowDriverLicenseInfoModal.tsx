import { Modal } from 'flowbite-react';
import GetLicenseInfo from './GetLicenseInfo';
import { useGetLDLApplicationIdQuery } from '../../redux/api/Applications/LDLApplicationsApi';
import { useEffect, useState } from 'react';
import { useLazyGetLicenseIdByApplicationIdQuery } from '../../redux/api/LicenseApi';
import CustomError from '../common/CustomError';
import { ApiError } from '../../redux/api/peopleApi';


type props = {
    showModal: boolean;
    setShowModal:  React.Dispatch<React.SetStateAction<boolean>>
    LDLApplicationID: number,
}

const ShowDriverLicenseInfoModal = ( {showModal, setShowModal, LDLApplicationID} : props) => {

    const [LicenseId , setLicenseId] = useState(0);
    const {data : ApplicationID, isSuccess} = useGetLDLApplicationIdQuery(Number(LDLApplicationID));
    const [getLicenseId, {isError, error, isSuccess: LicenseIdSuccess}] = useLazyGetLicenseIdByApplicationIdQuery();
    
    useEffect(() =>{
        const func = async () => {
            if(isSuccess) {
                try {
                    const licenseId = await getLicenseId(ApplicationID).unwrap();
                    setLicenseId(licenseId)
                    
                } catch (error) {
                    console.log(error);
                }
            }
        }
        func();
    },[ApplicationID, LicenseId])


    return (
        <Modal   show={showModal} size="7xl" popup onClose={() => setShowModal(false)}>
                <Modal.Header className=' bg-slate-200'/>
                <Modal.Body className='flex flex-col justify-center items-center gap-3 p-14 bg-slate-200'>
                    {LicenseIdSuccess && <GetLicenseInfo  LicenseId={LicenseId}/>}
                    {isError && <CustomError error={error ? error as ApiError : error} />}    
                </Modal.Body>
        </Modal>
    )}

export default ShowDriverLicenseInfoModal
