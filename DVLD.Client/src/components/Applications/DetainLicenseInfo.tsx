import React  from 'react'
import AlignedPairWithIcon from '../common/AlignedPairWithIcon'
import { RxIdCard } from 'react-icons/rx'
import {  BsCardText, BsFillDatabaseFill } from 'react-icons/bs'
import { MdOutlineDateRange } from 'react-icons/md'
import { format } from '../../utils/formatDate'
import {DetainLicenseInfoRequest } from '../../redux/api/LicenseApi'
import { Label, TextInput } from 'flowbite-react'

type props = {
    detainLicenseInfoRequest: DetainLicenseInfoRequest,
    setDetainInfoRequest: React.Dispatch<React.SetStateAction<DetainLicenseInfoRequest>>
}




const DetainLicenseInfo = ({detainLicenseInfoRequest, setDetainInfoRequest} : props) => {

    const handleFeesChange = async (e: React.ChangeEvent<HTMLInputElement>) => {
        console.log(e.currentTarget.value);
        
        setDetainInfoRequest({...detainLicenseInfoRequest, FineFees: Number(e.target.value )})
    }
    
    
    return (
        <div className='flex relative justify-center items-center flex-col gap-3  w-[80%]  '>
            <div className='flex  justify-between relative  items-start  gap-3 border-solid border-gray-500 border-2 w-[100%]   p-6  mt-6 rounded-md'>
                <div className = 'absolute -top-4 left-4  border-slate-200 bg-slate-200 border-solid  border-2  '>
                        New Application Info
                </div>
                <div className='flex flex-col justify-center items-center  ' >
                    <AlignedPairWithIcon  fieldName='RenewApplicationId' icon = {<RxIdCard />} value = {detainLicenseInfoRequest?.DetainedLicenseId ??  "???"} />
                    <AlignedPairWithIcon fieldName='ApplicationDate' icon = {<BsCardText />} value = {format(new Date())} />
                    <div className=' flex justify-center items-center gap-1'>
                    <AlignedPairWithIcon fieldName='Application Fees' icon = {<BsFillDatabaseFill />} value ={detainLicenseInfoRequest.FineFees ?? "??"}   />
                        <Label></Label>
                        <TextInput onChange={handleFeesChange} id="input-gray" placeholder="Fine Fees" required color="gray" />
                    </div>
                    
                </div>
                <div className='flex flex-col justify-center items-start' >
                    <AlignedPairWithIcon fieldName='RenewedLicenseId' icon = {<MdOutlineDateRange />} value = {detainLicenseInfoRequest?.LicenseId ??  "???"} />
                    <AlignedPairWithIcon fieldName='Created By' icon = {<MdOutlineDateRange />} value = {"Rasheed"} />
                </div>
            </div>
        </div>
    )
}



export default DetainLicenseInfo