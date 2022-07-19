using LaVictoireDesServicesHelpDeskApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using LaVictoireDesServicesHelpDeskApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace LaVictoireDesServicesHelpDeskApp.Controllers
{
    [Route("ticket")]
    public class TicketController : Controller
    {
        private HelpDeskVictoireDBEntities db;
        public TicketController(HelpDeskVictoireDBEntities _db)
        {
            this.db = _db;
        }

        [Authorize(Roles = "Employee")]
        [HttpGet]
        [Route("envoyer")]
        public IActionResult Envoyer()
        {
            var ticketViewModel = new TicketViewModel();
            ticketViewModel.Ticket = new Ticket();
            var categories = db.Categories.Where(r => r.Statut).ToList();
            ticketViewModel.Categories = new SelectList(categories, "Id", "Nom");

            var statutes = db.Statuts.Where(r => r.Display).ToList();
            ticketViewModel.Statutes = new SelectList(statutes, "Id", "Nom");

            var periodes = db.Periodes.Where(r => r.Statut).ToList();
            ticketViewModel.Periodes = new SelectList(periodes, "Id", "Nom");

            return View("Envoyer", ticketViewModel);
        }

        
        [HttpPost]
        [Route("envoyer")]
        public IActionResult Envoyer(TicketViewModel ticketViewModel)
        {
            try
            {
                var username = User.FindFirst(ClaimTypes.Name).Value;
                var compte = db.Comptes.SingleOrDefault(a => a.NomUtilisateur.Equals(username));
                ticketViewModel.Ticket.EmployeeId = compte.Id;
                ticketViewModel.Ticket.CreerDate = DateTime.Now;
                db.Tickets.Add(ticketViewModel.Ticket);
                db.SaveChanges();
                TempData["msg"] = "Done";
                ViewBag.msg = "Done";
            }
            catch 
            {
                TempData["msg"] = "Failed";
            }


            return RedirectToAction("Envoyer");
        }
    }
}
