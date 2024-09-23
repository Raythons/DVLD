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

  Here are some screenshots showcasing the Local Driving License Management Department project.
  [Login](https://drive.google.com/file/d/17crNmCzVRyDeFvEYlPDeasRAFKjortM8/view?usp=sharing)
  ![People](https://github.com/user-attachments/assets/57391ab9-637f-48be-a9c4-d6a1ba57fd46)
  ![LDL APPLICATIONS ](https://github.com/user-attachments/assets/0596fc5c-9a1a-4e56-9d31-d4bf6c456d28)
  ![PEOPLE](https://github.com/user-attachments/assets/fbfcfabf-ad21-4386-a1ea-b2342bb11f95)
  ![Edit People](https://github.com/user-attachments/assets/95008a35-6fb9-465c-88b1-83b00297cd4f)

    


    
