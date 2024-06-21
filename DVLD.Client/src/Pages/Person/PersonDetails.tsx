import React from 'react'
import { useLocation, useParams } from 'react-router-dom'

const PersonDetails = () => {
    const {personId} = useParams();

    const paramsss = useLocation();
    console.log(paramsss);
    console.log("deails worked")
    
  return (
    <div> {personId}    asddddddddddddddddddd</div>
  )
}

export default PersonDetails