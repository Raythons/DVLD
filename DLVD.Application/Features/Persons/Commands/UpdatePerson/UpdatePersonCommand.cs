using DVLD.Domain.Enums;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DLVD.App.Features.Persons.Commands.UpdatePerson
{
    public class UpdatePersonCommand: IRequest<Result<bool>>
    {


        public UpdatePersonCommand() { }

        public UpdatePersonCommand(UpdatePersonCommand updatePersonCommand) {
            PersonId = updatePersonCommand.PersonId;
            NationalNo = updatePersonCommand.NationalNo;
            FirstName = updatePersonCommand.FirstName;
            SecondName = updatePersonCommand.SecondName;
            ThirdName = updatePersonCommand.ThirdName;
            LastName = updatePersonCommand.LastName;
            BirthDate = updatePersonCommand.BirthDate;
            Gender = updatePersonCommand.Gender;
            Address = updatePersonCommand.Address;
            Phone = updatePersonCommand.Phone;
            Email = updatePersonCommand.Email;
            NationalityCountryId = updatePersonCommand.NationalityCountryId;
            Image = updatePersonCommand.Image;
        }

        //public UpdatePersonCommand(string nationalNo, string firstName,
        //    string secondName, string thirdName, string lastName,
        //    DateTime birthDate, EnGender gender, string address,
        //    string phone, string email, int nationalityCountryId, byte[]? image)
        //{
        //    NationalNo = nationalNo;
        //    FirstName = firstName;
        //    SecondName = secondName;
        //    ThirdName = thirdName;
        //    LastName = lastName;
        //    BirthDate = birthDate;
        //    Gender = gender;
        //    Address = address;
        //    Phone = phone;
        //    Email = email;
        //    NationalityCountryId = nationalityCountryId;
        //    Image = image;
        //}
        public int PersonId { get; set; }
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
    }
}
