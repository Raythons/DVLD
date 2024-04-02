using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Common
{
    public class ResultDto
    {
        public bool IsSuccess { get; set; }
        public object Response { get; set; }
        public IEnumerable<ErrorDto> Errors { get; set; }

        public ResultDto(bool isSuccess, IEnumerable<ErrorDto> errors ,object? response)
        {
            IsSuccess = isSuccess;
            Errors = errors;
            Response = response ?? string.Empty;
        }
    }

    public class ErrorDto
    {
        public string Message { get; set; }

        public string Code { get; set; }

        public List<IReason> Reasons { get; set; }

        public ErrorDto(string message, string code, List<IReason> reasons)
        {
            Message = message;
            Code = code;
            Reasons = reasons;
        }
    }

}
