﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LaVictoireDesServicesHelpDeskApp.Models
{
    [Table("Periodes")]
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
