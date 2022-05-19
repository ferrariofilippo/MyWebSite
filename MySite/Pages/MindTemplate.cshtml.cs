using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
namespace MySite.Pages
{
    public class MindTemplateModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = Request.Query["page"];
        }
    }
}