using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPonavljanje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(29.78, 1.670);
            Satelit Mjesec = new Satelit(29.78, 1.076);

            Console.WriteLine(Zemlja.ToString());
            Console.WriteLine(Mjesec.ToString());

            Console.ReadKey();

        }
    }
}
