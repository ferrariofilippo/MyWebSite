using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace MySite.Pages
{
    public class CodingTemplateModel : PageModel
    {
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken token;
        public async void OnGet([FromServices]CodingDbContext db)
        {
            token = tokenSource.Token;   
            if (int.TryParse(Request.Query["project"].ToString(), out int index))
            {
                var project = await db.Projects.FindAsync(index);
                ViewData["Title"] = project?.Name;
                ViewData["Project"] = project;
            }
            tokenSource.Cancel();
        }
        public async Task WaitData()
        {
            try
            {
                while (true)
                {
                    token.ThrowIfCancellationRequested();
                }
            }
            catch (Exception)
            {
                Debug.Print("Data Loaded");
            }
        }
    }
}