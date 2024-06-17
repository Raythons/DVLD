import { Link } from "react-router-dom"
import { PageType } from "./Header"
import { MouseEvent } from "react"
import MainMenu from "./MainMenu"

type props  = {
  pages: PageType[]
}

const Pages = ({pages} : props) => {
   

  const selectElements = (elementClass:string, target: HTMLElement) : Element[] => {
      const Elements = Array.from(
        target.parentElement?.querySelectorAll(`.${elementClass}`) || []
      );
      return Elements
  }

  const handlePageClick = (e: MouseEvent<HTMLElement>) => {
    const pageElements = selectElements ("page" , e.currentTarget)

    const menuElements = selectElements ("main-menu" , e.currentTarget)

    menuElements.forEach((element) => {
      element.classList.remove("flex");
      element.classList.add("hidden")
    });


    pageElements.forEach((element) => {
      element.classList.remove("selected_page");
    });

    const firstChild = e.currentTarget.firstElementChild;

    if (firstChild && firstChild.nodeName === "MENU") {
      if(firstChild.classList.contains("flex")){
        firstChild.classList.remove("flex");
        firstChild.classList.add("hidden");
      } else {
        firstChild.classList.remove("hidden");
        firstChild.classList.add("flex");
      }
    }

    e.currentTarget.classList.add("selected_page")
  }

  return (
    <ul className="flex items-center gap-3 ">
        {pages.map((page) => (
          <li onClick={handlePageClick} 
          key={page.title} 
          className={`${page.hasSubMenu ? "relative" : ""} page  rounded-md transition duration-300 hover:bg-blue-500  py-1 px-1  text-stone-50`}>
            {page.hasSubMenu ?  <MainMenu menu ={page.subMenu}  /> : <></> }
            <Link to={page.title}>{page.title}</Link>
          </li>
        ))}
    </ul>
  )
}

export default Pages