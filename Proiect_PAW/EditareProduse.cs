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
    public partial class EditareProduse : Form
    {
        private Produs produs;
        public EditareProduse(Produs p)
        {
            InitializeComponent();
            produs = p;
        }


        private void EditareProduse_Load(object sender, EventArgs e)
        {
            tbCodProdus.Text = produs.CodProdus.ToString();
            tbDenumire.Text = produs.Denumire;
            tbPret.Text = produs.Pret.ToString();
            tbCantitate.Text = produs.Cantitate.ToString();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            produs.CodProdus = Convert.ToInt32(tbCodProdus.Text);
            produs.Denumire = tbDenumire.Text.Trim();
            produs.Pret = Convert.ToDouble(tbPret);
            produs.Cantitate = Convert.ToInt32(tbCantitate);
        }


    }
}
