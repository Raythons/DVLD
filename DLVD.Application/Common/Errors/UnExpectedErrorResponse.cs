using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Common.Errors
{
    public class UnExpectedErrorResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string erroMsg { get; set; }
        public UnExpectedErrorResponse() { }

        public UnExpectedErrorResponse(string message, HttpStatusCode statusCode) {

            erroMsg = message;
            StatusCode = statusCode;
        }
    }
}
