namespace Proiect_PAW
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ceas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnProduse = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.lbBunVenit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTranzactii = new System.Windows.Forms.Button();
            this.pbTranzactii = new System.Windows.Forms.PictureBox();
            this.pbClienti = new System.Windows.Forms.PictureBox();
            this.pbProduse = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cliențiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzacțiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbTranzactii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ceas
            // 
            this.ceas.AutoSize = true;
            this.ceas.BackColor = System.Drawing.Color.SteelBlue;
            this.ceas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceas.ForeColor = System.Drawing.Color.SeaShell;
            this.ceas.Location = new System.Drawing.Point(676, 216);
            this.ceas.Name = "ceas";
            this.ceas.Size = new System.Drawing.Size(113, 23);
            this.ceas.TabIndex = 5;
            this.ceas.Text = "00:00:00 tt";
            this.ceas.Click += new System.EventHandler(this.ceas_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnProduse
            // 
            this.btnProduse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduse.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnProduse.Location = new System.Drawing.Point(9, 202);
            this.btnProduse.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduse.Name = "btnProduse";
            this.btnProduse.Size = new System.Drawing.Size(158, 40);
            this.btnProduse.TabIndex = 6;
            this.btnProduse.Text = "&Produse";
            this.btnProduse.UseVisualStyleBackColor = true;
            this.btnProduse.Click += new System.EventHandler(this.btnProduse_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienti.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClienti.Location = new System.Drawing.Point(231, 202);
            this.btnClienti.Margin = new System.Windows.Forms.Padding(0);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(172, 40);
            this.btnClienti.TabIndex = 7;
            this.btnClienti.Text = "&Clienți";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // lbBunVenit
            // 
            this.lbBunVenit.AutoSize = true;
            this.lbBunVenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBunVenit.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbBunVenit.Location = new System.Drawing.Point(675, 73);
            this.lbBunVenit.Name = "lbBunVenit";
            this.lbBunVenit.Size = new System.Drawing.Size(99, 25);
            this.lbBunVenit.TabIndex = 9;
            this.lbBunVenit.Text = "Bun venit!";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Linen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(680, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 32);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTranzactii
            // 
            this.btnTranzactii.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranzactii.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTranzactii.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTranzactii.Location = new System.Drawing.Point(460, 202);
            this.btnTranzactii.Margin = new System.Windows.Forms.Padding(0);
            this.btnTranzactii.Name = "btnTranzactii";
            this.btnTranzactii.Size = new System.Drawing.Size(164, 40);
            this.btnTranzactii.TabIndex = 8;
            this.btnTranzactii.Text = "&Tranzacții";
            this.btnTranzactii.UseVisualStyleBackColor = true;
            this.btnTranzactii.Click += new System.EventHandler(this.btnTranzactii_Click);
            // 
            // pbTranzactii
            // 
            this.pbTranzactii.Image = ((System.Drawing.Image)(resources.GetObject("pbTranzactii.Image")));
            this.pbTranzactii.Location = new System.Drawing.Point(460, 73);
            this.pbTranzactii.Name = "pbTranzactii";
            this.pbTranzactii.Size = new System.Drawing.Size(164, 109);
            this.pbTranzactii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTranzactii.TabIndex = 11;
            this.pbTranzactii.TabStop = false;
            // 
            // pbClienti
            // 
            this.pbClienti.Image = ((System.Drawing.Image)(resources.GetObject("pbClienti.Image")));
            this.pbClienti.Location = new System.Drawing.Point(231, 73);
            this.pbClienti.Name = "pbClienti";
            this.pbClienti.Size = new System.Drawing.Size(172, 109);
            this.pbClienti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClienti.TabIndex = 12;
            this.pbClienti.TabStop = false;
            // 
            // pbProduse
            // 
            this.pbProduse.Image = ((System.Drawing.Image)(resources.GetObject("pbProduse.Image")));
            this.pbProduse.Location = new System.Drawing.Point(9, 73);
            this.pbProduse.Name = "pbProduse";
            this.pbProduse.Size = new System.Drawing.Size(158, 109);
            this.pbProduse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduse.TabIndex = 13;
            this.pbProduse.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.cliențiToolStripMenuItem,
            this.tranzacțiiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 36);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // cliențiToolStripMenuItem
            // 
            this.cliențiToolStripMenuItem.Name = "cliențiToolStripMenuItem";
            this.cliențiToolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.cliențiToolStripMenuItem.Text = "Clienți";
            this.cliențiToolStripMenuItem.Click += new System.EventHandler(this.cliențiToolStripMenuItem_Click);
            // 
            // tranzacțiiToolStripMenuItem
            // 
            this.tranzacțiiToolStripMenuItem.Name = "tranzacțiiToolStripMenuItem";
            this.tranzacțiiToolStripMenuItem.Size = new System.Drawing.Size(99, 32);
            this.tranzacțiiToolStripMenuItem.Text = "Tranzacții";
            this.tranzacțiiToolStripMenuItem.Click += new System.EventHandler(this.tranzacțiiToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(820, 285);
            this.Controls.Add(this.pbProduse);
            this.Controls.Add(this.pbClienti);
            this.Controls.Add(this.pbTranzactii);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbBunVenit);
            this.Controls.Add(this.btnTranzactii);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.btnProduse);
            this.Controls.Add(this.ceas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Gestiune vanzari";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTranzactii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ceas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnProduse;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnTranzactii;
        private System.Windows.Forms.Label lbBunVenit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbTranzactii;
        private System.Windows.Forms.PictureBox pbClienti;
        private System.Windows.Forms.PictureBox pbProduse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cliențiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzacțiiToolStripMenuItem;
    }
}

