using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVC_stolarija
{
    public class Proizvod
    {
        public int IdProizvoda { get; set; }
        public string Naziv { get; set; }
        public string Tip { get; set; }
        public string Materijal { get; set; }
        public decimal CenaPoKomadu { get; set; }

        public override string ToString() => $"{Naziv} ({CenaPoKomadu} RSD)";
    }

}
