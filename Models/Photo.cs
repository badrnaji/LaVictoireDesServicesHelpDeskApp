using System;
using System.Collections.Generic;

#nullable disable

namespace LaVictoireDesServicesHelpDeskApp.Models
{
    public partial class Photo
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
