using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class EditareClienti : Form
    {
        private Client client;
        public EditareClienti(Client c)
        {
            InitializeComponent();
            client = c;
        }

        private void EditareClienti_Load(object sender, EventArgs e)
        {
            tbCodClient.Text = client.CodClient.ToString();
            tbNume.Text = client.Nume;
            tbPrenume.Text = client.Prenume;
            tbTelefon.Text = client.NrTel;
            tbEmail.Text = client.Email;
            tbAdresa.Text = client.Adresa;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            client.CodClient = Convert.ToInt32(tbCodClient.Text);
            client.Nume = tbNume.Text.Trim();
            client.Prenume = tbPrenume.Text.Trim();
            client.NrTel = tbTelefon.Text.Trim();
            client.Email = tbEmail.Text.Trim();
            client.Adresa = tbAdresa.Text.Trim();

        }
    }
}
