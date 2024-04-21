using DVLD.Domain.Enums;
using FluentResults;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Commands.CreatePerson
{
    public class CreatePersonValidator: AbstractValidator<CreatePersonCommand>
    {
        public CreatePersonValidator() {
            RuleFor(p => p.FirstName)
                    .NotEmpty().WithState(x => Result.Fail("FirstName required"))
                    .NotNull()
                    .MinimumLength(3).WithState(x => Result.Fail("Minimmun legtnh  is 3"))
                    .MaximumLength(26).WithState(x => Result.Fail("Maximmumlegtnh  is 26"));

            RuleFor(p => p.SecondName)
                    .NotEmpty().WithState(x => Result.Fail("SecondName required"))
                    .NotNull()
                     .MinimumLength(3).WithState(x => Result.Fail("Minimmun legtnh  is 3"))
                    .MaximumLength(26).WithState(x => Result.Fail("Maximmumlegtnh  is 26"));

            RuleFor(p => p.ThirdName)
                    .NotEmpty().WithState(x => Result.Fail("SecondName required"))
                    .NotNull()
                     .MinimumLength(3).WithState(x => Result.Fail("Minimmun legtnh  is 3"))
                    .MaximumLength(26).WithState(x => Result.Fail("Maximmumlegtnh  is 26"));

            RuleFor(p => p.LastName)
                   .NotEmpty().WithState(x => Result.Fail("SecondName required"))
                    .NotNull()
                     .MinimumLength(3).WithState(x => Result.Fail("Minimmun legtnh  is 3"))
                    .MaximumLength(26).WithState(x => Result.Fail("Maximmumlegtnh  is 26"));

            RuleFor(p => p.Email)
                .NotNull()
                .NotEmpty()
                    .WithState( x => Result.Fail("Email adress Required"))
                .EmailAddress()
                    .WithState(x => Result.Fail("Invalid Email Format"));

            RuleFor(p => p.Address)
                    .NotNull()
                    .NotEmpty()
                    .MinimumLength(8)
                    .MaximumLength(46);

            RuleFor(p => p.Phone)
                    .NotNull()
                    .NotEmpty()
                    .Must(x => int.TryParse(x, out var val) && val > 0)
                        .WithMessage("Invalid Number");

            RuleFor(p => p.BirthDate)
                    .GreaterThan(new DateTime(1930, 1, 1))
                    .LessThanOrEqualTo(DateTime.Now).WithMessage("The Date You Enterd didnt come Yet :3");

            RuleFor(p => p.Gender)
                    .NotNull()
                    .IsInEnum()
                    .WithMessage("Undefained Gender Please Enter valild Gender");

        }
    }
}
