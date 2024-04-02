using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Applications.Command.CreateApplication
{
    public class CreateApplicationCommandHandller : BaseHandler,
            IRequestHandler<CreateApplicationCommand, Result<int>>
    {
        public CreateApplicationCommandHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<Result<int>> Handle(CreateApplicationCommand request,
                CancellationToken cancellationToken)
        {

            var personApplications = await _unitOfWork
                                                .ApplicationRepositry
                                                .GetPersonLocalApplicationsOfLicenseClass(request.PersonId, request.LicenseClassId);


            if (personApplications is not  null)
            {
                return Result.Fail($"Person Of Id {request.PersonId} Alreayd have request of " +
                    $"The smae license class Try Another Class And The ApplicationId Is: {personApplications.Id} ");
            }

            var applicationToCreate = _mapper.Map<Application>(request);

            var result = await _unitOfWork.ApplicationRepositry.Add(applicationToCreate);

            await _unitOfWork.CompleteAsync();

            if (result == false)
                return  Result.Fail("SomeThing Went Wrongs");
       
            return Result.Ok(applicationToCreate.Id);

        }
    }
}
