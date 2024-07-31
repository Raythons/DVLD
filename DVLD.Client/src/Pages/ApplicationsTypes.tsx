import { useGetAllApplicationsTypeQuery } from '../redux/api/Applications/ApplicationsTypeApi'
import { Spinner } from 'flowbite-react'

const ApplicationsTypes = () => {   

    const {data: ApplicationsTypes, isLoading }= useGetAllApplicationsTypeQuery({})
    return (
        <div  className=" flex flex-col items-center justify-center  w-[100%] h-[100%]">
            {
                isLoading ? <Spinner size={"xl"} />
                :
                <div className='flex  flex-col  justify-start items-center gap-2 p-4  overflow-y-scroll 
            bg-slate-100 rounded-md w-[90%]  relative overflow-hidden '>
                {
                    ApplicationsTypes?.map((appType) => {
                        return (
                            <div key={appType.ApplicationTypeId} className='flex   max-h-full  w-full justify-between items-center p-2 
                            rounded-md bg-gray-700  text-slate-50    transition-all duration-300 hover:p-3'>
                                    <div className=' flex justify-center items-center p-1'>
                                    <p className=' font-bold  mr-1'> 
                                    ID: 
                                    </p>
                                    <p className='p-1'>
                                    {appType.ApplicationTypeId}
                                    </p>
                                </div>
                                <div className=' flex justify-center items-center p-1'>
                                    <p className=' font-bold  mr-1'> 
                                    Title:  
                                    </p>
                                    <p className='p-1'>
                                    {appType.ApplicationTypeTitle}
                                    </p>
                                </div>
                                <div className=' flex justify-center items-center p-1'>
                                    <p className=' font-bold mr-1  '> 
                                    Fees: 
                                    </p>
                                    <p className='p-1 '>
                                    {appType.ApplicationTypeFees}
                                    </p>
                                </div>
                            </div>
                        )
                    })
                }
                </div>
            }
                
        </div>

    )
}

export default ApplicationsTypes