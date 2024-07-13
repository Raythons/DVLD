import { ReactNode, useState } from 'react'
import { useSelector } from 'react-redux';
import { selectUserData } from '../../redux/Slices/authSlice';
import { subMenuItem } from '../../layout/Header';
import { PiUserCircleDashedFill } from "react-icons/pi";
import { CgLogOut } from "react-icons/cg";
import { RiLockPasswordFill } from "react-icons/ri";
import { MouseEvent } from "react"; 


type UserSettings = {
  title: string,
  subMenu: subMenuItem[],
  icon : ReactNode,
  hasSubMenu: boolean,
}
enum  ClassListBehavior {
  RemoveFirst,
  AddFirst
}
const UserSettings = () => {
  const user = useSelector(selectUserData);
  const [showUserSettings , setShowUserSettings] = useState(false)

  const handleUserSettingClick = () => {
    setShowUserSettings(!showUserSettings);
  }
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
  const settings: UserSettings[] = [
    {
      title: "Current User",
      subMenu : [],
      hasSubMenu: false,
      icon: < PiUserCircleDashedFill />
    } ,
    {
      title: "Change Password",
      subMenu : [],
      hasSubMenu: false,
      icon: < RiLockPasswordFill />
    } ,
    {
      title: "Log Out",
      subMenu : [],
      hasSubMenu: false,
      icon: < CgLogOut />
    } 
  ]
  


  return (
    <div title='user-settings'
    onClick={handleUserSettingClick}  
    className='flex relative justify-center cursor-pointer items-center  w-16  h-14  rounded-full  border-solid transition duration-300 border-white hover:border-blue-500   border-2'>
        <img className= "rounded-full  w-full h-full" src={user.Image} alt="" />
      { showUserSettings && <menu className="absolute main-menu  rounded-md top-12  bg-slate-50 flex flex-col  border-solid border-2">
            {
                settings.map((settingItem) => (
                    <li key={settingItem.title}
                      onMouseEnter={handleMouseEnter}
                      onMouseLeave={handleMouseLeave}
                      className={`
                      px-1 py-1 text-blue-600 50 flex items-center transition duration-300 
                      gap-1  border-solid border-b  border-cyan-400 flex-nowrap hover:bg-blue-500 hover:text-white 
                      min-w-full`}>
                        {settingItem.icon}
                        <button type="button" className="text-lg  min-w-52  justify-self-start">{settingItem.title}</button>
                    </li>
                    
                ))
            }
    </menu>}
    </div>
  )
}

export default UserSettings