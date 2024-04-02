using DVLD.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Users.Commands.CreateUser
{
    public class CreateUserValidator :AbstractValidator<CreateUserCommand> 
    {
        
         public CreateUserValidator()
        {
            RuleFor(user => user.UserName)
                .NotEmpty()
                .NotNull();


            RuleFor(user => user.Password)
                .NotEmpty().WithMessage("Password Required")
                .NotNull()
                .MinimumLength(12).WithMessage("Minimmum Length is 12");
        }


    }
}
