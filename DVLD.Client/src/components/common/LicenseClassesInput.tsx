import React from 'react'
import { useGetAllLicensesClassesQuery } from '../../redux/api/LicensesClassesApi'
import { Spinner } from 'flowbite-react';


const LicenseClassesInput = () => {

    const {data: LicenseClassesList, isSuccess, isLoading} = useGetAllLicensesClassesQuery(undefined);
    
    return (
    <>
        <label htmlFor={"LicenseClasses"} className="font-medium whitespace-nowrap pr-2">LicenseClasses:</label>
        <div className='flex justify-center items-center w-[100%]'>
            {
                isLoading
                ? <Spinner  size={"sm"}/> 
                :
                <select  id={"LicenseClasses"} title= "countries"  className=" w-[80%] bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-1.5    dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
                {
                        isSuccess &&   LicenseClassesList?.map((LicenseClass) => {
                            return (
                                <option 
                                    defaultChecked={LicenseClass.Id === 1}
                                    key={LicenseClass.Id}
                                    defaultValue={LicenseClass.Id}
                                    value={LicenseClass.Id}
                                    >
                                    class {LicenseClass.Id} - {LicenseClass.ClassName}
                                </option>
                            )
                        })
                }
                </select>
            }
        </div>
    </>

)
}

export default LicenseClassesInput