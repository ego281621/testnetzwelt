using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Netzwelt.Caller;
using Netzwelt.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Netzwelt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRestClientCaller _restClient;

        const string SessionName = "username";

        public HomeController(ILogger<HomeController> logger, IRestClientCaller restClient)
        {
            _logger = logger;
            _restClient = restClient;
        }

        public IActionResult Index()
        {
            string userName = HttpContext.Session.GetString(SessionName);

            if (string.IsNullOrEmpty(userName))
            {
                return RedirectToAction("Login", "Account");
            }
            
            var territories = GetTerritories();

            string jsonTerritoriesString = JsonSerializer.Serialize(territories);

            ViewData["Territories"] = jsonTerritoriesString;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task<List<RegionModel>> GetTerritories()
        {

            var territoryResponses = await _restClient.GetTerritories();

            var regionTerritories = territoryResponses.data.Where(x => x?.parent == 0)
                                 .Select(r => new RegionModel
                                 {
                                     Id = r.id,
                                     Name = r.name,
                                     Provinces =  territoryResponses.data.Where(p => p?.parent == r.id)
                                                  .Select(p => new ProvinceModel { 
                                                     Id = p.id,
                                                     Name = p.name,
                                                     Municipalities = territoryResponses.data.Where(m => m?.parent == p.id)
                                                                     .Select(m => new MunicipalityModel
                                                                     {
                                                                        Id = m.id,
                                                                        Name = m.name
                                                                     }).OrderBy(x => x.Name).ToList()
                                                  }).OrderBy(x => x.Name).ToList()
                                                 
                                 }).OrderBy(x => x.Name).ToList();
            return regionTerritories;
        }

    }
}
