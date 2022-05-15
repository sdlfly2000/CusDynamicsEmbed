using Domain.UserInformations;
using System;

namespace Domain.Services.UserInformation
{
    public interface IUserInformationGateway
    {
        IUserInformation LoadById(Guid Id);
    }
}
