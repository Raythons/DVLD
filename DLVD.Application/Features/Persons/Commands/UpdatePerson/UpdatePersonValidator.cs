﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Commands.UpdatePerson
{
    public class UpdatePersonValidator : AbstractValidator<UpdatePersonCommand>
    {
        public UpdatePersonValidator() { }
    }
}
