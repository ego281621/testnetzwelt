using Netzwelt.Models;
using Netzwelt.Models.Request;
using Netzwelt.Models.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Netzwelt.Caller
{
    public interface IRestClientCaller
    {
        Task<LoginResponseModel> Login(LoginRequestModel login);
        Task<TerritoryResponseDataModel> GetTerritories();
    }
}
