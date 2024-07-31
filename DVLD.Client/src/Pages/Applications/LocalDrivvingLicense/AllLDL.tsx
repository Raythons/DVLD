import { Spinner } from "flowbite-react";
import SingleDLApplication from "../../../components/Applications/localDrivingLicenses/SingleDLApplication"
import { GetAllLDLAppQueryParams, useGetAllLDLApplicationsQuery } from "../../../redux/api/Applications/LDLApplicationsApi"

const AllLDL = () => {
    
    const queryParams: GetAllLDLAppQueryParams = {Page: 1}
    const {data : ApplicationsList, isLoading} = useGetAllLDLApplicationsQuery(queryParams);

  return (

    
    <div className='flex  flex-col  justify-start items-center gap-2 p-4  overflow-y-scroll 
          bg-slate-100 rounded-md w-[90%]  relative overflow-hidden '>

      {
        isLoading ? <Spinner size = "xl" className="" /> 
        :
        ApplicationsList?.map((application) => (
          <SingleDLApplication 
            key={application.Id}
            LDLAppId={application.Id}
            DrivingClass={application.ClassName}
            NationalNo={application.NationalNo}
            FullName={application.FullName}
            ApplicationDate = {application.CreatedAt}
            PassedTests = {application.PassedTestCount}
            Status ={application.Status}
          />
        ))
      }
    </div>
  )
}

export default AllLDL