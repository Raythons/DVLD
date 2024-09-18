import React, { useState } from 'react'
import SearchLicenseComponent from '../../Liccense/SearchLicenseComponent';
import GetLicenseInfo from '../../Liccense/GetLicenseInfo';

const IssueInternationalLicense = () => {
    const [LicenseID, setLicenseID] = useState<number>(0);
    
    console.log(LicenseID);
    
    return (

    <div  className=" flex flex-col items-center justify-center  w-[100%]">
        <SearchLicenseComponent setLicenseId={setLicenseID} />

        <GetLicenseInfo LicenseId={LicenseID} />
    </div>
  )
}

export default IssueInternationalLicense