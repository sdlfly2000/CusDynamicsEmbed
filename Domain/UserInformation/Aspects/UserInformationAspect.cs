using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UserInformation.Aspects
{
    public class UserInformationAspect : IUserInformationAspect
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
