using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Netzwelt.Caller;
using Netzwelt.Configuration;
using Netzwelt.Models;
using Netzwelt.Models.Request;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Netzwelt.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        IRestClientCaller _restClient;

        const string SessionName = "username";

        public AccountController(ILogger<AccountController> logger, IRestClientCaller restClient)
        {
            _logger = logger;
            _restClient = restClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            string userName = HttpContext.Session.GetString(SessionName);
            if (!string.IsNullOrEmpty(userName))
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionName);
            return RedirectToAction("Login", "Account");
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestModel model)
        {
            if (model.username != null && model.password != null)
            {
                var response = await _restClient.Login(model);
                if (response.success)
                {
                    HttpContext.Session.SetString(SessionName, response.username);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.error = response.message;
                }
            }
            else
            {
                ViewBag.error = "Invalid Account";

            }
            return View(model);
        }


    }
}
