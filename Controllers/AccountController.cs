using LaVictoireDesServicesHelpDeskApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaVictoireDesServicesHelpDeskApp.Security;
namespace LaVictoireDesServicesHelpDeskApp.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private readonly HelpDeskVictoireDBEntities db;

        public AccountController(HelpDeskVictoireDBEntities _db)
        {
            this.db = _db;
        }

        [Route("index")]
        [Route("")
        public IActionResult Index()
        {

            return View();
        }
    }
}
