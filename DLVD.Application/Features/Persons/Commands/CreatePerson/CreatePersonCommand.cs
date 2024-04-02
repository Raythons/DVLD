using DLVD.App.Features.Common;
using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Commands.CreatePerson
{
    public class CreatePersonCommand : IRequest<Result<bool>>

    {

        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public EnGender Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryId { get; set; }
        public byte[]? Image { get; set; }


        public CreatePersonCommand() { }

        public CreatePersonCommand(string nationalNo, string firstName,
            string secondName, string thirdName, string lastName,
            DateTime birthDate, EnGender gender, string address,
            string phone, string email, int nationalityCountryId, byte[]? image)
        {
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryId = nationalityCountryId;
            Image = image;
        }
    }
}
