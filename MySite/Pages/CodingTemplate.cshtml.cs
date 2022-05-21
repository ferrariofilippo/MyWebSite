using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Models;
using MySite.Data;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class CodingTemplateModel : PageModel
    {
        public async void OnGet(CodingDbContext db)
        {
            ViewData["Title"] = Request.Query["project"];
            ViewData["Project"] = await db.Projects.FindAsync(Request.Query["project"]);
        }
    }
}
