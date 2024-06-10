
using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.UserName);
        //builder.HasOne(x => x.Person)
        //    .WithOne(x => x.User)
        //    .HasForeignKey<User>(x=> x.PersonId)
        //    .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.RefreshTokens)
                .WithOne()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(AddUsers());
    }

    private List<User> AddUsers()
    {

        var Users = new List<User>();
        for (int i = 1; i <= 200; i++)
        {
            var user = new User
            {
                Id = i,
                UserName = i.ToString(),
                Password = i.ToString(),
                PersonId = i,
                IsActive = true
            };

            Users.Add(user);
        }

        return Users;
    }
}
