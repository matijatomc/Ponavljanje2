using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPonavljanje2
{
    class NebeskoTijelo
    {
        double brzinaOkoOsi;
        double brzinaOkoSunca;

        public double BrzinaOkoOsi { get => brzinaOkoOsi; set => brzinaOkoOsi = value; }
        public double BrzinaOkoSunca { get => brzinaOkoSunca; set => brzinaOkoSunca = value; }

        public override string ToString()
        {
            string ispis = "\nBrzina oko osi: " + BrzinaOkoOsi + "\nBrzina oko Sunca: " + BrzinaOkoSunca;
            return ispis;
        }
    }
}
