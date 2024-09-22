import React from 'react'
import { useGetAllDriversQuery } from '../../redux/api/DrviersApi'
import SingleDriver from './SingleDriver'
import { GetAllPeopleQueryParams } from '../../redux/api/peopleApi'

const AllDrivers = () => {
  
    const queryParams: GetAllPeopleQueryParams = {Page: 1}
    const {data: DriverList} = useGetAllDriversQuery(queryParams)
        
        return (
        <div className='flex  flex-col  justify-start items-center gap-2 p-4  overflow-y-scroll 
                bg-slate-100 rounded-md w-[90%]  relative overflow-hidden '>
            {
            DriverList?.map((driver) => (
                <SingleDriver 
                key={driver.DriverId}
                DriverId={driver.DriverId}
                FullName={driver.FullName}
                PersonId={driver.PersonId}
                CreatedAt={driver.CreatedAt}
                NumberOfActiveLicenses= {driver.NumberOfActiveLicenses}
                />
            ))
        }
        </div>
    )
}

export default AllDrivers


