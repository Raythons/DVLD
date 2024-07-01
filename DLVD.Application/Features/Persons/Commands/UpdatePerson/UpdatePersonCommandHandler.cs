using AutoMapper;
using DLVD.App.Features.Common;
using DLVD.App.Interfaces;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Commands.UpdatePerson
{
    public class UpdatePersonCommandHandler : BaseHandler,
        IRequestHandler<UpdatePersonCommand, Result<bool>>
    {
        private readonly IFileStorageService _storageService;
        public UpdatePersonCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IFileStorageService storageService) : base(unitOfWork, mapper)
        {
            _storageService = storageService;
        }

        public async Task<Result<bool>> Handle(UpdatePersonCommand request,
            CancellationToken cancellationToken)
        {
            request.ImagePath =   await HandleImageFile(request.Image);

            Person newPersonData =  _mapper.Map<Person>(request);

            bool isUpdated = await _unitOfWork.PersonRepository.Update(newPersonData);

            if (isUpdated)    
                await _unitOfWork.CompleteAsync();
            
            return Result.Ok(isUpdated);
            
        }
        private async  Task<string>  HandleImageFile(byte[]? imageFile)
        {
            if (imageFile == null)
                return null;

            var ImagePath = await _storageService.SaveFileAsync(imageFile);

            return ImagePath;

        }
    }
}
