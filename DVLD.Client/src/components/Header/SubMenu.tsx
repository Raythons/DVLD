import React, { MouseEvent } from 'react'
import { subMenuItem } from '../../layout/Header'
import { MdOutlineKeyboardArrowRight } from 'react-icons/md'

type props = {
  subMenu: subMenuItem[]

}
const SubMenu = ({subMenu} : props) => {

  const handleMouseEnter = (e: MouseEvent<HTMLLIElement>) => {
    if(e.currentTarget.lastElementChild?.tagName.toLocaleLowerCase() === "menu"){
      e.currentTarget.lastElementChild?.classList.remove("hidden")
      e.currentTarget.lastElementChild?.classList.add("flex")
    }

   
    // setShowSubMenu(!showSubMenu);
  };

  const handleMouseLeave = (e: MouseEvent<HTMLLIElement>) => {
    if(e.currentTarget.lastElementChild?.tagName.toLocaleLowerCase() === "menu"){
      e.currentTarget.lastElementChild?.classList.remove("flex")
      e.currentTarget.lastElementChild?.classList.add("hidden")
    }
    // setShowSubMenu(showSubMenu);
  };
  return (
    <menu className=" absolute -right-[244px]   hidden  top-0 rounded-md   bg-slate-50  flex-col  border-solid border-2">
            {
                subMenu.map((menuItem) => (
                    <li 
                      onMouseEnter={handleMouseEnter}
                      onMouseLeave={handleMouseLeave}
                      onClick={(e) => menuItem.onClick? menuItem.onClick(e) : null}
                      key={menuItem.title} className={`
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
                          <></>}

                          {menuItem.hasSubMenu ? 
                            <SubMenu subMenu = {menuItem.subMenu} />
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

export default SubMenu