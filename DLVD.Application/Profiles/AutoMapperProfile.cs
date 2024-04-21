using AutoMapper;
using DLVD.App.extensions;
using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Applications.Queries.GetApplication;
using DLVD.App.Features.Applications.Queries.GetApplicationsList;
using DLVD.App.Features.Common.SharedDtos;
using DLVD.App.Features.Drivers.Command.CreateDriver;
using DLVD.App.Features.LicenseClasses.Query.GetAllLicenseClasses;
using DLVD.App.Features.Licenses.Command.CreateLicense;
using DLVD.App.Features.Licenses.Query;
using DLVD.App.Features.LocalDrivingLicense.Command.CreateLocalDrivvingLicense;
using DLVD.App.Features.LocalDrivingLicense.Query.GetLocalDriverLicense;
using DLVD.App.Features.Persons.Commands.CreatePerson;
using DLVD.App.Features.Persons.Commands.UpdatePerson;
using DLVD.App.Features.Persons.Queires.GetPersonsList;
using DLVD.App.Features.TestAppointments.Commands.CreateTestAppointment;
using DLVD.App.Features.Tests.Command.CreateTestCommand;
using DLVD.App.Features.Tests.Query.GetTest;
using DLVD.App.Features.Users.Commands.AuthenticateUserCommand;
using DLVD.App.Features.Users.Commands.CreateUser;
using DLVD.App.Features.Users.Commands.UpdateUser;
using DLVD.App.Features.Users.Queires.GetUserQuery;
using DVLD.Domain.Entities;


namespace DLVD.App.Profiles
{
    public class AutoMapperProfile: Profile
    {

        public AutoMapperProfile() 
        {

            // License
            CreateMap<CreateLicenseCommand, License>();

            CreateMap<GetLicenseDto, License>().ReverseMap();
            // Driver
            CreateMap<CreateDriverCommand, Driver>();
            CreateMap<Driver, GetDriverDto>();

            // Test 
            CreateMap<Test, GetTestDto>().ReverseMap();
            CreateMap<Test, CreateTestCommand>().ReverseMap();
            //TestAppointments 
            CreateMap<TestAppointment, CreateTestAppointmentCommand>().ReverseMap();

            //LocalDrivvingLicenseAppliciation
            CreateMap<LocalDrivingLicenseApplication, CreateLocalDrivingLicenseCommand>()
                .ReverseMap();

            CreateMap<GetLocalDrivvingLicenseDto, LocalDrivingLicenseApplication>()
                .ReverseMap();
            // Application TO Dto 
            CreateMap<Application, GetApplicationDto>()
                .ForMember
                    (
                        dest => dest.CreatedByUser,
                        opts => opts.MapFrom
                                (
                                   src => src.User.UserName
                                )
                    )               
                    .ReverseMap();

            CreateMap<Application, GetApplicationListDto>()
                .ForMember
                    (
                        dest => dest.FullName,
                        opts => opts.MapFrom
                                (
                                   src =>
                                   $"{src.Person.FirstName} {src.Person.SecondName}" +
                                   $" {src.Person.ThirdName} {src.Person.LastName}"
                                )
                    )
                    .ReverseMap();

            // Person To DTO
            CreateMap<Person, GetPersonsListDto>()
                 .ForMember
                     (
                            dest => dest.FullName,
                            opts => opts.MapFrom
                                (
                                src => src.FirstName + " " + src.SecondName
                                + " " + src.ThirdName + " " + src.LastName
                                )
                     )
                 .ForMember
                     (
                        dest => dest.Age,
                        opts => opts.MapFrom
                            (
                                src => src.BirthDate.CalculateAge()
                            )
                     )
                 .ReverseMap();


            CreateMap<Person, GetPersonDetailsDto>()
                .ForMember(
                            dest => dest.FullName ,
                            opts => opts.MapFrom
                                (
                                src => src.FirstName + " " + src.SecondName
                                + " " + src.ThirdName + " "+ src.LastName
                                )
                           )
                .ForMember
                     (
                        dest => dest.Age,
                        opts => opts.MapFrom
                            (
                                src => src.BirthDate.CalculateAge()
                            )
                     )
                .ReverseMap();

            // DTO TO Person
            CreateMap<CreatePersonCommand, Person>()
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ForMember(dest => dest.Driver, opt => opt.Ignore())
                .ForMember(dest => dest.Applications, opt => opt.Ignore());


            CreateMap<UpdatePersonCommand, Person>()
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ForMember(dest => dest.Driver, opt => opt.Ignore())
                .ForMember(dest => dest.Applications, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.PersonId));

            // User To DTO
            CreateMap<User, GetUserDto>().ReverseMap();

            CreateMap<User, AuthenticateUserDto>().ReverseMap();
              

            CreateMap<CreateUserCommand, User>()
                .ForMember(
                        dest => dest.IsActive,
                        src => src.MapFrom(src => true)
                        );

            CreateMap<UpdateUserCommand, User>().ReverseMap();


            // Licenses Class Dto
            CreateMap<LicenseClass, LicenseClassDto>().ReverseMap();

            // Application ClassDto
            CreateMap<CreateApplicationCommand, Application>().ReverseMap();

            // Test Appointments
            CreateMap<CreateTestAppointmentCommand, Application>().ReverseMap();

                    
        }
    }
}


//CreateMap<CreateDriverAchivemntsRequest, Achivments>()
//               .ForMember(
//                   dest => dest.RaceWins,
//                   opts => opts.MapFrom(src => src.Wins)
//               )
//               .ForMember(
//                   dest => dest.status,
//                   opts => opts.MapFrom(src => 1)
//               )
//               .ForMember(
//                   dest => dest.AddedDate,
//                   opts => opts.MapFrom(src => DateTime.UtcNow)
//               )
//               .ForMember(
//                   dest => dest.UpdatedDate,
//                   opts => opts.MapFrom(src => DateTime.UtcNow)
//               );



//CreateMap<UpdateDriverAchivemntsRequest, Achivments>()
//    .ForMember(
//        dest => dest.RaceWins,
//        opts => opts.MapFrom(src => src.Wins)
//    )
//    .ForMember(
//        dest => dest.UpdatedDate,
//        opts => opts.MapFrom(src => DateTime.UtcNow)
//    );



//CreateMap<CreateDriverRequest, Driver>()
//    .ForMember(
//        dest => dest.status,
//        opts => opts.MapFrom(src => 1)
//    )
//    .ForMember(
//        dest => dest.AddedDate,
//        opts => opts.MapFrom(src => DateTime.UtcNow)
//    )
//    .ForMember(
//        dest => dest.UpdatedDate,
//        opts => opts.MapFrom(src => DateTime.UtcNow)
//    )
//    .ForMember(
//        dest => dest.DateOfBirth,
//        opts => opts.MapFrom(src => src.DateOfBirth)
//    )
//    ;
