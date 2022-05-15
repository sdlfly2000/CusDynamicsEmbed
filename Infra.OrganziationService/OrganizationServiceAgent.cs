using Common.Core.DependencyInjection;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using System;

namespace Infra.OrganziationService
{
    [ServiceLocate(typeof(IOrganizationServiceAgent))]
    public class OrganizationServiceAgent : IOrganizationServiceAgent
    {
        private readonly string ConnectionString = @"authtype=OAuth;username=admin@CRM823595.OnMicrosoft.com; password=sdl@1215;url=https://orgccb30bdb.crm5.dynamics.com;AppId=51f81489-12ee-4a9e-aaae-a2591f45987d; RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;loginPrompt=Auto";

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
