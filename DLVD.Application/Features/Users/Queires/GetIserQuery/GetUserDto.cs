using DLVD.App.Features.Persons.Queires.GetPersonsList;


namespace DLVD.App.Features.Users.Queires.GetUserQuery
{
   public record GetUserDto (int Id, string userName,
                    bool isActive, GetPersonsListDto person)
    {
      
    }
}
