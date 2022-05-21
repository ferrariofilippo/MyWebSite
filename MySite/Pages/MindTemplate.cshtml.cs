using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Models;
using MySite.Data;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class MindTemplateModel : PageModel
    {
        public async void OnGet(MindDbContext db)
        {
            ViewData["Title"] = Request.Query["page"];
            ViewData["Content"] = await db.Pages.FindAsync(Request.Query["page"]);
        }
    }
}