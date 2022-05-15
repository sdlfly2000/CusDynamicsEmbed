using Common.Core.DependencyInjection;
using Domain.Services.UserInformation.Loaders;
using Domain.UserInformations;
using System;

namespace Domain.Services.UserInformation
{
    [ServiceLocate(typeof(IUserInformationGateway))]
    public class UserInformationGateway : IUserInformationGateway
    {
        private readonly IUserInformationAspectLoader _userInformationAspectLoader;

        public UserInformationGateway(IUserInformationAspectLoader userInformationAspectLoader)
        {
            _userInformationAspectLoader = userInformationAspectLoader;
        }

        public IUserInformation LoadById(Guid Id)
        {
            return new UserInformations.UserInformation(_userInformationAspectLoader.LoadById(Id));
        }
    }
}
