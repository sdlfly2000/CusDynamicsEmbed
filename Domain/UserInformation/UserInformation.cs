using Domain.UserInformation.Aspects;
using System;

namespace Domain.UserInformation
{
    public class UserInformation : IUserInformation
    {
        private readonly IUserInformationAspect _ususerInformationAspect;

        public UserInformation(IUserInformationAspect userInformationAspect)
        {
            _ususerInformationAspect = userInformationAspect;
        }

        public Guid Id { 
            get => _ususerInformationAspect.Id; 
            set => _ususerInformationAspect.Id = value; 
        }

        public string Name { 
            get => _ususerInformationAspect.Name;
            set => _ususerInformationAspect.Name = value; }
    }
}
