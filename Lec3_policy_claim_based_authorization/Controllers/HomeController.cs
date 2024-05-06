using Lec3_policy_claim_based_authorization.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lec3_policy_claim_based_authorization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[Authorize]
        //[Authorize(Policy = "DepartmentAccess")]
        [Authorize(Policy = "CSDepartmentAccess")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Policy = "BusinessHoursOnly")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
