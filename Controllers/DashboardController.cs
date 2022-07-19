using LaVictoireDesServicesHelpDeskApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LaVictoireDesServicesHelpDeskApp.Controllers
{
    [Authorize(Roles = "Administrateur,Support,Employee")]
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
