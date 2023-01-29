using Microsoft.Data.Sqlite;
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

    public partial class FormProduse : Form
    {
        
        private List<Produs> listaProduse = new List<Produs>();
        private const string connectionString = "Data Source=baza_de_date.db";

        public FormProduse(List<Produs> listaProduse)
        {
        
            InitializeComponent();
            lvProducts.Select();
            listaProduse = new List<Produs>();

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            Produs p = new Produs();
            p.CodProdus = Convert.ToInt32(tbCodProdus.Text);
            p.Denumire = tbDenumire.Text;
            p.Pret = Convert.ToDouble(tbPret.Text);
            p.Cantitate = Convert.ToInt32(tbCantitate.Text);
            bool valid = true;

            if (!(int.TryParse(tbCodProdus.Text, out int a)))
            {
                errCod.SetError((Control)sender, "Introduceti codul produsului!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(p.Denumire))
            {
                errDenumire.SetError((Control)sender, "Introduceti denumirea produsului!");
                valid = false;
            }

            if (!(double.TryParse(tbPret.Text, out double d)))
            {
                errPret.SetError((Control)sender, "Introduceti codul produsului!");
                valid = false;
            }

            if (!(int.TryParse(tbCantitate.Text, out int b)))
            {
                errCantitate.SetError((Control)sender, "Introduceti cantitatea existenta!");
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show("Datele introduse contin erori!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listaProduse.Add(p);
            MessageBox.Show("Produsul a fost adaugat");
            tbCodProdus.Clear();
            tbDenumire.Clear();
            tbPret.Clear();
            tbCantitate.Clear();
            AfiseazaProduse();

        }

        private void btnAfiseazaProduse_Click(object sender, EventArgs e)
        {
            AfiseazaProduse();
        }

        private void AfiseazaProduse()
        {
            lvProducts.Items.Clear();
            foreach (Produs p in listaProduse)
            {
                ListViewItem itm = new ListViewItem(p.CodProdus.ToString());
                itm.SubItems.Add(p.Denumire);
                itm.SubItems.Add(p.Pret.ToString());
                itm.SubItems.Add(p.Cantitate.ToString());
                itm.Tag = p;
                lvProducts.Items.Add(itm);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbCodProdus.Clear();
            tbDenumire.Clear();
            tbPret.Clear();
            tbCantitate.Clear();
        }


        private void tbCodProdus_Validating(object sender, CancelEventArgs e)
        {
            string cod = ((TextBox)sender).Text;

            if (!(int.TryParse(cod, out int a)))
                e.Cancel = true;
            errCod.SetError((Control)sender, "Introduceti codul produsului!");
        }

        private void tbCodProdus_Validated(object sender, EventArgs e)
        {
            errCod.Clear();
        }

        private void tbDenumire_Validating(object sender, CancelEventArgs e)
        {
            string denumire = ((TextBox)sender).Text.Trim();

            if (string.IsNullOrWhiteSpace(denumire))
            {
                e.Cancel = true;

                errDenumire.SetError((Control)sender, "Introduceti denumirea produsului!");
            }
        }

        private void tbDenumire_Validated(object sender, EventArgs e)
        {
            errDenumire.Clear();        
        }

        private void tbPret_Validating(object sender, CancelEventArgs e)
        {
            string pret = ((TextBox)sender).Text;

            if (!(double.TryParse(pret, out double d)))
                e.Cancel = true;
            errPret.SetError((Control)sender, "Introduceti pretul produsului!");
        }

        private void tbPret_Validated(object sender, EventArgs e)
        {
            errPret.Clear();
        }

        private void tbCantitate_Validating(object sender, CancelEventArgs e)
        {
            string cantitate = ((TextBox)sender).Text;

            if (!(int.TryParse(cantitate, out int b)))
                e.Cancel = true;
            errCantitate.SetError((Control)sender, "Introduceti cantitatea disponibila!");
        }

        private void tbCantitate_Validated(object sender, EventArgs e)
        {
            errCantitate.Clear();
        }

        private void tbCodProdus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbCantitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void fisierBinarbinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("produse.bin"))
            {
                formatter.Serialize(stream, listaProduse);
            }
            MessageBox.Show("Fisierul a fost salvat!", "Serializare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvProducts.Items.Clear();
        }

        private void fisierBinarbinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("produse.bin"))
            {
                listaProduse = (List<Produs>)formatter.Deserialize(stream);
                AfiseazaProduse();
            }
        }

        private void fisierTexttxtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Salvare lista produse";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {

                    foreach (var produs in listaProduse)
                    {
                        sw.WriteLine("{0}, {1}, {2}, {3}"
                            , produs.CodProdus.ToString()
                            , produs.Denumire
                            , produs.Pret.ToString()
                            , produs.Cantitate.ToString()); ; ;
                        //, client.DataNasterii.ToShortDateString()); ; ;

                    }
                    sw.Close();
                }
            }
        }


        private void editareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)

            {
                MessageBox.Show("Alegeti un produs!");
                return;
            }


            ListViewItem listViewItem = lvProducts.SelectedItems[0];

            Produs produs = (Produs)listViewItem.Tag;

            EditareProduse editareProduse = new EditareProduse(produs);
            if (editareProduse.ShowDialog() == DialogResult.OK)
                AfiseazaProduse();
        }


        private void stergereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege un produs!");
                return;
            }

            if (MessageBox.Show(
                "Esti sigur?",
                "Sterge un produs",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem listViewItem = lvProducts.SelectedItems[0];
                Produs produs = (Produs)listViewItem.Tag;
                lvProducts.Items.Remove(listViewItem);
            }
        }


        private void lvProducts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvProducts.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStripProduse.Show(Cursor.Position);
                }
            }
        }


        private void AddProduct(Produs produs)
        {
            var query = "INSERT INTO Produse(Cod, Denumire, Pret, Cantitate)" + "VALUES(@cod, @denumire, @pret, @cantitate)" + "SELECT last_insert_rowid()";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@cod", produs.CodProdus);
                command.Parameters.AddWithValue("@denumire", produs.Denumire);
                command.Parameters.AddWithValue("@pret", produs.Pret);
                command.Parameters.AddWithValue("@cantitate", produs.Cantitate);



                connection.Open();
                produs.CodProdus = (long)command.ExecuteScalar();
                listaProduse.Add(produs);
            }
        }
        private void LoadProducts()
        {
            string query = "SELECT * FROM Produse";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);

                connection.Open();
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long cod = (long)reader["Cod"];
                        string denumire = (string)reader["Denumire"];
                        double pret = (double)reader["Pret"];
                        long cantitate = (long)reader["Cantitate"];                
                        Produs produs = new Produs(cod, denumire, pret, cantitate);
                        listaProduse.Add(produs);
                        AfiseazaProduse();
                    }
                }
            }
        }


        private void DeleteProducts(Produs produs)
        {

            string query = "DELETE FROM Produse WHERE Cod=@cod";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@cod", produs.CodProdus);

                connection.Open();

                command.ExecuteNonQuery();

                listaProduse.Remove(produs);
            }
        }
        private void UpdateProducts(Produs produs)
        {
            string query = "UPDATE Produse SET Denumire= @denumire, Pret = @pret, Cantitate = @cantitate, WHERE Cod = @cod";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@denumire", produs.Denumire);
                command.Parameters.AddWithValue("@pret", produs.Pret);
                command.Parameters.AddWithValue("@cantitate", produs.Cantitate);



                connection.Open();

                produs.CodProdus = (long)command.ExecuteScalar();
                
            }
        }

        private void afisareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

    }

}
