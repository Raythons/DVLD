import { subMenuItem } from "./Header"
import { MdOutlineKeyboardArrowRight } from "react-icons/md";
import { MouseEvent } from "react"; 
import SubMenu from "./SubMenu";


type props = {
    menu: subMenuItem[],
}

enum  ClassListBehavior {
  RemoveFirst,
  AddFirst
}

const MainMenu = ( {menu} : props) => {
  // const [showSubMenu, setShowSubMenu] = useState(false);

  const handleClassBehavior = (behavior: ClassListBehavior ,element: HTMLElement) => {
        if(behavior == ClassListBehavior.AddFirst) {
        element.lastElementChild?.classList.add("flex")
        element.lastElementChild?.classList.remove("hidden")
        }
        else 
        {
          element.lastElementChild?.classList.remove("flex")
          element.lastElementChild?.classList.add("hidden")
        }
  }

  const isLastCHildMenu = (target: HTMLElement): boolean =>{
      return target.lastElementChild?.tagName.toLocaleLowerCase() === "menu"
  } 

  const handleMouseEnter = (e: MouseEvent<HTMLLIElement>) => {
    if(isLastCHildMenu(e.currentTarget))
        handleClassBehavior(ClassListBehavior.AddFirst , e.currentTarget)
  };

  const handleMouseLeave = (e: MouseEvent<HTMLLIElement>) => {
    if(isLastCHildMenu(e.currentTarget))
      handleClassBehavior(ClassListBehavior.RemoveFirst , e.currentTarget)
  };

  const handleMenuMouseLeave = (e: MouseEvent) => {
    e.currentTarget.classList.remove("flex")
    e.currentTarget.classList.add("hidden")
    // handleClassBehavior(ClassListBehavior.RemoveFirst,  e.currentTarget)
  }

  return (
      <menu onMouseLeave={handleMenuMouseLeave} className=" absolute main-menu  transition  duration-500  rounded-md top-12  bg-slate-50  hidden flex-col  border-solid border-2">
            {
                menu.map((menuItem) => (
                    <li key={menuItem.title}
                      onMouseEnter={handleMouseEnter}
                      onMouseLeave={handleMouseLeave}
                      className={`
                      px-1 py-1 text-blue-600 50 flex items-center transition duration-300 
                      gap-1  border-solid border-b  border-cyan-400 flex-nowrap hover:bg-blue-500 hover:text-white 
                      min-w-full`}>
                        {menuItem.icon}
                        <button type="button" className="text-lg  min-w-52  justify-self-start">{menuItem.title}</button>
                        {menuItem.hasSubMenu ? 
                          <button type="button" title={menuItem.title}> 
                          < MdOutlineKeyboardArrowRight/> 
                          </button> 
                          :
                          <></>
                          }
                          {menuItem.hasSubMenu ? 
                            <SubMenu subMenu = {menuItem.subMenu} />
                            : 
                            <></>  
                          }
                    </li>
                    
                ))
            }
    </menu>
  )
}

export default MainMenu