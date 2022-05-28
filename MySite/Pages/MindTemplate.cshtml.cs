using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Models;
using MySite.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace MySite.Pages
{
    public class MindTemplateModel : PageModel
    {
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken token;
        public async void OnGet([FromServices]MindDbContext db)
        {
            token = tokenSource.Token;
            if (int.TryParse(Request.Query["page"].ToString(), out int index))
            {
                var page = await db.Pages.FindAsync(index);
                if (page is null)
                {
                    tokenSource.Cancel();
                    return;
                }

                ViewData["Title"] = page.Topic;
                ViewData["Content"] = page;
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