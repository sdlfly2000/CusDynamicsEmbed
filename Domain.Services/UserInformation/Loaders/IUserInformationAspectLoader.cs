using Domain.UserInformations.Aspects;
using System;

namespace Domain.Services.UserInformation.Loaders
{
    public interface IUserInformationAspectLoader
    {
        IUserInformationAspect LoadById(Guid Id);
    }
}
