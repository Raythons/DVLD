import { useNavigate } from 'react-router-dom'
import { BaseRoute } from '../../utils/BaseRoutes'

type props  = {
    goTo: string,
    Id: number
}
const EditButton = ( {goTo, Id} : props) => {
    const navigate = useNavigate();
  return (
    <button type="button"  disabled = {Id === 0 || Id === undefined}
        onClick={() =>  (navigate(`/${BaseRoute}/${goTo}/Edit/${Id}`))}
          className="text-white   bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">
        Edit
    </button>
  )
}

export default EditButton