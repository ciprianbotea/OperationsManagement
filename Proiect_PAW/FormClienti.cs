using Microsoft.Data.Sqlite;
using System;
using System.Collections;
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

    public partial class FormClienti : Form
    {

        private List<Client> listaClienti = new List<Client>();
        private const string connectionString = "Data Source=baza_de_date.db";
        //ArrayList listaClt = new ArrayList();

        public FormClienti(List<Client> listaClienti)
        {

            InitializeComponent();
            lvClients.Select();
            listaClienti = new List<Client>();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            long cod = Convert.ToInt32(tbCodClient.Text);
            string nume = tbNume.Text;
            string prenume = tbPrenume.Text;
            string telefon = tbTelefon.Text;
            string email = tbEmail.Text;
            string adresa = tbAdresa.Text;
            bool valid = true;

            Client c = new Client(cod, nume, prenume, telefon, email, adresa);

            if (!(long.TryParse(tbCodClient.Text, out long d)))
            {
                errCod.SetError((Control)sender, "Introduceti codul de  client!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(nume))
            {
                errNume.SetError((Control)sender, "Adaugati numele!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(prenume))
            {
                errPrenume.SetError((Control)sender, "Adaugati prenumele!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(telefon))
            {
                errTelefon.SetError((Control)sender, "Adaugati numarul de telefon!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                errEmail.SetError((Control)sender, "Adaugati adresa de email!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(adresa))
            {
                errAdresa.SetError((Control)sender, "Adaugati prenumele!");
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show("Datele introduse contin erori!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listaClienti.Add(c);
            MessageBox.Show("Clientul a fost adaugat");
            tbCodClient.Clear();
            tbNume.Clear();
            tbPrenume.Clear();
            tbTelefon.Clear();
            tbEmail.Clear();
            tbAdresa.Clear();
            AfiseazaClienti();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {

            tbCodClient.Clear();
            tbNume.Clear();
            tbPrenume.Clear();
            tbTelefon.Clear();
            tbEmail.Clear();
            tbAdresa.Clear();

        }

        private void btnAfiseazaClienti_Click(object sender, EventArgs e)
        {

            AfiseazaClienti();
        
        }

        public void AfiseazaClienti()
        {
           
            lvClients.Items.Clear();

            foreach (Client c in listaClienti)
            {
                var itm = new ListViewItem(c.CodClient.ToString());
                itm.SubItems.Add(c.Nume);
                itm.SubItems.Add(c.Prenume);
                itm.SubItems.Add(c.NrTel);
                itm.SubItems.Add(c.Email);
                itm.SubItems.Add(c.Adresa);
                itm.Tag = c;
                lvClients.Items.Add(itm);
            }
        }


        private void FormClienti_Load(object sender, EventArgs e)
        {
            try
            {

            lvClients.Focus();
            AfiseazaClienti();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void tbCodClient_Validating(object sender, CancelEventArgs e)
        {
            string cod = ((TextBox)sender).Text;

            if (!(long.TryParse(cod, out long d)))
                e.Cancel = true;
            errCod.SetError((Control)sender, "Introduceti codul de client!");
        }

        private void tbCodClient_Validated(object sender, EventArgs e)
        {
            errCod.Clear();
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            string nume = ((TextBox)sender).Text.Trim();

            if (string.IsNullOrWhiteSpace(nume))
            {
                e.Cancel = true;

                errNume.SetError((Control)sender, "Completati numele!");
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            errNume.Clear();
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            string prenume = ((TextBox)sender).Text.Trim();

            if (string.IsNullOrWhiteSpace(prenume))
            {
                e.Cancel = true;

                errPrenume.SetError((Control)sender, "Completati prenumele!");
            }
        }

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            errPrenume.Clear();
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            string telefon = ((TextBox)sender).Text.Trim();

            if (string.IsNullOrWhiteSpace(telefon))
            {
                e.Cancel = true;

                errTelefon.SetError((Control)sender, "Completati numarul de telefon!");
            }
        }

        private void tbTelefon_Validated(object sender, EventArgs e)
        {
            errTelefon.Clear();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = ((TextBox)sender).Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                e.Cancel = true;

                errEmail.SetError((Control)sender, "Completati adresa de email!");
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            errEmail.Clear();
        }

        private void tbAdresa_Validating(object sender, CancelEventArgs e)
        {
            string adresa = ((TextBox)sender).Text.Trim();

            if (string.IsNullOrWhiteSpace(adresa))
            {
                e.Cancel = true;

                errAdresa.SetError((Control)sender, "Introduceti adresa!");
            }
        }

        private void tbAdresa_Validated(object sender, EventArgs e)
        {
            errAdresa.Clear();
        }


        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbCodClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void serializareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("clienti.bin"))
            {
                formatter.Serialize(stream, listaClienti);
            }
            MessageBox.Show("Fisierul a fost salvat!", "Serializare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvClients.Items.Clear();
        }

        private void deserializareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("clienti.bin"))
            {
                listaClienti = (List<Client>)formatter.Deserialize(stream);
                AfiseazaClienti();
            }
        }

        private void serializareTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Salvare in fisier text";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {

                    foreach (var client in listaClienti)
                    {
                        sw.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}"
                            , client.CodClient.ToString()
                            , client.Nume
                            , client.Prenume
                            , client.NrTel
                            , client.Email
                            , client.Adresa);
                        //, client.DataNasterii.ToShortDateString()); ; ;

                    }
                    sw.Close();
                }
            }
        }

        private void editareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvClients.SelectedItems.Count == 0)

            {
                MessageBox.Show("Alegeti un client!");
                return;
            }

            ListViewItem listViewItem = lvClients.SelectedItems[0];


            Client client = (Client)listViewItem.Tag;

            EditareClienti editareClienti = new EditareClienti(client);
            if (editareClienti.ShowDialog() == DialogResult.OK)
                AfiseazaClienti();
        }

        private void stergereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(lvClients.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege un client!");
                return;
            }

            if (MessageBox.Show(
                "Esti sigur?",
                "Sterge un client",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem listViewItem = lvClients.SelectedItems[0];
                Client client = (Client)listViewItem.Tag;
                lvClients.Items.Remove(listViewItem);
            }
        }

        private void lvClients_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvClients.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStripClienti.Show(Cursor.Position);
                }
            }
        }


        private void AddClient(Client client)
        {
            string query = "INSERT INTO Clienti(Cod, Nume, Prenume, Telefon, Email, Adresa)" + "VALUES(@cod, @nume, @prenume, @telefon, @email, @adresa); SELECT last_insert_rowid()";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@cod", client.CodClient);
                command.Parameters.AddWithValue("@nume", client.Nume);
                command.Parameters.AddWithValue("@prenume", client.Prenume);
                command.Parameters.AddWithValue("@telefon", client.NrTel);
                command.Parameters.AddWithValue("@email", client.Email);
                command.Parameters.AddWithValue("@adresa", client.Adresa);


                connection.Open();
                command.ExecuteNonQuery();
                long cod = (long)command.ExecuteScalar();
                client.CodClient = cod;

                listaClienti.Add(client);
            }
        }
        private void LoadClients()
        {
            string query = "SELECT * FROM Clienti";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);

                connection.Open();
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long cod = (long)reader["Cod"];
                        string nume = (string)reader["Nume"];
                        string prenume = (string)reader["Prenume"];
                        string telefon = (string)reader["Telefon"];
                        string email = (string)reader["Email"];
                        string adresa = (string)reader["Adresa"];


                        //DateTime birthDate = DateTime.Parse((string)reader["BirthDate"]);

                        Client client = new Client(cod, nume, prenume, telefon, email, adresa);
                        listaClienti.Add(client);
                        AfiseazaClienti();
                    }
                }
            }
        }
        private void DeleteClient(Client client)
        {

            string query = "DELETE FROM Clienti WHERE codClient=@cod";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@cod", client.CodClient);

                connection.Open();

                command.ExecuteNonQuery();

                listaClienti.Remove(client);
            }
        }
        private void UpdateClient(Client client)
        {
            string query = "UPDATE Clienti SET Nume = @nume, Prenume = @prenume, NrTel = @telefon, Email = @email, Adresa = @adresa, WHERE CodClient = @cod";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@nume", client.Nume);
                command.Parameters.AddWithValue("@prenume", client.Prenume);
                command.Parameters.AddWithValue("@telefon", client.NrTel);
                command.Parameters.AddWithValue("@email", client.Email);
                command.Parameters.AddWithValue("@adresa", client.Adresa);


                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cod = Convert.ToInt32(tbCodClient.Text);
            var nume = tbNume.Text;
            var prenume = tbPrenume.Text;
            var telefon = tbTelefon.Text;
            var email = tbEmail.Text;
            var adresa = tbAdresa.Text;

            var client = new Client();

            try
            {
                AddClient(client);
                LoadClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void afiseazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void actualizeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stergereToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lvClients.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a participant");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete participant", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem selectedItem = lvClients.SelectedItems[0];
                    Client client = (Client)selectedItem.Tag;

                    DeleteClient(client);

                    LoadClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
