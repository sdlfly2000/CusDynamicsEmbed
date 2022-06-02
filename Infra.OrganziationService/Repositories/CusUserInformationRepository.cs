using Common.Core.DependencyInjection;
using Infra.OrganziationService.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Linq;

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
                    Criteria = filterById,
                    ColumnSet = new ColumnSet("ownerid", "crb51_name")
                }                
            }) as RetrieveMultipleResponse;

            return Map(response);
        }

        #region Private Methods

        private CusUserInformationEntity Map(RetrieveMultipleResponse response)
        {
            var recordResponse = response.EntityCollection.Entities.FirstOrDefault();
            return recordResponse != null 
                ? new CusUserInformationEntity
                {
                    CusUserInformationid = recordResponse.Id.ToString(),
                    OwnerId = recordResponse.GetAttributeValue<EntityReference>("ownerid").Id.ToString(),
                    Name = recordResponse.GetAttributeValue<string>("crb51_name")
                }
                : new CusUserInformationEntity();
        }

        #endregion
    }
}
