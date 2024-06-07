using DLVD.App.extensions;
using DLVD.App.Features.Persons.Commands.CreatePerson;
using DLVD.App.Features.Persons.Commands.DeletePerson;
using DLVD.App.Features.Persons.Commands.UpdatePerson;
using DLVD.App.Features.TestAppointments.Commands.CreateTestAppointment;
using DLVD.App.Features.Users.Commands.CreateUser;
using DLVD.App.Features.Users.Commands.UpdateUser;
using FluentResults;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace DLVD.App
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddAppServices (this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddMediatR(cfg
                => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())
                .AddValidation<CreatePersonCommand, Result<bool>>()
                .AddValidation<UpdatePersonCommand, Result<bool>>()
                //.AddValidation<DeletePersonCommand, Result<bool>>()
                // Start Of User Registeration
                .AddValidation<CreateUserCommand, Result<bool>>()
                .AddValidation<UpdateUserCommand, Result<bool>>()
                .AddValidation<CreateTestAppointmentCommand, Result<bool>>()
                //.AddValidation<DeleteUserCommand, Result<bool>>()
                // 
                );

            return services ;

        }
    }
}
