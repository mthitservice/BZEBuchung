using System;
using System.ComponentModel.DataAnnotations;

namespace BZEBuchung.Model
{

    public class view_Buchungsliste
    {

        public int Haus_id { get; set; }
        public int Etage_id { get; set; }
        public int Raum_id { get; set; }
        [Key]
        public int Buchung_id { get; set; }
        public string Hausbezeichnung { get; set; }
        public string Etagenbezeichnung { get; set; }
        public string Raumbezeichnung { get; set; }
        public DateTime von { get; set; }
        public DateTime bis { get; set; }
        public string Teilnehmeranzahl { get; set; }
        public short MaxBesucher { get; set; }



    }




}