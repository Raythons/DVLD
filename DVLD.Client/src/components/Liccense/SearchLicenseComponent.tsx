import { Button } from 'flowbite-react';
import React from 'react'
import { IconContext } from 'react-icons';
import { FaCreditCard } from "react-icons/fa";
import { ReleaseLicenseRequest } from '../../redux/api/LicenseApi';


type props = {
    setLicenseId: React.Dispatch<React.SetStateAction<number>>,
    releaseLicenseInfoRequest?: ReleaseLicenseRequest
    setReleaseLicenseId?:React.Dispatch<React.SetStateAction<ReleaseLicenseRequest>>
}

const SearchLicenseComponent = ({setLicenseId,setReleaseLicenseId,releaseLicenseInfoRequest}: props) => {
    
    const handlePersonTermChange =  (e: React.ChangeEvent<HTMLInputElement> ) => {    
        // if(setReleaseLicenseId != undefined)
        //     setReleaseLicenseId({...releaseLicenseInfoRequest, LicenseId: Number(e.currentTarget.value)  })
        setLicenseId(Number(e.currentTarget.value));
    }



    return (
    <div className='flex justify-between items-center gap-4 p-8'>

        <label htmlFor="LicenseId" className="font-bold">LicenseID::</label>
        <input onChange={(e) => handlePersonTermChange(e)}  type="text"  id='LicenseId' />
        <Button>
            <IconContext.Provider value={{className: "hover:text-sky-700 transition-all duration-300", size: ""}}>
                <FaCreditCard />
            </IconContext.Provider>
        </Button>

    </div>
)
}

export default SearchLicenseComponent