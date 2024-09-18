import { Button } from 'flowbite-react';
import React from 'react'
import { IconContext } from 'react-icons';
import { FaCreditCard } from "react-icons/fa";


type props = {
    setLicenseId: React.Dispatch<React.SetStateAction<number>>
}

const SearchLicenseComponent = ({setLicenseId}: props) => {
    
    const handlePersonTermChange =  (e: React.ChangeEvent<HTMLInputElement> ) => {        
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