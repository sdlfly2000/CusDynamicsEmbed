using System;

namespace Domain.UserInformation.Aspects
{
    public interface IUserInformationAspect
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
