using Infra.OrganziationService.Entities;
using System;

namespace Infra.OrganziationService.Repositories
{
    public interface ICusUserInformationRepository
    {
        CusUserInformationEntity FindById(Guid Id);
    }
}
