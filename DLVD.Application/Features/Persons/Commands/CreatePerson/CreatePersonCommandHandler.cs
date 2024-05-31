using AutoMapper;
using DLVD.App.Features.Common;
using DLVD.App.Interfaces;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;

//using FluentResults.Samples.WebController;

namespace DLVD.App.Features.Persons.Commands.CreatePerson
{
    
    public class CreatePersonCommandHandler :
        BaseHandler,
        IRequestHandler<CreatePersonCommand, Result<bool>>
    {
        private readonly IFileStorageService _storageService;
        public CreatePersonCommandHandler(
            IUnitOfWork unitOfWor,
            IMapper mapper,
            IFileStorageService storageService) : base(unitOfWor, mapper)
        {
            _storageService = storageService;
        }    
        public async Task<Result<bool>> Handle(CreatePersonCommand request,
            CancellationToken cancellationToken)
        {
            var ImagePath = await _storageService.SaveFileAsync(request.Image);

            request.ImagePath = ImagePath;

            var Person = _mapper.Map<Person>(request);

            bool IsCreated = await _unitOfWork.PersonRepository.Add(Person);
            await _unitOfWork.CompleteAsync();

            return Result.Ok(IsCreated);
        }
    }
}
