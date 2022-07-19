using LaVictoireDesServicesHelpDeskApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LaVictoireDesServicesHelpDeskApp.Security;

namespace LaVictoireDesServicesHelpDeskApp.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        private readonly HelpDeskVictoireDBEntities db;

        public LoginController(HelpDeskVictoireDBEntities _db)
        {
            this.db = _db;
        }

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        [Route("process")]
        public IActionResult Process(string username, string password)
        {
            var compte = check(username, password);
            if (compte != null)
            {
                SecurityManager securityManger = new SecurityManager();
                securityManger.SignIn(HttpContext, compte);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.error = "Invalid";
                return View("Index");
            }
            
        }
        [Route("SignOut")]
        public IActionResult signOut()
        {
            SecurityManager securityManger = new SecurityManager();
            securityManger.SignOut(HttpContext);
            return RedirectToAction("Index");
        }
        [Route("AccessDenied")]
        public IActionResult AccessDenied()
        {
     
            return View("AccessDenied");
        }

        
        private Compte check(string username, string password)
        {
            var compte = db.Comptes.SingleOrDefault(a => a.NomUtilisateur.Equals(username) && a.Statut == true);
            if (compte != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, compte.Password))
                {
                    return compte;
                }
            }
            return null;
        }
    }
}
