using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PVC_stolarija
{
    public class Uloga
    {
        public int IdUloge { get; set; }
        public string NazivUloge { get; set; }
        public string OpisUloge { get; set; }

        public override string ToString() => NazivUloge;
    }
}

