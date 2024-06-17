import { RouterProvider, createBrowserRouter } from 'react-router-dom'
import './css/App.css'
import SignIn from './Pages/SignIn'
import Layout from './layout/Layout'
import { People } from './Pages/People'
import Drivers from './Pages/Drivers'
import Users from './Pages/Users'

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
        element: <People />
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
