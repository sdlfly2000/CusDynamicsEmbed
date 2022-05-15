using Domain.UserInformations.Aspects;
using Infra.OrganziationService.Entities;

namespace Domain.Services.UserInformation.Mappers
{
    internal interface IUserInformationAspectMapper
    {
        IUserInformationAspect Map(CusUserInformationEntity entity);
    }
}
