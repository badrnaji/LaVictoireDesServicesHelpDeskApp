using System;
using System.Collections.Generic;

#nullable disable

namespace LaVictoireDesServicesHelpDeskApp.Models
{
    public partial class Periode
    {
        public Periode()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public bool Statut { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
