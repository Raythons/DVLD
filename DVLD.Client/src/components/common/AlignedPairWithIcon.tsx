import React, { ReactNode } from 'react'
import { IconContext } from 'react-icons'


type props = {
  fieldName: string,
  icon: ReactNode,
  value: ReactNode
}

const AlignedPairWithIcon = ({fieldName, icon, value} : props) => {
  
  return (
    <div className='flex  items-center gap-1 p-1 w-full'>
      <div className='flex  justify-center items-center gap-1    pt-1'>
          <p className='font-bold'>{fieldName}:</p>
          <IconContext.Provider  value={{className: "text-sky-700", size: "24" }}>
          {icon}
          </IconContext.Provider>
      </div>
      <span className=' text-lg'>{value}</span>
  </div>
  )
}

export default AlignedPairWithIcon