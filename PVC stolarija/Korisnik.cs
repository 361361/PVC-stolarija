using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVC_stolarija
{
    public class Korisnik
    {
        public int IdKorisnika { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; } 
        public string Email { get; set; }
        public Uloga Uloga { get; set; }

        public bool ProveriLozinku(string unos)
        {
            return Lozinka == unos;         }
    }

}
