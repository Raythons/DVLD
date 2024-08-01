using AutoMapper;
using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.Applications.Command.UpdateApplicaton
{
    public class UpdateApplicationCommandhandler : BaseHandler,
        IRequestHandler<UpdateApplicationStatusCommand, Result<bool>>
    {
        public UpdateApplicationCommandhandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(
            UpdateApplicationStatusCommand request,
            CancellationToken cancellationToken)
        {

            var isSucess = await _unitOfWork.ApplicationRepositry
                                            .MarkDeleted(request.LocalDrivvingLicenseApplicationId);

            if (!isSucess)
                return Result.Fail("Couldnt Update The Status ");


            await _unitOfWork.CompleteAsync();
            return Result.Ok(true)
                        .WithSuccess($"Status of applicationId {request.LocalDrivvingLicenseApplicationId} Updated Successfully");
        }
    }
}

