using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Domain.Exceptions.Persons
{
    public class PersonNotFound: Exception
    {
        public PersonNotFound(string message): base (message) { }
    }
}
