using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Domain.Entities.Views
{
    public class DetainedLicenseView
    {
        public  int Id { get; set; }
        public  int LicenseId {get;set;}
        public  bool IsReleased { get;set;}
        public  float FineFees { get;set;}
        public  DateTime ReleaseDate { get;set;}
        public  string NationalNo { get;set;}
        public  string FullName   {get;set;}
        public int ReleaseApplicationId { get;set;}
    }
}
//DetainedLicenses.Id,
//			DetainedLicenses.LicenseId,
//			DetainedLicenses.DetainDate,
//			DetainedLicenses.IsReleased,
//			DetainedLicenses.FineFees,
//			DetainedLicenses.ReleaseDate,
//			Persons.NationalNo,
//			Persons.FirstName + ' ' + Persons.SecondName + ' ' +
//            Persons.LastName + ' ' + Persons.ThirdName + ' ' + Persons.LastName as FullName, 
//            DetainedLicenses.ReleaseApplicationId