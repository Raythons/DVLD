import FilterBy from "../layout/FilterBy"
import AllPeople from "../layout/people/AllPeople"

export const People = () => {
  return (
    <div className='flex justify-center items-center mx-auto container 
            xl:px-26 lg:px-26   md:px-26  sm:px-26'>
      <div className=" flex justify-start items-center  flex-col  rounded-lg  h-[78vh]
              min-h[80%] bg-slate-200  w-[80%] container ">
        <div>
            <i>
                icon
            </i>
            <div>
              <FilterBy />
              <button type="button" title="Add Person">
                  add Person
              </button>
            </div>
        </div>
        <AllPeople />
        <div>
            <p> Records</p>
            <button type="button" title="close"> close</button>
        </div>
      </div>
    </div>

  )
}
