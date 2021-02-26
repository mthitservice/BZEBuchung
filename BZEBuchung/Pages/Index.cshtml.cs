using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BZEBuchung.Model;
using BZEBuchung.Data;
namespace BZEBuchung.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int AnzahlBuchungen = 0;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            using (var context = new BuchungDbContext())
            {
                var x = context.view_Buchungsliste.Count();
                this.AnzahlBuchungen = x;
            }
        }
    }
}
