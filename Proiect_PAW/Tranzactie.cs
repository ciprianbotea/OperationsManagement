using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{

    [Serializable]
    public class Tranzactie
    {
        public int CodTranzactie { get; set; }
       public DateTime Data { get; set; }
        public double Valoare { get; set; }
        public Client Client { get; set; }
        public Produs[] Produse { get; set; }

        public Tranzactie()
        {

        }

        public Tranzactie(int codTranzactie, DateTime data, float valoare, Client client, Produs [] produse)
        {
            CodTranzactie = codTranzactie;
            Data = data;
            Valoare = valoare;
            Client = client;
            Produse = produse;
        }
    }
}
