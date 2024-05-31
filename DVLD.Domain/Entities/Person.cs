#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using DVLD.Domain.Enums;
using System.Drawing;

namespace DVLD.Domain.Entities;
public class Person 
{
    public int Id { get; set; }
    public string NationalNo { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string ThirdName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public EnGender Gender { get; set; }
    public string Address { get; set; }
    public string Phone {  get; set; }
    public string Email { get; set; }
    public int NationalityCountryId { get; set; }
    public Country Country { get; set; }
    public string? Image { get; set; }
    public User? User { get; set; }
    public Driver? Driver { get; set; }
    public ICollection<Application>? Applications { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

