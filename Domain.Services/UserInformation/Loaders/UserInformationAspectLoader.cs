using Common.Core.DependencyInjection;
using Domain.Services.UserInformation.Mappers;
using Domain.UserInformations.Aspects;
using Infra.OrganziationService.Repositories;
using System;

namespace Domain.Services.UserInformation.Loaders
{
    [ServiceLocate(typeof(IUserInformationAspectLoader))]
    internal class UserInformationAspectLoader : IUserInformationAspectLoader
    {
        private readonly IUserInformationAspectMapper _userInformaitonAspectMapper;
        private readonly ICusUserInformationRepository _cusUserInformationRepository;

        public UserInformationAspectLoader(
            IUserInformationAspectMapper userInformaitonAspectMapper,
            ICusUserInformationRepository cusUserInformationRepository)
        {
            _userInformaitonAspectMapper = userInformaitonAspectMapper;
            _cusUserInformationRepository = cusUserInformationRepository;
        }

        public IUserInformationAspect LoadById(Guid Id)
        {
            return _userInformaitonAspectMapper.Map(_cusUserInformationRepository.FindById(Id));
        }
    }
}
