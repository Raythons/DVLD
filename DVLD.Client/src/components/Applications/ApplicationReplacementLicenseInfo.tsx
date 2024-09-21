import React  from 'react'
import AlignedPairWithIcon from '../common/AlignedPairWithIcon'
import { RxIdCard } from 'react-icons/rx'
import {  BsCardText, BsFillDatabaseFill } from 'react-icons/bs'
import { MdOutlineDateRange } from 'react-icons/md'
import { format } from '../../utils/formatDate'
import {ApplicationReplacementNewLicenseInfoRequest } from '../../redux/api/LicenseApi'

type props = {
    ApplicationReplacementLicenseInfo: ApplicationReplacementNewLicenseInfoRequest,
}



const ApplicationReplacementLicenseInfo = ({ApplicationReplacementLicenseInfo} : props) => {
    
    
    return (
        <div className='flex relative justify-center items-center flex-col gap-3  w-[80%]  '>
            <div className='flex  justify-between relative  items-start  gap-3 border-solid border-gray-500 border-2 w-[100%]   p-6  mt-6 rounded-md'>
                <div className = 'absolute -top-4 left-4  border-slate-200 bg-slate-200 border-solid  border-2  '>
                        New Application Info
                </div>
                <div className='flex flex-col justify-center items-center  ' >
                    <AlignedPairWithIcon  fieldName='RenewApplicationId' icon = {<RxIdCard />} value = {ApplicationReplacementLicenseInfo?.RenewApplicationId ??  "???"} />
                    <AlignedPairWithIcon fieldName='ApplicationDate' icon = {<BsCardText />} value = {format(new Date())} />
                    <AlignedPairWithIcon fieldName='Application Fees' icon = {<BsFillDatabaseFill />} value ={ApplicationReplacementLicenseInfo.ApplicationFees ?? "??"}   />
                </div>
                <div className='flex flex-col justify-center items-start' >
                    <AlignedPairWithIcon fieldName='RenewedLicenseId' icon = {<MdOutlineDateRange />} value = {ApplicationReplacementLicenseInfo?.RenewedLicenseId ??  "???"} />
                    <AlignedPairWithIcon fieldName='Old LicenseId' icon = {<MdOutlineDateRange />} value = {ApplicationReplacementLicenseInfo.PreviousLicenseId} />
                    <AlignedPairWithIcon fieldName='Created By' icon = {<MdOutlineDateRange />} value = {ApplicationReplacementLicenseInfo.CreatedBy} />
                </div>
            </div>
        </div>
  )
}



export default ApplicationReplacementLicenseInfo