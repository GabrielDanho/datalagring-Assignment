using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalagring.Models
{
    public class Ärende
    {
        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Beskrivning { get; set; }
        public string Status { get; set; }
        public string Kommentar { get; set; }

        public Ärende(string förnamn, string efternamn, string email, string telefon, string beskrivning, string status, string kommentar)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
            Email = email;
            Telefon = telefon;
            Beskrivning = beskrivning;
            Status = status;
            Kommentar = kommentar;
        }
    }

}


