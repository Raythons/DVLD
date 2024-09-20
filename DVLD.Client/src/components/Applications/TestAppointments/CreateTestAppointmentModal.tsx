import {Button, Datepicker, Modal } from 'flowbite-react'
import React, { ReactNode, useEffect, useState } from 'react'
import { IconContext } from 'react-icons';
import AlignedPairWithIcon from '../../common/AlignedPairWithIcon';
import { RxIdCard } from 'react-icons/rx';
import { BsCardText, BsFillDatabaseFill } from 'react-icons/bs';
import { useGetLDLApplicationBriefInfoQuery } from '../../../redux/api/Applications/LDLApplicationsApi';
import { useGetApplicationBasicInfoQuery } from '../../../redux/api/Applications/BasicApplicationsApi';
import { useGetAllTestTypesQuery } from '../../../redux/api/TestTypesApi';
import { CreateTestAppointmentRequestParams, getLastTestTypeResultParams, useCreateTestAppointmentMutation, useGetLastTestTypeResultQuery } from '../../../redux/api/TestAppointmentsApi';
import SuccessPopUp from '../../common/SuccessPopUp';
import CustomError from '../../common/CustomError';
import { ApiError } from '../../../redux/api/peopleApi';
import { useGetAllApplicationsTypeQuery } from '../../../redux/api/Applications/ApplicationsTypeApi';
import { EnApplicationTypes } from '../../../enums/applicationTypes';


type props = {
    showModal: boolean;
    setShowModal:  React.Dispatch<React.SetStateAction<boolean>>
    LDLApplicationID: number,
    TestAppointmentIcon: ReactNode,
    TestTypeId: number,
    ApplicationId:number
    TestTypeTitle: "Vision" | "Written" | "Street"
}

type CreateTestAppointmentRequest = CreateTestAppointmentRequestParams

const CreateTestAppointmentModal = ({
        showModal,
        setShowModal,
        TestAppointmentIcon,
        LDLApplicationID,
        ApplicationId,
        TestTypeId,
        TestTypeTitle,
    } :props) => {
    
    
    const {data: LDLApplicationData} =   useGetLDLApplicationBriefInfoQuery(LDLApplicationID);
    const {data : ApplicationBasicInfo } = useGetApplicationBasicInfoQuery(ApplicationId);

    const {data: TestTypes , isSuccess: testTypesSuccess} = useGetAllTestTypesQuery({}); 
    const {data : ApplicationsTypes, isSuccess: applicationsTypesSuccess} =  useGetAllApplicationsTypeQuery({});
    
    const {data: HaveFailureTest, isSuccess: FailureTestSuccess} = useGetLastTestTypeResultQuery({LocalDrivingLicenseApplicationId:LDLApplicationID, TestTypeId } as getLastTestTypeResultParams);
    console.log(`LDLApplicationID ${LDLApplicationID} have ${HaveFailureTest ? "failed" : "no failed"} `);
        
    const [createTestAppointment, {isSuccess, isError, error}] = useCreateTestAppointmentMutation();

    const [testAppointmentToCreate, setTestAppointmentToCreate] = useState<CreateTestAppointmentRequest>({TestTypeId: 0, LocalDrivingLicenseApplicationId: 1,AppointmentDate:"aas", PaidFees: 0,CreatedByUserId: - 1, ApplicationsTypeId: -1});
    const [testTypeFees , setTestTypeFees] = useState(0);

    const [showSuccessModal , setShowSuccessModal] = useState<boolean>(false);

    const handleDateChange = (date: Date) => {
        setTestAppointmentToCreate({...testAppointmentToCreate, AppointmentDate: date.toISOString()})
    }

    useEffect(() => {
            if(testTypesSuccess)
                TestTypes.map((testType) => {
                    if(testType.Id == TestTypeId)
                        setTestTypeFees(testType.TestTypeFees)
                })

            if(FailureTestSuccess && applicationsTypesSuccess){
                    if (HaveFailureTest.TestResult === 0){
                        console.log(ApplicationsTypes.find((appType) => appType.ApplicationTypeId === EnApplicationTypes.RetakeTest)?.ApplicationTypeFees);
                        
                        setTestAppointmentToCreate({...testAppointmentToCreate,
                            ApplicationsTypeId:  EnApplicationTypes.RetakeTest,
                            ApplicationTypeFees: ApplicationsTypes.find((appType) => appType.ApplicationTypeId === EnApplicationTypes.RetakeTest)?.ApplicationTypeFees
                        })
                    }
                }              
    },[FailureTestSuccess, applicationsTypesSuccess, ApplicationBasicInfo,])

    console.log(testAppointmentToCreate);
    

    useEffect (() => {
            setTestAppointmentToCreate({...testAppointmentToCreate,
                                        TestTypeId,
                                        LocalDrivingLicenseApplicationId:LDLApplicationID,
                                        PaidFees:  testAppointmentToCreate.PaidFees + testTypeFees,
                                    })
    },[TestTypeId, LDLApplicationID, testTypeFees])


    
    const handleCreateTestAppointment =  async () => {
        try {
            const s =  await  createTestAppointment(testAppointmentToCreate).unwrap();
            setShowSuccessModal(s);
        } catch (error) {
            console.log(error);
        }
    }

    const customTheme ={
        popup : {
            root: {
            inner: " absolute rounded-lg bg-white p-4 shadow-lg -top-[375px]"
            },
    }}

    return (
    <Modal  show={showModal} size="3xl" popup onClose={() => setShowModal(false)}>
        <Modal.Header/>
        <Modal.Body className='flex flex-col justify-center items-center gap-3 p-14'>
            <div className='flex flex-col items-center justify-center relative border-solid w-[90%] border-gray-500 border-2 rounded-md gap-3 mt-16'>
                <div className = 'absolute -top-4 left-4  border-white bg-white border-solid  border-2'>
                    {TestTypeTitle} Test 
                </div>
                <IconContext.Provider value={{className: "text-sky-700  ", size:"70",  }}>
                    {TestAppointmentIcon}
                </IconContext.Provider>
                <h2 className='p-3 font-bold text-rose-600'>Schedule Test</h2>
            </div>

            <div className='flex flex-col items-center justify-center  border-solid w-[90%] pt-10 border-gray-500 border-2 rounded-md gap-3 p-4 '>
                <AlignedPairWithIcon fieldName={"D.L.App.ID"} icon={<RxIdCard />} value={LDLApplicationID}/>
                <AlignedPairWithIcon fieldName={"D.Class"} icon={< BsCardText/>} value={LDLApplicationData?.LicenseClass}/>
                <AlignedPairWithIcon fieldName={"Name"} icon={<RxIdCard />} value={ApplicationBasicInfo?.FullName}/>
                <div className='flex self-start  justify-center items-center'>
                    <p className='p-1 mr-3  font-bold'> Date</p>
                    <Datepicker  className=' self-start'
                            maxDate={new Date(2026,1,1)}
                            minDate={new Date()}
                            theme= {customTheme} 
                            id='BirthDate'
                            onSelectedDateChanged={handleDateChange}
                            />
                </div>
                <AlignedPairWithIcon fieldName={"Fees"} icon={<BsFillDatabaseFill />} value={testTypeFees}/>
            </div>

            
            <div className= {`flex ${!testAppointmentToCreate.ApplicationTypeFees  ? " opacity-50": ""} relative items-center justify-between  border-solid w-[90%] p-3 border-gray-500 border-2 rounded-md gap-3  mt-4`}>
                <div className = 'absolute -top-4 left-4  border-white bg-white border-solid  border-2'>
                    Retake Test Info
                </div>

                <div className='flex - flex-col items-center justify-center'>
                    <AlignedPairWithIcon fieldName={"R.App.Fees"} icon={<BsFillDatabaseFill />} value={testAppointmentToCreate.PaidFees }/>
                    <AlignedPairWithIcon fieldName={"R.Test.App.ID"} icon={< BsCardText/>} value={"N/A"}/>
                </div>
                    <AlignedPairWithIcon fieldName={"Total Fees"} icon={<BsFillDatabaseFill />} value={testAppointmentToCreate.PaidFees + (testAppointmentToCreate.ApplicationTypeFees ? testAppointmentToCreate.ApplicationTypeFees : 0)}/>
            </div>
            <Button  onClick={() => handleCreateTestAppointment()}  color="blue" className=' self-end'>
                Create
            </Button>
            
            {   isSuccess && !isError && <SuccessPopUp show = {showSuccessModal}
                                                    setShowPopUp={setShowSuccessModal}
                                                    operation='Created'
                                                    creationId={0} 
                                                    type='TestAppointment'/>
                
            }
            {isError && <CustomError error={error ? error as ApiError : error} />}    
            

        </Modal.Body>
    </Modal>
)}

export default CreateTestAppointmentModal


