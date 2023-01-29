using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Client
    {
        public long CodClient { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string NrTel { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }

        public Client()
        {

        }

        public Client(long codClient, string nume, string prenume, string nrTel, string email, string adresa)
        {
            CodClient = codClient;
            Nume = nume;
            Prenume = prenume;
            NrTel = nrTel;
            Email = email;
            Adresa = adresa;
            

        }

        public Client(long codClient)
        {
            CodClient = codClient;
        }

    }

}


