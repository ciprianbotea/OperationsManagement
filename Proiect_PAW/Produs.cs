using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Produs
    {
        public long CodProdus { get; set; }
        public string Denumire { get; set; }
        public double Pret { get; set; }
        public float Cantitate { get; set; }

        public Produs()
        {
            
        }

        public Produs(string denumire)
        {
            Denumire = denumire;
        }

        public Produs(long codProdus, string denumire, double pret, float cantitate)
        {
            CodProdus = codProdus;
            Denumire = denumire;
            Pret = pret;
            Cantitate = cantitate;


        }
    }
}
