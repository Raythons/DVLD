using DLVD.App.Common;
using System.Collections.Generic;
using System.Linq;

namespace FluentResults.Samples.WebController
{
    public static class ResultDtoExtensions
    {
        public static ResultDto ToResultDto<T>(this Result<T> result, object sucecessResponse = null)
        {
            if (result.IsSuccess)
                return new ResultDto(true, Enumerable.Empty<ErrorDto>(), sucecessResponse);

            return new ResultDto(false, TransformErrors(result.Errors), sucecessResponse);
        }

        private static IEnumerable<ErrorDto> TransformErrors(List<IError> errors)
        {
            return errors.Select(TransformError);
        }

        private static ErrorDto TransformError(IError error)
        {
            var errorCode = TransformErrorCode(error);

            var reasons = new List<IReason>(error.Reasons);

            return new ErrorDto(error.Message, errorCode, reasons);
        }

        private static string TransformErrorCode(IError error)
        {
            if (error.Metadata.TryGetValue("ErrorCode", out var errorCode))
                return errorCode as string;

            return "";
        }
    }
}