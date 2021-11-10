using Netzwelt.Caller;
using Netzwelt.Models.Request;
using Netzwelt.Models.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Netzwelt.Caller
{
    public class RestClientCaller : IRestClientCaller
    {
        private readonly RestClient _client;
        private readonly string _url = "https://netzwelt-devtest.azurewebsites.net/";

        public RestClientCaller()
        {
            _client = new RestClient(_url);
        }
        public async Task<LoginResponseModel> Login(LoginRequestModel login)
        {
            var request = new RestRequest("Account/SignIn", Method.POST);
            request.AddJsonBody(login);

            var response = await _client.ExecuteAsync<LoginResponseModel>(request);

            response.Data.success = response.StatusCode == System.Net.HttpStatusCode.OK;
            return response.Data;

        }
        public async Task<TerritoryResponseDataModel> GetTerritories()
        {
            var request = new RestRequest("Territories/All", Method.GET)
            { RequestFormat = DataFormat.Json };

            var response = await _client.ExecuteAsync<TerritoryResponseDataModel>(request);
            return response.Data;
        }
    }

}
