using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormTranzactii : Form
    {

        private List<Tranzactie> listaTranzactii = new List<Tranzactie>();
        private readonly Client _client;
               
        public FormTranzactii(List<Tranzactie> listaTranzactii)
        {

            InitializeComponent();
            lvTransactions.Select();
            _client = new Client();

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            Tranzactie t = new Tranzactie();
            t.CodTranzactie = Convert.ToInt32(tbCodTranzactie.Text);
            t.Valoare = Convert.ToDouble(tbValoare.Text);
            t.Data = Convert.ToDateTime(dtpTranzactie.Text);
            //var codClient = _client.CodClient;
            bool valid = true;


            if (!(int.TryParse(tbCodTranzactie.Text, out int a)))
            {
                errCod.SetError((Control)sender, "Introduceti codul tranzactiei!");
                valid = false;
            }

            if (!(DateTime.TryParse(dtpTranzactie.Text, out DateTime data)))
            {
                DateTime dataTranzactie = dtpTranzactie.Value;
                if (dataTranzactie >= DateTime.Today)
                {
                    errData.SetError((Control)sender, "Introduceti o data valida!");
                    valid = false;
                }
            }

            if (!(double.TryParse(tbValoare.Text, out double d)))
            {
                errValoare.SetError((Control)sender, "Introduceti valoarea tranzactiei!");
                valid = false;
            }

            if (string.IsNullOrEmpty(tbClient.Text))
            {
                errClient.SetError((Control)sender, "Adaugati un cod de client");
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show("Datele introduse contin erori!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listaTranzactii.Add(t);
            MessageBox.Show("Tranzactia a fost adaugata");
            tbCodTranzactie.Clear();
            tbValoare.Clear();
            dtpTranzactie.ResetText();
            tbClient.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbCodTranzactie.Clear();
            tbValoare.Clear();
            dtpTranzactie.ResetText();
            tbClient.ResetText();
            errClient.Clear();
        }


        private void btnAfiseazaTranzactii_Click(object sender, EventArgs e)
        {
            AfiseazaTranzactii();
        }

        private void AfiseazaTranzactii()
        {
            lvTransactions.Items.Clear();
            foreach (Tranzactie t in listaTranzactii)
            {
                ListViewItem itm = new ListViewItem(t.CodTranzactie.ToString());
                itm.SubItems.Add(t.Valoare.ToString());
                itm.SubItems.Add(t.Data.ToString());

                lvTransactions.Items.Add(itm);
            }
        }

        private void tbCodTranzactie_Validating(object sender, CancelEventArgs e)
        {
            string cod = ((TextBox)sender).Text;

            if (!(int.TryParse(cod, out int a)))
                e.Cancel = true;
            errCod.SetError((Control)sender, "Introduceti codul tranzactiei!");
        }

        private void tbCodTranzactie_Validated(object sender, EventArgs e)
        {
            errCod.Clear();
        }

        private void dtpTranzactie_Validating(object sender, CancelEventArgs e)
        {
            DateTime dataTranzactie = dtpTranzactie.Value;
            if (dataTranzactie > DateTime.Today)
            {
                errData.SetError((Control)sender, "Data tranzactiei nu poate fi in viitor!\nIntroduceti o data valida!");
                e.Cancel = true;
            }
        }

        private void dtpTranzactie_Validated(object sender, EventArgs e)
        {
            errData.Clear();
        }

        private void tbValoare_Validating(object sender, CancelEventArgs e)
        {
            string valoare = ((TextBox)sender).Text;

            if (!(double.TryParse(valoare, out double d)))
                e.Cancel = true;
            errValoare.SetError((Control)sender, "Introduceti valoarea produsului!");
        }

        private void tbValoare_Validated(object sender, EventArgs e)
        {
            errValoare.Clear();
        }

        private void tbClient_Validating(object sender, CancelEventArgs e)
        {
            string textClient = ((TextBox)sender).Text;

            if (string.IsNullOrEmpty(textClient))
            {
                e.Cancel = true;
                errClient.SetError((Control)sender, "Alegeti un cod de client");
            }
        }

        private void tbClient_Validated(object sender, EventArgs e)
        {

            errClient.Clear();
        }

        private void tbValoare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbCodTranzactie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void fisierBinarbinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("tranzactii.bin"))
            {
                formatter.Serialize(stream, listaTranzactii);
            }
            MessageBox.Show("Fisierul a fost salvat!", "Serializare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvTransactions.Items.Clear();
        }

        private void fisierBinarbinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("tranzactii.bin"))
            {
                listaTranzactii = (List<Tranzactie>)formatter.Deserialize(stream);
                AfiseazaTranzactii();
            }
        }

        private void fisierTexttxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Salvare lista tranzactii";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {

                    foreach (var tranzactie in listaTranzactii)
                    {
                        sw.WriteLine("{0}, {1}, {2}, {3}"
                            , tranzactie.CodTranzactie.ToString()
                            , tranzactie.Data.ToShortDateString()
                            , tranzactie.Valoare
                            , tranzactie.Client); ; ;

                    }
                    sw.Close();
                }
            }
        }

        private void listaTranzactiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfiseazaTranzactii();
        }

        private void stergereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvTransactions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege o tranzactie!");
                return;
            }

            if (MessageBox.Show(
                "Esti sigur?",
                "Sterge o tranzactie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem listViewItem = lvTransactions.SelectedItems[0];
                Client client = (Client)listViewItem.Tag;
                lvTransactions.Items.Remove(listViewItem);
            }
        }

        private void FormTranzactii_Load(object sender, EventArgs e)
        {
            try
            {

                lvTransactions.Focus();
                AfiseazaTranzactii();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvTransactions_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvTransactions.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStripTranzactii.Show(Cursor.Position);
                }
            }
        }

    }
}