using System;
using System.ComponentModel.DataAnnotations;

namespace BZEBuchung.Model
{
    public class tab_buch_log
    {


        [Key]
        public DateTime LogDate { get; set; }

        public string logtext { get; set; }

        public tab_buch_log()
        {
            LogDate = DateTime.Now;

        }


    }




}