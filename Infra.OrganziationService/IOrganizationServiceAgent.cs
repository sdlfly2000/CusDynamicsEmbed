using Microsoft.Xrm.Sdk;

namespace Infra.OrganziationService
{
    public interface IOrganizationServiceAgent
    {
        OrganizationResponse Execute(OrganizationRequest request);
    }
}
