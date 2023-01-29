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
    public partial class MainForm : Form
    {
        private List<Client> clienti;
        private List<Produs> produse;
        private List<Tranzactie> tranzactii;
        internal static object listaClienti;

        public MainForm()
        {
            InitializeComponent();
            clienti = new List<Client>();
            produse = new List<Produs>();
            tranzactii = new List<Tranzactie>();
        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduse form = new FormProduse(produse);
            form.ShowDialog();
        }

        private void cliențiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienti form = new FormClienti(clienti);
            form.ShowDialog();
        }

        private void tranzacțiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTranzactii form = new FormTranzactii(tranzactii);
            form.ShowDialog();
        }



        private void ceas_Click(object sender, EventArgs e)
        {
            //ceas.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ceas.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            //timer2.Start();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                ceas.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }));
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ciprian");
        }


        private void btnClienti_Click(object sender, EventArgs e)
        {
            FormClienti form = new FormClienti(clienti);
            form.ShowDialog();
        }

        private void btnProduse_Click(object sender, EventArgs e)
        {
            FormProduse form = new FormProduse(produse);
            form.ShowDialog();
        }

        private void btnTranzactii_Click(object sender, EventArgs e)
        {
            FormTranzactii form = new FormTranzactii(tranzactii);
            form.ShowDialog();
        }


    }
}
