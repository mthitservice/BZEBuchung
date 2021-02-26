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
    public class NeueBuchungModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int AnzahlBuchungen = 0;
        public List<view_Buchungsliste> Buchungen;
        public NeueBuchungModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public IActionResult OnPost()
        {
            var von = Request.Form["exampleInputvon"];

            var bis = Request.Form["exampleInputbis"];

            var Teilnehmeranzahl = Request.Form["exampleInputTZ"];

            var Raumid = Request.Form["exampleInputRID"];


            tab_buch_buchung buch_Buchung = new tab_buch_buchung();
            buch_Buchung.von = Convert.ToDateTime(von);
            buch_Buchung.bis = Convert.ToDateTime(bis);
            buch_Buchung.Teilnehmeranzahl = Convert.ToInt32(Teilnehmeranzahl);
            buch_Buchung.raum_id = Convert.ToInt32(Raumid);

            using (var context = new BuchungDbContext())
            {
                context.tab_buch_buchung.Add(buch_Buchung);
                context.SaveChanges();
                return Redirect("/Buchungen");
            }



        }
        public void OnGet()
        {
            using (var context = new BuchungDbContext())
            {

            }
        }
    }
}