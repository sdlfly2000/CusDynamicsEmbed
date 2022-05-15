using Domain.UserInformations.Aspects;
using System;

namespace Domain.UserInformations
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
