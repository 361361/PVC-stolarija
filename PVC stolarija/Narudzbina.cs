using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVC_stolarija
{
    
    public class Narudzbina
    {
        public int IdNarudzbine { get; set; }
        public Kupac Kupac { get; set; }
        public Korisnik Kreirao { get; set; }
        public DateTime DatumNarudzbine { get; set; }
        public DateTime RokIsporuke { get; set; }
        public string Status { get; set; }
        public List<StavkaNarudzbine> Stavke { get; set; } = new List<StavkaNarudzbine>();

        public decimal UkupnaCena()
        {
            decimal suma = 0;
            foreach (var s in Stavke)
                suma += s.UkupnaCena();
            return suma;
        }
    }

}
