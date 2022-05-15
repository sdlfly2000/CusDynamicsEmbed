using Infra.OrganziationService.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.OrganziationService.Repositories
{
    public interface ICusUserInformationRepository
    {
        CusUserInformationEntity GetById(string Id);
    }
}
