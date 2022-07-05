using LaVictoireDesServicesHelpDeskApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaVictoireDesServicesHelpDeskApp.Controllers
{
    [Authorize(Roles = "Administrateur,Support,,Employee")]
    [Route("Dashboard")]
    public class DashboardController : Controller
    {
        private HelpDeskVictoireDBEntities db;

        public DashboardController(HelpDeskVictoireDBEntities _db)
        {
            this.db = _db;
        }
        [Route("index")]
        [Route("")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
