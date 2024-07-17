import React, { useState } from 'react'
import PersonDetails from '../../Person/PersonDetails'


// export type FindByType = "NationalNo" | "Id";

const AddLDL = () => {
    // const [FindByProp, setFindByProp] = useState<FindByType>("Id")

    const [personId, setPersonId] = useState<number>();
    
    const handlePersonIdChange =  (e: React.ChangeEvent<HTMLInputElement> ) => {        
        if(e.currentTarget.value === "" )
            setPersonId(undefined)
        else
            setPersonId(Number(e.currentTarget.value))
    }

  return (
    <>
        <h1 className='text-sky-700 text-2xl mt-2'>New Local Driving License</h1>
        <div className='flex justify-center items-center gap-2 p-1 relative'>
            <label htmlFor="person-search-property" className="">Find By:</label>
                    <select defaultValue={"ID"} title='personSearchTerm' className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block  p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
                        <option defaultValue={"personId"}>
                            ID
                        </option>
                        <option defaultValue={"NationalNo"}>
                            NationalNo
                        </option>
                    </select>
            <input onChange={(e) => handlePersonIdChange(e) } type="text" id='person-search-property' />
        </div>
        <PersonDetails personIdProp={personId} SearchBy='Id' />
    </>
  )
}

export default AddLDL