using DLVD.App.Features.Persons.Queires.GetPersonsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Users.Queires.GetUserQuery
{
   public record GetUserDto (int Id, string userName,
                    bool isActive, GetPersonsListDto person)
    {
      
    }
}
