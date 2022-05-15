using Common.Core.DependencyInjection;
using Domain.UserInformations.Aspects;
using Infra.OrganziationService.Entities;
using System;

namespace Domain.Services.UserInformation.Mappers
{
    [ServiceLocate(typeof(IUserInformationAspectMapper))]
    public class UserInformationAspectMapper : IUserInformationAspectMapper
    {
        public IUserInformationAspect Map(CusUserInformationEntity entity)
        {
            return new UserInformationAspect
            {
                Id = Guid.Parse(entity.CusUserInformationid),
                Name = entity.Name
            };
        }
    }
}
