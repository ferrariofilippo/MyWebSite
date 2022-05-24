using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using Microsoft.EntityFrameworkCore;
namespace MySite.Pages
{
    public class CodingTemplateModel : PageModel
    {
        public async void OnGet(CodingDbContext db)
        {
            if (int.TryParse(Request.Query["project"].ToString(), out int index))
            {
                var project = await db.Projects.FindAsync(index);
                ViewData["Title"] = project.Name;
                ViewData["Project"] = project;
            }
        }
    }
}
