import React, { useState } from 'react'
import PersonDetails from '../../Person/PersonDetails'
import { Button } from 'flowbite-react';
import CreateLDLApplication from './CreateLDLApplication';
import { SearchBy } from '../../../hooks/useGetPersonDetails';

// export type FindByType = "NationalNo" | "Id";

const AddLDL = () => {
    // const [FindByProp, setFindByProp] = useState<FindByType>("Id")
    const [disableNext, setDisableNest] = useState<boolean>(true);

    const [personTerm, serPersonSearchTerm] = useState<string>();
    const [searchBy, setSearchBy] = useState<SearchBy>("Id");
    const [showCreateLdlApp, setShowCreateLdlApp]  = useState<boolean>(false);
    const [personId, setPersonId] = useState<number>();

    const handlePersonTermChange =  (e: React.ChangeEvent<HTMLInputElement> ) => {        
        if(e.currentTarget.value === "" )
            serPersonSearchTerm(undefined)
        else
            serPersonSearchTerm(e.currentTarget.value)
    }

    
    return (
    <>
        <h1 className='text-sky-700 text-2xl mt-2'>New Local Driving License</h1>
        <div className='flex justify-center items-center gap-2 p-1 relative'>
            <label htmlFor="person-search-property" className="">Find By:</label>
                    <select onChange={(e) => setSearchBy(e.currentTarget.value as SearchBy)} defaultValue={searchBy} title='personSearchTerm' className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block  p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
                        <option defaultValue={"Id"}>
                            Id
                        </option>
                        <option defaultValue={"NationalNo"}>
                            NationalNo
                        </option>
                    </select>
            <input onChange={(e) => handlePersonTermChange(e)}  type="text" id='person-search-property' />
            <Button color="blue" disabled = {disableNext}  onClick = {() => setShowCreateLdlApp(!showCreateLdlApp)} > {showCreateLdlApp ? "Back" : "Next"} </Button>
        </div>
        {
            !showCreateLdlApp 
            ? 
            <PersonDetails personTermProp={personTerm} 
            setPersonId = {setPersonId} setDisableNext={setDisableNest}  SearchBy={searchBy} />
            :
            <CreateLDLApplication  personId={personId} />
        }
    </>
    )
}

export default AddLDL