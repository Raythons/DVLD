import React from 'react'
import { useSelector } from 'react-redux';
import { selectUserData } from '../redux/features/authSlice';

const UserSettings = () => {
  const user = useSelector(selectUserData);

  return (
    <div className='rounded-full'>
        <img src={user.Image} alt="" />
    </div>
  )
}

export default UserSettings