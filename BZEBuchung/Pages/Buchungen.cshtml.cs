using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BZEBuchung.Model;
using BZEBuchung.Data;
using Microsoft.EntityFrameworkCore;


namespace BZEBuchung.Pages
{
    public class BuchungenModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int AnzahlBuchungen = 0;
        public List<view_Buchungsliste> Buchungen;
        public BuchungenModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            using (var context = new BuchungDbContext())
            {
                var x = context.view_Buchungsliste.Count();
                this.AnzahlBuchungen = x;


                // Buchungen = context.view_Buchungsliste.FromSqlRaw("Select * from view_Buchungsliste where Buchung_id=2").ToList();


                Buchungen = context.view_Buchungsliste.OrderByDescending(e => e.Buchung_id).ToList();


            }
        }
    }
}