import { Button, Label, Modal, Textarea } from 'flowbite-react'
import React, {  ReactNode, useEffect, useState } from 'react'
import { IconContext } from 'react-icons'
import AlignedPairWithIcon from '../../common/AlignedPairWithIcon'
import { BsCardText, BsFillDatabaseFill } from 'react-icons/bs'
import { RxIdCard } from 'react-icons/rx'
import { useGetLDLApplicationBriefInfoQuery, useGetLDLApplicationIdQuery } from '../../../redux/api/Applications/LDLApplicationsApi'
import {useLazyGetApplicationBasicInfoQuery } from '../../../redux/api/Applications/BasicApplicationsApi'
import { TakeTestParams, useTakeTestTestMutation } from '../../../redux/api/TestsApi'
import SuccessPopUp from '../../common/SuccessPopUp'
import CustomError from '../../common/CustomError'
import { ApiError } from '../../../redux/api/peopleApi'


type props = {
    showModal: boolean;
    setShowModal:  React.Dispatch<React.SetStateAction<boolean>>
    LDLApplicationID: number,
    TestTypeIcon: ReactNode,
    TestAppointmentId: number,
    // TestTypeId: number,
    TestTypeTitle: "Vision" | "Written" | "Street"
}


const TakeTestModal = ({
    showModal,
    setShowModal,
    TestTypeIcon,
    LDLApplicationID,
    TestTypeTitle,
    TestAppointmentId
} :props) => {
    
    const {data: LDLApplicationData} = useGetLDLApplicationBriefInfoQuery(LDLApplicationID);
    const {data : ApplicationID, isSuccess} = useGetLDLApplicationIdQuery(Number(LDLApplicationID));
    const [getApplication] = useLazyGetApplicationBasicInfoQuery();

    const [takeTestRequest, setTakeTestRequest] = useState<TakeTestParams>({} as TakeTestParams);
    const [testResult, setTestResult] = useState<number | null>(takeTestRequest?.TestResult || null); // Initialize based on takeTestRequest

    const [takeTest, {isError, error}] = useTakeTestTestMutation();

    const [personName, setPersonName] = useState("");
    
    const [showSuccessModal, setShowSuccessModal] = useState(false);
    
    const handleRadioChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        const newTestResult = parseInt(event.target.value);

        setTestResult(newTestResult);
        setTakeTestRequest( {...takeTestRequest, TestResult : newTestResult } );
    };
    
    const handleNotesChange = (value : string): void => {
        setTakeTestRequest({...takeTestRequest, Notes: value })
    }
    
    useEffect ( () => {
        const handleChanges =  () => {
            setTakeTestRequest({...takeTestRequest,TestAppointmentId,  })
        }
        handleChanges();
    },[TestAppointmentId])
    

    useEffect( () => {
        const func =  async () => {
            if (isSuccess) {
                try {
                    const res = await getApplication(ApplicationID).unwrap()
                    setPersonName(res.FullName)
                } catch (error) {
                    console.log(error);
                }
            }
        }
    func();
    }, [isSuccess])

    const handleCreateTest = async () => {
        try {
            const res = await takeTest(takeTestRequest).unwrap()
            setShowSuccessModal(res);
            console.log(res);
        } catch (error) {
            console.log(error);
        }
    }

    return (
        <Modal  show={showModal} size="2xl" popup onClose={() => setShowModal(false)}>
            <Modal.Header/>
            <Modal.Body className='flex flex-col justify-center items-center gap-3 p-14'>
                <div className='flex flex-col items-center justify-center relative border-solid w-[90%] border-gray-500 border-2 rounded-md gap-3 mt-20'>
                    <div className = 'absolute -top-4 left-4  border-white bg-white border-solid  border-2'>
                        {TestTypeTitle} Test 
                    </div>
                    <IconContext.Provider value={{className: "text-sky-700  ", size:"70"}}>
                        {TestTypeIcon}
                    </IconContext.Provider>
                </div>
                <div className='flex flex-col items-center justify-center  border-solid w-[90%] pt-10 border-gray-500 border-2 rounded-md gap-3 p-4 '>
                    <AlignedPairWithIcon fieldName={"D.L.App.ID"} icon={<RxIdCard />} value={LDLApplicationID}/>
                    <AlignedPairWithIcon fieldName={"D.Class"} icon={< BsCardText/>} value={LDLApplicationData?.LicenseClass}/>
                    <AlignedPairWithIcon fieldName={"Name"} icon={<RxIdCard />} value={personName}/>
                    <AlignedPairWithIcon fieldName={"Date"} icon={<BsFillDatabaseFill />} value={`${new Date().getFullYear()}/${new Date().getMonth()}/${new Date().getDay()}`}/>
                    <AlignedPairWithIcon fieldName={"Fees"} icon={<BsFillDatabaseFill />} value={10}/>
                    <AlignedPairWithIcon fieldName={"Test Id"} icon={<BsFillDatabaseFill />} value={"Not Taken Yet"}/>
                </div>
                <div className=' flex justify-center items-center gap-2 w-80'>
                <AlignedPairWithIcon fieldName={"Result"} icon={<RxIdCard />} value={""}/>
                    <div className=" ml-4 flex items-center me-4">
                        <input  name="test-result" checked={testResult === 1} onChange={handleRadioChange}  id="Pass-radio" type="radio" value={1}  className="w-4 h-4 text-sky-600 bg-gray-100 border-gray-300  focus:ring-blue-500  dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
                        <label htmlFor="Pass-radio" className="ms-2 text-sm font-medium text-gray-900 dark:text-gray-300">Pass</label>
                    </div>
                    <div className="flex items-center me-4">
                        <input name="test-result" checked={testResult === 0} onChange={handleRadioChange}  id="fail-radio" type="radio" value={0}  className="w-4 h-4  text-rose-600 bg-gray-100 border-gray-300  focus:ring-red-500 dark:focus:ring-green-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
                        <label htmlFor="fail-radio" className="ms-2 text-sm font-medium text-gray-900 dark:text-gray-300">Fail</label>
                    </div>
                </div>
                <div className="min-w[80%] w-[80%]">
                    <div className="mb-2 block">
                        <Label htmlFor="Note" value="Your Note" />
                    </div>
                    <Textarea   onChange={(e) => handleNotesChange(e.target.value)}  id="Note" color={takeTestRequest.TestResult  == 0 ?  "failure" : takeTestRequest.TestResult == 1 ? "success" : "" } placeholder="Leave a Note..." required rows={4} />
                </div>
                <Button  onClick={() => handleCreateTest()}  color="blue" className=' self-end'>
                    Submit
                </Button>
                {   isSuccess && !isError && <SuccessPopUp show = {showSuccessModal}
                                                        setShowPopUp={setShowSuccessModal}
                                                        operation= 'Created'
                                                        creationId={0} 
                                                        type='Test'/>
                }
                {isError && <CustomError error={error ? error as ApiError : error} />}    
            </Modal.Body>
        </Modal>
    )}


export default TakeTestModal