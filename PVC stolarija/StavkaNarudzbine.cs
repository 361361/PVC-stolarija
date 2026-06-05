using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVC_stolarija
{
    public class StavkaNarudzbine
    {
        public int IdStavke { get; set; }
        public Proizvod Proizvod { get; set; }
        public int Kolicina { get; set; }
        public decimal JedinicnaCena { get; set; }

        public decimal UkupnaCena() => JedinicnaCena * Kolicina;
    }

}
