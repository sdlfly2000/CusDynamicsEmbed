using System;

namespace Domain.UserInformations.Aspects
{
    public interface IUserInformationAspect
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
