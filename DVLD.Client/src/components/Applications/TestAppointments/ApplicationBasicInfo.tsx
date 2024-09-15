import React from 'react'
import { BsCardText } from 'react-icons/bs'
import { BsFillDatabaseFill } from "react-icons/bs";
import { FaClipboardQuestion } from "react-icons/fa6";
import { FaRegUser } from "react-icons/fa";
import { RxIdCard } from "react-icons/rx";
import { MdOutlineDateRange } from "react-icons/md";
import { RiAdminFill } from "react-icons/ri";
import { useGetApplicationBasicInfoQuery } from '../../../redux/api/Applications/BasicApplicationsApi';
import { Spinner } from 'flowbite-react';
import CustomError from '../../common/CustomError';
import { ApiError } from '../../../redux/api/peopleApi';
import AlignedPairWithIcon from '../../common/AlignedPairWithIcon';


type props = {
    ApplicationID?: number
}
const ApplicationBasicInfo = ( {ApplicationID}: props ) => {
    const {data : ApplicationBasicInfo , isError , isLoading, error} = 
    useGetApplicationBasicInfoQuery(ApplicationID as number);

    return (
    isLoading 
    ?
        <Spinner />
    : 
    <div className='flex relative justify-center items-between flex-col gap-3 border-solid border-gray-500 border-2 w-[80%]   p-6  mt-6 rounded-md '>
        <div className = 'absolute -top-4 left-4  border-slate-200 bg-slate-200 border-solid  border-2 w-[95%] '>
                Basic Application Info
        </div>
    {
        isError    &&  <CustomError  error={error ? error as ApiError : undefined}    />
    }
        <div className='flex  justify-between  items-start  '>
            <div className='flex flex-col justify-center items-center ' >
                <AlignedPairWithIcon  fieldName='ID' icon = {<RxIdCard />} value = {ApplicationBasicInfo?.Id} />
                <AlignedPairWithIcon fieldName='Status' icon = {<BsCardText />} value = {ApplicationBasicInfo?.Status} />
                <AlignedPairWithIcon fieldName='Fees' icon = {<BsFillDatabaseFill />} value = {ApplicationBasicInfo?.PaidFees} />
                <AlignedPairWithIcon fieldName='Type' icon = {<FaClipboardQuestion />} value = {ApplicationBasicInfo?.ApplicationTypeTitle} />
                <AlignedPairWithIcon fieldName='Applicant' icon = {<FaRegUser />} value = {ApplicationBasicInfo?.FullName} />
            </div>
            <div className='flex flex-col justify-center items-start' >
                <AlignedPairWithIcon fieldName='Date' icon = {<MdOutlineDateRange />} value = {ApplicationBasicInfo?.CreatedAt} />
                <AlignedPairWithIcon fieldName='Status Date' icon = {<MdOutlineDateRange />} value = {ApplicationBasicInfo?.LastStatusDate} />
                <AlignedPairWithIcon fieldName='Created By' icon = {<RiAdminFill />} value = {ApplicationBasicInfo?.CreatedByUser} />
            </div>
        </div>
    </div>
)}

export default ApplicationBasicInfo