using System;
using System.Collections.Generic;

#nullable disable

namespace LaVictoireDesServicesHelpDeskApp.Models
{
    public partial class Role
    {
        public Role()
        {
            Comptes = new HashSet<Compte>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Compte> Comptes { get; set; }
    }
}
