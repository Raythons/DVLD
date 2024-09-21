import React  from 'react'
import AlignedPairWithIcon from '../common/AlignedPairWithIcon'
import { RxIdCard } from 'react-icons/rx'
import {  BsCardText, BsFillDatabaseFill } from 'react-icons/bs'
import { MdOutlineDateRange } from 'react-icons/md'
import {ReleaseLicenseRequest } from '../../redux/api/LicenseApi'

type props = {
    releaseLicenseLicenseInfo: ReleaseLicenseRequest,
}
const ReleaseLicenseInfo = ({releaseLicenseLicenseInfo} : props) => {
    return (
        <div className='flex relative justify-center items-center flex-col gap-3  w-[80%]  '>
            <div className='flex  justify-between relative  items-start  gap-3 border-solid border-gray-500 border-2 w-[100%]   p-6  mt-6 rounded-md'>
                <div className = 'absolute -top-4 left-4  border-slate-200 bg-slate-200 border-solid  border-2  '>
                        Release License Info
                </div>
                <div className='flex flex-col justify-center items-center  ' >
                    <AlignedPairWithIcon  fieldName='Detain ID' icon = {<RxIdCard />} value = {releaseLicenseLicenseInfo?.DetainId ??  "???"} />
                    <AlignedPairWithIcon fieldName='DetainDate' icon = {<BsCardText />} value = {releaseLicenseLicenseInfo.DetainDate} />
                    <AlignedPairWithIcon fieldName='Application Fees' icon = {<BsFillDatabaseFill />} value ={releaseLicenseLicenseInfo.ApplicationFees ?? "??"}   />
                </div>
                <div className='flex flex-col justify-center items-start' >
                    <AlignedPairWithIcon fieldName='License ID' icon = {<MdOutlineDateRange />} value = {releaseLicenseLicenseInfo?.LicenseId ??  "???"} />
                    <AlignedPairWithIcon fieldName='Created By' icon = {<MdOutlineDateRange />} value = {releaseLicenseLicenseInfo.CreatedBy ?? "???"} />
                    <AlignedPairWithIcon fieldName='Fine Fees' icon = {<BsFillDatabaseFill />} value = {releaseLicenseLicenseInfo.FineFees} />
                    <AlignedPairWithIcon fieldName='Release ID' icon = {<MdOutlineDateRange />} value = {releaseLicenseLicenseInfo.ReleaseId ?? "???"} />
                </div>
            </div>
        </div>
    )
}

export default ReleaseLicenseInfo