
using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class PersonConfig : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.BirthDate)
            .HasColumnName("DateOfBirth");

        builder.Property(x=> x.Image)
            .HasColumnType("varbinary(MAX)");

        builder.HasOne(x => x.User)
            .WithOne(x => x.Person)
            .HasForeignKey<User>(x => x.PersonId)
            .OnDelete(DeleteBehavior.NoAction);


        builder.HasOne(x => x.Country)
            .WithMany()
            .HasForeignKey(x => x.NationalityCountryId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(x=> x.Gender).HasColumnType("tinyint")
            .HasConversion(x => (short)x,
            x=> (EnGender) Enum.Parse(typeof(EnGender),x.ToString()));



        builder.HasData(AddPersons());

    }

    private List<Person> AddPersons()
    {
        var persons = new List<Person>();

        for (int i = 1; i <= 200; i++)
        {
            var person = new Person
            {
                Id = i,
                NationalNo = "NationalNo" + i,
                FirstName = "FirstName" + i,
                SecondName = "SecondName" + i,
                ThirdName = "ThirdName" + i,
                LastName = "LastName" + i,
                BirthDate = DateTime.Now.AddYears(-25).AddDays(i), // Example birthdate calculation
                Gender = EnGender.Male, // or EnGender.Female depending on the gender
                Address = "Address" + i,
                Phone = "Phone" + i,
                Email = "email" + i + "@example.com",
                NationalityCountryId = (i % 150) + 1, // Example country ID calculation
                Image = null, // You can set it to null if desired
                User = null, // You can omit this property if not needed
                Driver = null, // You can omit this property if not needed
                Applications = null // You can omit this property if not needed
            };
            
            persons.Add(person);
        }

        return persons;
    }
}
