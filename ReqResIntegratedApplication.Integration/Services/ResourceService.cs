using ReqresIntegratedApplication.Integration.Entities;
using ReqresIntegratedApplication.Integration.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresIntegratedApplication.Integration.Services
{
    public class ResourceService
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _baseUrl;

        public ResourceService(HttpClient httpClient, string baseUrl)
        {
            _httpClient = httpClient;
            _baseUrl = baseUrl;
        }

        public async Task<Resource> PostResource(Resource resource)
        {
           Resource requestBody = new Resource(resource.Page, resource.Per_Page, resource.Total, resource.Total_Pages, resource.Data);

           ResourceManager resourceManager = new ResourceManager(_httpClient, _baseUrl, resource);
           return await resourceManager.Post();
        }
    }
}
