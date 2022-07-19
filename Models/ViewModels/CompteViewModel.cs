using Microsoft.AspNetCore.Mvc.Rendering;

namespace LaVictoireDesServicesHelpDeskApp.Models.ViewModels
{
    public class CompteViewModel
    {
        public Compte Compte  { get; set; }
        public SelectList Roles { get; set; }
    }
}
