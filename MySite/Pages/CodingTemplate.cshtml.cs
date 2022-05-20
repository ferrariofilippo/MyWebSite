using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Models;
namespace MySite.Pages
{
    public class CodingTemplateModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = Request.Query["project"];
            ViewData["Project"] = new Project();
        }
    }
}
