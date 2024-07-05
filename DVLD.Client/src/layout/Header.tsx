import * as React from 'react';
import { FaAddressCard } from "react-icons/fa6";
import Pages from '../components/Header/Pages';
import { MdAddToPhotos } from "react-icons/md";
import { FaHouseUser } from "react-icons/fa";
import { TbWorld } from "react-icons/tb";
import { MdOutlineAutorenew } from "react-icons/md";
import { VscReplaceAll } from "react-icons/vsc";
import { IoNewspaper } from "react-icons/io5";
import { FaHandPaper } from "react-icons/fa";
import { AiFillStop } from "react-icons/ai";
import { IoNewspaperSharp } from "react-icons/io5";
import { PiLockOpenFill } from "react-icons/pi";
import { BiSolidDoorOpen } from "react-icons/bi";
import UserSettings from '../components/Header/UserSettings';
// import { useSelector } from 'react-redux';
// import { selectUserData } from '../redux/features/authSlice';

// import { List, ListItem, ListItemText } from '@mui/material';


export type PageType = {
  title: string,
  subMenu: subMenuItem[],
  hasSubMenu: boolean
}


export type subMenuItem = PageType & {
  icon: React.ReactNode
}

function Header() {
    const pages: PageType[] = 
   [
    {
        title: "Applications",
        subMenu : [
          {
            title: "Driving Licenses Services",
            icon :   <FaAddressCard /> ,
            subMenu: [
                  {
                    title: "New Driving License",
                    icon :   <MdAddToPhotos />,
                    subMenu: [
                      {
                        title: "Local License",
                        icon: <FaHouseUser />,
                        subMenu: [],
                        hasSubMenu: false,
                      },
                      {
                        title: "International License",
                        icon: <TbWorld />,
                        subMenu: [],
                        hasSubMenu: false,
                      }
                    ],
                    hasSubMenu: true
                  },
                  {
                    title: "Renew Driving License",
                    icon: <MdOutlineAutorenew />,
                    subMenu: [],
                    hasSubMenu: false,
                  },
                  {
                    title: "License Replacement",
                    icon: <VscReplaceAll />,
                    subMenu: [],
                    hasSubMenu: false,
                  },
                  {
                    title: "Release  License",
                    icon: <BiSolidDoorOpen />,
                    subMenu: [],
                    hasSubMenu: false,
                  },
                  {
                    title: "Retake Test",
                    icon: <IoNewspaper />,
                    subMenu: [],
                    hasSubMenu: false,
                  }
            ],
            hasSubMenu: true
          },
          {
          title: "Manage Applications",
          icon:  <FaAddressCard /> ,
          subMenu: [
            {
              title: "Local Application",
              icon:  <FaHouseUser />,
              subMenu: [],
              hasSubMenu: false,
            },
            {
              title: "International Application",
              icon: <TbWorld />,
              subMenu: [],
              hasSubMenu: false,
            }
          ],
          hasSubMenu: true
          },
          {
            title: "Detain Licenses",
            icon:  <FaHandPaper /> ,
            subMenu: [
              {
                title: "Manage Detain Licenses",
                icon: <IoNewspaperSharp />,
                subMenu: [],
                hasSubMenu: false,
              },
              {
                title: "Detain License",
                icon: <AiFillStop />,
                subMenu: [],
                hasSubMenu: false,
              },
              {
                title: "Release Detain Licenses",
                icon: <PiLockOpenFill />,
                subMenu: [],
                hasSubMenu: false,
              }
            ],
            hasSubMenu: true
          },
          {
            title: "Manage Application Type",
            icon:   <IoNewspaperSharp /> ,
            subMenu: [],
            hasSubMenu: false
          },
          {
              title: "Manage Test Types",
              icon:  <IoNewspaperSharp />,
              subMenu: [],
              hasSubMenu: false
          },
        ],
        hasSubMenu: true
    },
    {
      title: 'People',
      subMenu: [],
      hasSubMenu: false
    },
    {
      title: 'Drivers',
      subMenu: [],
      hasSubMenu: false
    },
    {
      title: 'Users',
      subMenu: [],
      hasSubMenu: false
    }, 
  ]

return (
  <div className='bg-sky-700	flex relative min-h-16  shadow-2xl  z-10  lg	 '>
    <nav className="text-xl min-h-11 bg-inherit flex justify-center items-center container  mx-auto xl:px-24 lg:px-26   md:px-24  sm:px-24   ">
      <div className= " flex-grow"> 
          <Pages pages={pages}/>
      </div>
      <UserSettings />
    </nav>
  </div>
);
}
export default Header;


