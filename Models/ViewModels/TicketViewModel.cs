using Microsoft.AspNetCore.Mvc.Rendering;

namespace LaVictoireDesServicesHelpDeskApp.Models.ViewModels
{
    public class TicketViewModel
    {
        public Ticket Ticket { get; set; }
        public SelectList Categories { get; set; }
        public SelectList Statutes { get; set; }
        public SelectList Periodes { get; set; }
    }
}
