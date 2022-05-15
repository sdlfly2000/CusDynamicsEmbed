using Common.Core.DependencyInjection;
using Infra.OrganziationService.Entities;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;

namespace Infra.OrganziationService.Repositories
{
    [ServiceLocate(typeof(ICusUserInformationRepository))]
    public class CusUserInformationRepository : ICusUserInformationRepository
    {
        private readonly IOrganizationServiceAgent _organizationServiceAgent;

        public CusUserInformationRepository(IOrganizationServiceAgent organizationServiceAgent)
        {
            _organizationServiceAgent = organizationServiceAgent;
        }

        public CusUserInformationEntity FindById(Guid Id)
        {
            var filterById = new FilterExpression();
            filterById.AddCondition("crb51_cususerinformationid", ConditionOperator.Equal, Id);

            var response = _organizationServiceAgent.Execute(new RetrieveMultipleRequest
            {
                Query = new QueryExpression("crb51_cususerinformation") 
                {
                    Criteria = filterById
                }                
            }) as RetrieveMultipleResponse;

            return Map(response);
        }

        #region Private Methods

        private CusUserInformationEntity Map(RetrieveMultipleResponse response)
        {
            return new CusUserInformationEntity
            {
            };
        }

        #endregion
    }
}
