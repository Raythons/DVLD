# Local Driving License Management  Department
  A Project To Manage  The Proccess Of Issuing a License 

  ## Description
  This application streamlines the process of issuing, renewing, detaining, and releasing driving licenses within a local driving license management department.
  It empowers multiple employees to work collaboratively on license-related tasks, ensuring efficient and accurate operations.
  
  ## Getting Started
  ### Dependencies
  Open The DVLD.CLient File and  install packages using 
  ``` npm  i ```
  Then Restore All The c# Packages  using
  ``` dotnet restore ```
  ### Executing program
  * Create The Initial Migration From Ef core using These command:
      ```
        dotnet ef migrations Add "Initial Migation" --project  C:\<Full_Path_To_Project>\DVLD\DVLD.Infrastructure --startup-project C:<Full_Path_To_Project>\DVLD\DVLD.API
     ```
  * Now Create The DataBase using:
      ```
         dotnet ef database Add C:\<Full_Path_To_Project>\DVLD\DVLD.Infrastructure --startup-project C:<Full_Path_To_Project>\DVLD\DVLD.API
       ```
  * Now Change The Coonection string And The Password  in The Json.Setting In Api Project To Match Your Connection string And Password
  * Now You Can run The api Project :) using
    ``` dotnet run ```

    


    
