using System;
using System.Collections.Generic;

#nullable disable

namespace LaVictoireDesServicesHelpDeskApp.Models
{
    public partial class Discussion
    {
        public int Id { get; set; }
        public string Contenu { get; set; }
        public DateTime? CreerDate { get; set; }
        public int TickeId { get; set; }
        public int CompteId { get; set; }

        public virtual Compte Compte { get; set; }
        public virtual Ticket Ticke { get; set; }
    }
}
