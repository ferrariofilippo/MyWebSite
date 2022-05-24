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
            if (int.TryParse(Request.Query["page"].ToString(), out int index))
            {
                var page = await db.Pages.FindAsync(index);
                if (page is null) return;
                ViewData["Title"] = page.Topic;
                ViewData["Content"] = page;
            }
        }
    }
}