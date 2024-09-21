import React  from 'react'
import AlignedPairWithIcon from '../common/AlignedPairWithIcon'
import { RxIdCard } from 'react-icons/rx'
import {  BsCardText, BsFillDatabaseFill } from 'react-icons/bs'
import { FaClipboardQuestion, FaRegUser } from 'react-icons/fa6'
import { MdOutlineDateRange } from 'react-icons/md'
import { RiAdminFill } from 'react-icons/ri'
import { format } from '../../utils/formatDate'
import { ApplicationNewLicenseInfoRequest } from '../../redux/api/LicenseApi'

type props = {
  ApplicationNewLicenseInfo: ApplicationNewLicenseInfoRequest,
}



const ApplicationNewLicenseInfo = ({ApplicationNewLicenseInfo} : props) => {
    
    
    return (
        <div className='flex relative justify-center items-center flex-col gap-3  w-[80%]  '>
            <div className='flex  justify-between relative  items-start  gap-3 border-solid border-gray-500 border-2 w-[100%]   p-6  mt-6 rounded-md'>
                <div className = 'absolute -top-4 left-4  border-slate-200 bg-slate-200 border-solid  border-2  '>
                        New Application Info
                </div>
                <div className='flex flex-col justify-center items-center  ' >
                    <AlignedPairWithIcon  fieldName='RenewApplicationId' icon = {<RxIdCard />} value = {ApplicationNewLicenseInfo?.RenewApplicationId ??  "???"} />
                    <AlignedPairWithIcon fieldName='ApplicationDate' icon = {<BsCardText />} value = {format(new Date())} />
                    <AlignedPairWithIcon fieldName='Issue Date' icon = {<BsFillDatabaseFill />} value = {format(new Date()) } />
                    <AlignedPairWithIcon fieldName='ApplicationFees' icon = {<FaClipboardQuestion />} value = {ApplicationNewLicenseInfo?.ApplicationFees ??  "???"} />
                    <AlignedPairWithIcon fieldName='LicenseFees' icon = {<FaRegUser />} value = {ApplicationNewLicenseInfo?.LicenseFees ??  "???" } />
                </div>
                <div className='flex flex-col justify-center items-start' >
                    <AlignedPairWithIcon fieldName='RenewedLicenseId' icon = {<MdOutlineDateRange />} value = {ApplicationNewLicenseInfo?.RenewedLicenseId ??  "???"} />
                    <AlignedPairWithIcon fieldName='Old LicenseId' icon = {<MdOutlineDateRange />} value = {ApplicationNewLicenseInfo.PreviousLicenseId} />
                    <AlignedPairWithIcon fieldName='ExpirationDate' icon = {<MdOutlineDateRange />} value = {format(new Date())} />
                    <AlignedPairWithIcon fieldName='CreatedBy' icon = {<RiAdminFill />} value = {"Rasheed"} />
                    <AlignedPairWithIcon fieldName='Total Fees' icon = {<RiAdminFill />} value = {ApplicationNewLicenseInfo.TotalFees ??  "???"} />
                </div>
            </div>
        </div>
  )
}



export default ApplicationNewLicenseInfo