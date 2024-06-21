import { RouterProvider, createBrowserRouter } from 'react-router-dom'
import './css/App.css'
import SignIn from './Pages/SignIn'
import Layout from './layout/Layout'
import { People } from './Pages/People'
import Drivers from './Pages/Drivers'
import Users from './Pages/Users'
import PersonDetails from './Pages/Person/PersonDetails'
import EditPerson from './Pages/Person/EditPerson'
import AddNewPerson from './Pages/Person/AddNewPerson'

const router = createBrowserRouter([
  {
    index: true,
    path: "/",
    element: <SignIn />,
  },
  {
    element: <Layout />,
    path: "/home",
    children: [
      {
      index: true,
      path: "Applications",
      element: <div>Iam Application uwu</div>
      },
      {
        path: "People",
        children:
        [
          {
            index: true,
            element: <People />,
          },
          {
            path: "Details/:personId",
            element: <PersonDetails /> 
          },
          {
            path: "Edit/:personId",
            element: <EditPerson /> 
          },
          {
            path: "Add/",
            element: <AddNewPerson /> 
          }
        ]
      },
      {
        path: "Drivers",
        element: <Drivers />
      },
      {
        path: "Users",
        element: <Users />
      }
    ]
  }
])

function App() {
  return (
    <>
        <RouterProvider router={router} />
    </>
  )
}

export default App
