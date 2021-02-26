using System;
using System.ComponentModel.DataAnnotations;

namespace BZEBuchung.Model
{
    public class tab_buch_buchung
    {


        [Key]
        public int id { get; set; }

        public DateTime von { get; set; }
        public DateTime bis { get; set; }

        public int Teilnehmeranzahl { get; set; }
        public int raum_id { get; set; }





    }




}