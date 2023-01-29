namespace Proiect_PAW
{
    partial class FormClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClienti));
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbNume = new System.Windows.Forms.Label();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbCodClient = new System.Windows.Forms.Label();
            this.tbCodClient = new System.Windows.Forms.TextBox();
            this.btnAfiseazaClienti = new System.Windows.Forms.Button();
            this.lvClients = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareListaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripClienti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTranzactie = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCod = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrenume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAdresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTranzactie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCod)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(128, 112);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(187, 26);
            this.tbNume.TabIndex = 0;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(22, 112);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(51, 20);
            this.lbNume.TabIndex = 1;
            this.lbNume.Text = "Nume";
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(22, 165);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(73, 20);
            this.lbPrenume.TabIndex = 3;
            this.lbPrenume.Text = "Prenume";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(128, 165);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(187, 26);
            this.tbPrenume.TabIndex = 2;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(22, 221);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(62, 20);
            this.lbTelefon.TabIndex = 5;
            this.lbTelefon.Text = "Telefon";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(128, 221);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(187, 26);
            this.tbTelefon.TabIndex = 4;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            this.tbTelefon.Validated += new System.EventHandler(this.tbTelefon_Validated);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(22, 273);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 20);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(128, 273);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(187, 26);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(22, 326);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(60, 20);
            this.lbAdresa.TabIndex = 9;
            this.lbAdresa.Text = "Adresa";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(128, 326);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(187, 26);
            this.tbAdresa.TabIndex = 8;
            this.tbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresa_Validating);
            this.tbAdresa.Validated += new System.EventHandler(this.tbAdresa_Validated);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOK.Location = new System.Drawing.Point(24, 379);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 40);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Adauga";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(206, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbCodClient
            // 
            this.lbCodClient.AutoSize = true;
            this.lbCodClient.Location = new System.Drawing.Point(22, 58);
            this.lbCodClient.Name = "lbCodClient";
            this.lbCodClient.Size = new System.Drawing.Size(79, 20);
            this.lbCodClient.TabIndex = 16;
            this.lbCodClient.Text = "Cod client";
            // 
            // tbCodClient
            // 
            this.tbCodClient.Location = new System.Drawing.Point(128, 58);
            this.tbCodClient.Name = "tbCodClient";
            this.tbCodClient.Size = new System.Drawing.Size(187, 26);
            this.tbCodClient.TabIndex = 15;
            this.tbCodClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodClient_KeyPress);
            this.tbCodClient.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodClient_Validating);
            this.tbCodClient.Validated += new System.EventHandler(this.tbCodClient_Validated);
            // 
            // btnAfiseazaClienti
            // 
            this.btnAfiseazaClienti.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfiseazaClienti.Location = new System.Drawing.Point(26, 436);
            this.btnAfiseazaClienti.Name = "btnAfiseazaClienti";
            this.btnAfiseazaClienti.Size = new System.Drawing.Size(289, 39);
            this.btnAfiseazaClienti.TabIndex = 18;
            this.btnAfiseazaClienti.Text = "Afiseaza lista clientilor";
            this.btnAfiseazaClienti.UseVisualStyleBackColor = false;
            this.btnAfiseazaClienti.Click += new System.EventHandler(this.btnAfiseazaClienti_Click);
            // 
            // lvClients
            // 
            this.lvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvClients.BackColor = System.Drawing.Color.White;
            this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvClients.FullRowSelect = true;
            this.lvClients.GridLines = true;
            this.lvClients.HideSelection = false;
            this.lvClients.Location = new System.Drawing.Point(345, 58);
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(695, 417);
            this.lvClients.TabIndex = 23;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            this.lvClients.View = System.Windows.Forms.View.Details;
            this.lvClients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvClients_MouseClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cod";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adresa";
            this.columnHeader6.Width = 120;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.vizualizareToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.bazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 33);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.importareToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareBinarToolStripMenuItem,
            this.serializareTextToolStripMenuItem});
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.salvareToolStripMenuItem.Text = "Salvare ca...";
            // 
            // serializareBinarToolStripMenuItem
            // 
            this.serializareBinarToolStripMenuItem.Name = "serializareBinarToolStripMenuItem";
            this.serializareBinarToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.serializareBinarToolStripMenuItem.Text = "Fisier binar (.bin)";
            this.serializareBinarToolStripMenuItem.Click += new System.EventHandler(this.serializareBinarToolStripMenuItem_Click);
            // 
            // serializareTextToolStripMenuItem
            // 
            this.serializareTextToolStripMenuItem.Name = "serializareTextToolStripMenuItem";
            this.serializareTextToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.serializareTextToolStripMenuItem.Text = "Fisier text (.txt)";
            this.serializareTextToolStripMenuItem.Click += new System.EventHandler(this.serializareTextToolStripMenuItem_Click);
            // 
            // importareToolStripMenuItem
            // 
            this.importareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deserializareBinarToolStripMenuItem});
            this.importareToolStripMenuItem.Name = "importareToolStripMenuItem";
            this.importareToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.importareToolStripMenuItem.Text = "Importare din..";
            // 
            // deserializareBinarToolStripMenuItem
            // 
            this.deserializareBinarToolStripMenuItem.Name = "deserializareBinarToolStripMenuItem";
            this.deserializareBinarToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.deserializareBinarToolStripMenuItem.Text = "Fisier binar (.bin)";
            this.deserializareBinarToolStripMenuItem.Click += new System.EventHandler(this.deserializareBinarToolStripMenuItem_Click);
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareListaClientiToolStripMenuItem});
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            // 
            // vizualizareListaClientiToolStripMenuItem
            // 
            this.vizualizareListaClientiToolStripMenuItem.Name = "vizualizareListaClientiToolStripMenuItem";
            this.vizualizareListaClientiToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.vizualizareListaClientiToolStripMenuItem.Text = "Lista clienti";
            this.vizualizareListaClientiToolStripMenuItem.Click += new System.EventHandler(this.btnAfiseazaClienti_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem1,
            this.stergereToolStripMenuItem1});
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.stergeToolStripMenuItem.Text = "Instrumente";
            // 
            // editareToolStripMenuItem1
            // 
            this.editareToolStripMenuItem1.Name = "editareToolStripMenuItem1";
            this.editareToolStripMenuItem1.Size = new System.Drawing.Size(179, 34);
            this.editareToolStripMenuItem1.Text = "Editare";
            this.editareToolStripMenuItem1.Click += new System.EventHandler(this.editareToolStripMenuItem1_Click);
            // 
            // stergereToolStripMenuItem1
            // 
            this.stergereToolStripMenuItem1.Name = "stergereToolStripMenuItem1";
            this.stergereToolStripMenuItem1.Size = new System.Drawing.Size(179, 34);
            this.stergereToolStripMenuItem1.Text = "Stergere";
            this.stergereToolStripMenuItem1.Click += new System.EventHandler(this.stergereToolStripMenuItem1_Click);
            // 
            // bazaDeDateToolStripMenuItem
            // 
            this.bazaDeDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afiseazaToolStripMenuItem,
            this.adaugaToolStripMenuItem,
            this.actualizeazaToolStripMenuItem,
            this.stergereToolStripMenuItem2});
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de date";
            // 
            // afiseazaToolStripMenuItem
            // 
            this.afiseazaToolStripMenuItem.Name = "afiseazaToolStripMenuItem";
            this.afiseazaToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.afiseazaToolStripMenuItem.Text = "Afisare";
            this.afiseazaToolStripMenuItem.Click += new System.EventHandler(this.afiseazaToolStripMenuItem_Click);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.adaugaToolStripMenuItem.Text = "Adaugare";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // actualizeazaToolStripMenuItem
            // 
            this.actualizeazaToolStripMenuItem.Name = "actualizeazaToolStripMenuItem";
            this.actualizeazaToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.actualizeazaToolStripMenuItem.Text = "Actualizare";
            this.actualizeazaToolStripMenuItem.Click += new System.EventHandler(this.actualizeazaToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem2
            // 
            this.stergereToolStripMenuItem2.Name = "stergereToolStripMenuItem2";
            this.stergereToolStripMenuItem2.Size = new System.Drawing.Size(199, 34);
            this.stergereToolStripMenuItem2.Text = "Stergere";
            this.stergereToolStripMenuItem2.Click += new System.EventHandler(this.stergereToolStripMenuItem2_Click);
            // 
            // contextMenuStripClienti
            // 
            this.contextMenuStripClienti.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripClienti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem,
            this.stergereToolStripMenuItem});
            this.contextMenuStripClienti.Name = "contextMenuStrip1";
            this.contextMenuStripClienti.Size = new System.Drawing.Size(150, 68);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.editareToolStripMenuItem1_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem1_Click);
            // 
            // errNume
            // 
            this.errNume.ContainerControl = this;
            // 
            // errPrenume
            // 
            this.errPrenume.ContainerControl = this;
            // 
            // errTelefon
            // 
            this.errTelefon.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // errAdresa
            // 
            this.errAdresa.ContainerControl = this;
            // 
            // errTranzactie
            // 
            this.errTranzactie.ContainerControl = this;
            // 
            // errCod
            // 
            this.errCod.ContainerControl = this;
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1072, 492);
            this.Controls.Add(this.lvClients);
            this.Controls.Add(this.btnAfiseazaClienti);
            this.Controls.Add(this.lbCodClient);
            this.Controls.Add(this.tbCodClient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.lbPrenume);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormClienti";
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.FormClienti_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripClienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrenume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTelefon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAdresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTranzactie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbCodClient;
        private System.Windows.Forms.TextBox tbCodClient;
        private System.Windows.Forms.Button btnAfiseazaClienti;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClienti;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errNume;
        private System.Windows.Forms.ErrorProvider errPrenume;
        private System.Windows.Forms.ErrorProvider errTelefon;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errAdresa;
        private System.Windows.Forms.ErrorProvider errTranzactie;
        private System.Windows.Forms.ErrorProvider errCod;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareListaClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem2;
    }
}