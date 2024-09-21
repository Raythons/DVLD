import { RouterProvider, createBrowserRouter } from 'react-router-dom'
import './css/App.css'
import SignIn from './Pages/SignIn'
import Layout from './layout/Layout'
import { People } from './layout/People'
import Drivers from './Pages/Drivers'
import Users from './Pages/Users'
import PersonDetails from './Pages/Person/PersonDetails'
import EditPerson from './Pages/Person/EditPerson'
import AddPerson from './Pages/Person/AddPerson'
import WhiteContainer from './layout/WhiteContainer'
import ApplicationsTypes from './Pages/ApplicationsTypes'
import TestTypes from './Pages/TestTypes'
import { LDLApplications } from './layout/LDLApplications'
import AddLDL from './Pages/Applications/LocalDrivvingLicense/AddLDL'
import ScheduleTest from './components/Applications/TestAppointments/ScheduleTest'
import IssueInternationalLicense from './components/Applications/internationalDrivingLicenses/IssueInternationalLicense'
import RenewLicense from './Pages/License/RenewLicense'
import ReplaceLicense from './Pages/License/ReplaceLicense'
import DetainLicense from './Pages/License/DetainLicense'

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
        element: <WhiteContainer/> ,
        children:
        [
          {
            index: true,
            element: <People />,
          },
          {
            path: "Details/:personId",
            element: <PersonDetails SearchBy='Id'/> 
          },
          {
            path: "Edit/:personId",
            element: <EditPerson /> 
          },
          {
            path: "Add/",
            element: <AddPerson /> 
          }
        ]
      },
      {
        path: "Applications/localDrivingLicenses",
        element: <WhiteContainer/> ,
        children:
        [
          {
            index: true,  
            element: <LDLApplications />,  
          },
          {
            path: "Add/",
            element: < AddLDL />
          },
          {
            path: "Re-new/",
            element: < RenewLicense />
          },
          {
            path: "Replace/",
            element: < ReplaceLicense />
          },
          {
            path: "Detain/",
            element: < DetainLicense />
          },
          {
            path: "Detain/",
            element: < ReleaseDetainedLicense />
          },
          {
            path: "Tests/Add/:LDLApplicationID",
            element :  <ScheduleTest />
          }
        ]
      },
      {
        path: "Applications/InternationalDrivingLicenses",
        element: <WhiteContainer/> ,
        children:
        [
          {
            index: true,  
            element: <LDLApplications />,  
          },
          {
            path: "Issue/",
            element: < IssueInternationalLicense />
          },
        ]
      },
      {
        path: "ApplicationTypes",
        element: <WhiteContainer/> ,
        children:
        [
          {
            index: true,  
            element: <ApplicationsTypes />,  
          }
        ]
      },
      {
        path: "TestTypes",
        element: <WhiteContainer/> ,
        children:
        [
          {
            index: true,  
            element: <TestTypes />,  
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
