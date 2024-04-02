using DLVD.App;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Common.Errors
{
    public  class ValidationError : Error 
    {

        public ValidationError(string erroType) : base (erroType) { }


        public static ValidationError Create() {
            return new ValidationError("Validation Error");
        }
    }
}
