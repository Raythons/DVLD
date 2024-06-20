import { GetAllPeopleQueryParams, useGetAllQuery } from '../../redux/api/peopleApi'
import SinglePerson from './SinglePerson'

const AllPeople = () => {

  const queryParams: GetAllPeopleQueryParams = {Page: 1}
  const {data: PersonList} = useGetAllQuery(queryParams)



  return (
    <div className='flex  flex-col  justify-start items-center gap-2 p-4  overflow-y-scroll 
          bg-slate-100 rounded-md w-[90%]  relative overflow-hidden '>
      {
        PersonList?.map((person) => (
          <SinglePerson 
            key={person.Id}
            Id={person.Id}
            FullName={person.FullName}
            Age={person.Age}
            Gender={person.Gender}
          />
        ))
      }
    </div>
  )
}

export default AllPeople