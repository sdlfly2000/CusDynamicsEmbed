using Common.Core.DependencyInjection;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using System;

namespace Infra.OrganziationService
{
    [ServiceLocate(typeof(IOrganizationServiceAgent))]
    public class OrganizationServiceAgent : IOrganizationServiceAgent
    {
        private readonly string ConnectionString = @"";

        private readonly Lazy<ServiceClient> _lazyServiceClient;

        public OrganizationServiceAgent()
        {
            _lazyServiceClient = new Lazy<ServiceClient>(() => new ServiceClient(ConnectionString));
        }

        public OrganizationResponse Execute(OrganizationRequest request)
        {
            return _lazyServiceClient.Value.Execute(request);
        }
    }
}
