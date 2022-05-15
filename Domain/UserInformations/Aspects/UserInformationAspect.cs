using System;

namespace Domain.UserInformations.Aspects
{
    public class UserInformationAspect : IUserInformationAspect
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
