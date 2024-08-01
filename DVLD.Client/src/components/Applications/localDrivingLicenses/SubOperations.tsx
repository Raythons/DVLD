import {MouseEvent} from 'react'
import { AppOperations } from './LDLAppOperations'
import { MdOutlineKeyboardArrowRight } from 'react-icons/md'
import currentTestType from '../../../enums/currentTestType'
import { Button } from 'flowbite-react'


type props = {
    operations: AppOperations[]
    passedTests?: number
}

const SubOperations = ({operations, passedTests} : props) => {

  const handleMouseEnter = (e: MouseEvent<HTMLLIElement>) => {
    if(e.currentTarget.lastElementChild?.tagName.toLocaleLowerCase() === "menu"){
      e.currentTarget.lastElementChild?.classList.remove("hidden")
      e.currentTarget.lastElementChild?.classList.add("flex")
    }
  };

  const handleMouseLeave = (e: MouseEvent<HTMLLIElement>) => {
    if(e.currentTarget.lastElementChild?.tagName.toLocaleLowerCase() === "menu"){
      e.currentTarget.lastElementChild?.classList.remove("flex")
      e.currentTarget.lastElementChild?.classList.add("hidden")
    }
  };

  console.log(passedTests);
  
  return (
    <menu className=" absolute right-[154px] right-  hidden  top-[50%] rounded-md   bg-slate-50  flex-col  border-solid border-2">
            {
                operations.map((operation) => (
                    <li 
                      onMouseEnter={handleMouseEnter}
                      onMouseLeave={handleMouseLeave}
                      onClick={(e) => operation.clickHandler ? operation.clickHandler(e) : null}
                      key={operation.OperationName} className={`
                      px-1 py-1 text-blue-600 50 flex items-center transition duration-300 
                      gap-1  border-solid border-b  border-cyan-400 flex-nowrap hover:bg-blue-500 hover:text-white 
                      min-w-full`}>
                        {operation.OperationIcon}
                        <Button color={"blue"}  disabled = {currentTestType[passedTests ?? 1] !== operation.OperationName.split(" ").slice(-2).join("")}
                        type="button" className="text-lg  min-w-52  justify-self-start transition duration-300 ">{operation.OperationName}</Button>
                        {operation.subOperations ? 
                          <button type="button" title={operation.OperationName}> 
                          < MdOutlineKeyboardArrowRight/> 
                          </button> 
                          :
                          <></>}
                          {operation.subOperations ? 
                            <SubOperations operations = {operation.subOperations} />
                            : 
                            <></>  
                        }
                    </li>
                ))
            }
            
    </menu>
    // <div className=' absolute bg-black   -right-5'>
    //     {subMenu.map(s => <p  key={s.title}>{s.title}</p>)}
    //     ss
    //   </div>
  )
}

export default SubOperations