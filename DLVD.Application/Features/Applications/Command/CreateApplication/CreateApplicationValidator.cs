using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentValidation;


namespace DLVD.App.Features.Applications.Command.CreateApplication
{
    public   class CreateApplicationValidator : AbstractValidator<CreateApplicationCommand>
    {
        public CreateApplicationValidator() 
        {
            RuleFor(a => a.PersonId)
                .NotEmpty();
        }


    }
}
