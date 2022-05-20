using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Models;
using System.Net;
namespace MySite.Pages
{
    public class TravelTemplateModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = Request.Query["country"];
            ViewData["Travel"] = new Travel(); // Fetch the travel from a db
            ViewData["Places"] = new SuggestedPlace[5]; // Fetch from a db
        }
    }
}