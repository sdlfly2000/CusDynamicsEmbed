using Domain.UserInformations.Aspects;
using System;

namespace Domain.Services.UserInformation.Loaders
{
    internal interface IUserInformationAspectLoader
    {
        IUserInformationAspect LoadById(Guid Id);
    }
}
