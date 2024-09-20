import React, { useEffect, useState } from 'react'
import AlignedPairWithIcon from '../common/AlignedPairWithIcon'
import CustomError from '../common/CustomError'
import { ApiError } from '../../redux/api/peopleApi'
import { GetLicenseInfoResponse, useLazyGetLicenseInfoQuery } from '../../redux/api/LicenseApi'
import { Avatar, Spinner } from 'flowbite-react'
import { RxIdCard } from 'react-icons/rx'
import { BsCardText, BsFillDatabaseFill } from 'react-icons/bs'
import { FaClipboardQuestion, FaRegUser } from 'react-icons/fa6'
import { MdOutlineDateRange } from 'react-icons/md'
import { RiAdminFill } from 'react-icons/ri'


type props = {
    LicenseId: number
}

const GetLicenseInfo = ({LicenseId} : props) => {

    const [getLicenseInfoQuery,{ isError , isLoading, error}] = useLazyGetLicenseInfoQuery();
    const [LicenseInfo, setLicenseInfo] = useState<GetLicenseInfoResponse>({} as GetLicenseInfoResponse)

    useEffect(()=>{
        const func = async () => {
            if (LicenseId != 0) {
                try {
                    const GetLicenseInfoRes = await getLicenseInfoQuery(LicenseId).unwrap()
                    setLicenseInfo({...GetLicenseInfoRes})
                } catch (error) {
                    console.log(error);
                }
            }
        }
        func();
    },[LicenseId])
    
    return (
        isLoading 
        ?
            <Spinner />
        : 
        <div className='flex relative justify-center items-center flex-col gap-3  w-[80%]  '>
        {
            isError    &&  <CustomError  error={error ? error as ApiError : undefined}    />
        }
            <div className='flex  justify-between relative  items-start  gap-3 border-solid border-gray-500 border-2 w-[100%]   p-6  mt-6 rounded-md'>
                <div className = 'absolute -top-4 left-4  border-slate-200 bg-slate-200 border-solid  border-2  '>
                        Basic Application Info
                </div>
                <div className='flex flex-col justify-center items-center  ' >
                    <AlignedPairWithIcon  fieldName='Class' icon = {<RxIdCard />} value = {LicenseInfo?.LicenseClass ??  "???"} />
                    <AlignedPairWithIcon fieldName='Name' icon = {<BsCardText />} value = {LicenseInfo?.Name ??  "???"} />
                    <AlignedPairWithIcon fieldName='License Id' icon = {<BsFillDatabaseFill />} value = {LicenseInfo?.Id  ??  "???" } />
                    <AlignedPairWithIcon fieldName='NationalNo' icon = {<FaClipboardQuestion />} value = {LicenseInfo?.NationalNo ??  "???" } />
                    <AlignedPairWithIcon fieldName='Gender' icon = {<FaRegUser />} value = {LicenseInfo?.Gender ??  "???" } />
                    <AlignedPairWithIcon fieldName='IssueDate' icon = {<BsFillDatabaseFill />} value = {LicenseInfo?.IssueDate ??   "???" } />
                    <AlignedPairWithIcon fieldName='IssueReason' icon = {<FaClipboardQuestion />} value = {LicenseInfo?.IssueReason ??  "???" } />
                    <AlignedPairWithIcon fieldName='Notes' icon = {<FaRegUser />} value = {LicenseInfo?.Notes  ?? "???" } />
                </div>
                <div className='flex flex-col justify-center items-start' >
                    <AlignedPairWithIcon fieldName='isActive' icon = {<MdOutlineDateRange />} value = {LicenseInfo?.IsActive ? "Yes" : "No"} />
                    <AlignedPairWithIcon fieldName='DateOfBirth' icon = {<MdOutlineDateRange />} value = {LicenseInfo?.DateOfBirth} />
                    <AlignedPairWithIcon fieldName='DriverId' icon = {<RiAdminFill />} value = {LicenseInfo?.DriverId} />
                    <AlignedPairWithIcon fieldName='ExpirationDate' icon = {<MdOutlineDateRange />} value = {LicenseInfo?.ExpirationDate} />
                    <AlignedPairWithIcon fieldName='Is Detained' icon = {<RiAdminFill />} value = {LicenseInfo?.IsActive ? "yes" : "no"} />
                    <div className='w-[100%] flex justify-between items-center'>
                        <Avatar img = {`/${LicenseInfo?.ImagePath ?? "UnknownUser.jpg "}`}     size="lg"  rounded={true}  className='w-3/4 h-3/4  p-4 pb-0  self-end  place-self-end'/>
                    </div>
                </div>
            </div>
        </div>
    )}

export default GetLicenseInfo