namespace Proiect_PAW
{
    partial class FormTranzactii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTranzactii));
            this.lbCodClient = new System.Windows.Forms.Label();
            this.tbCodTranzactie = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbClient = new System.Windows.Forms.Label();
            this.lbValoare = new System.Windows.Forms.Label();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.dtpTranzactie = new System.Windows.Forms.DateTimePicker();
            this.btnAfiseazaTranzactii = new System.Windows.Forms.Button();
            this.lvTransactions = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripTranzactii = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierBinarbinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTexttxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importareDinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierBinarbinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaTranzactiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTranzactii = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errCod = new System.Windows.Forms.ErrorProvider(this.components);
            this.errData = new System.Windows.Forms.ErrorProvider(this.components);
            this.errValoare = new System.Windows.Forms.ErrorProvider(this.components);
            this.errClient = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbClient = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStripTranzactii.SuspendLayout();
            this.contextMenuStripTranzactii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errValoare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodClient
            // 
            this.lbCodClient.AutoSize = true;
            this.lbCodClient.Location = new System.Drawing.Point(24, 58);
            this.lbCodClient.Name = "lbCodClient";
            this.lbCodClient.Size = new System.Drawing.Size(112, 20);
            this.lbCodClient.TabIndex = 33;
            this.lbCodClient.Text = "Cod tranzactie";
            // 
            // tbCodTranzactie
            // 
            this.tbCodTranzactie.Location = new System.Drawing.Point(140, 58);
            this.tbCodTranzactie.Name = "tbCodTranzactie";
            this.tbCodTranzactie.Size = new System.Drawing.Size(187, 26);
            this.tbCodTranzactie.TabIndex = 32;
            this.tbCodTranzactie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodTranzactie_KeyPress);
            this.tbCodTranzactie.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodTranzactie_Validating);
            this.tbCodTranzactie.Validated += new System.EventHandler(this.tbCodTranzactie_Validated);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(207, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOK.Location = new System.Drawing.Point(28, 271);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 40);
            this.btnOK.TabIndex = 27;
            this.btnOK.Text = "Adauga";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(24, 225);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(49, 20);
            this.lbClient.TabIndex = 22;
            this.lbClient.Text = "Client";
            // 
            // lbValoare
            // 
            this.lbValoare.AutoSize = true;
            this.lbValoare.Location = new System.Drawing.Point(24, 168);
            this.lbValoare.Name = "lbValoare";
            this.lbValoare.Size = new System.Drawing.Size(64, 20);
            this.lbValoare.TabIndex = 20;
            this.lbValoare.Text = "Valoare";
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(140, 166);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.Size = new System.Drawing.Size(187, 26);
            this.tbValoare.TabIndex = 19;
            this.tbValoare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValoare_KeyPress);
            this.tbValoare.Validating += new System.ComponentModel.CancelEventHandler(this.tbValoare_Validating);
            this.tbValoare.Validated += new System.EventHandler(this.tbValoare_Validated);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(24, 120);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(44, 20);
            this.lbData.TabIndex = 18;
            this.lbData.Text = "Data";
            // 
            // dtpTranzactie
            // 
            this.dtpTranzactie.Location = new System.Drawing.Point(140, 114);
            this.dtpTranzactie.Name = "dtpTranzactie";
            this.dtpTranzactie.Size = new System.Drawing.Size(187, 26);
            this.dtpTranzactie.TabIndex = 34;
            this.dtpTranzactie.Validating += new System.ComponentModel.CancelEventHandler(this.dtpTranzactie_Validating);
            this.dtpTranzactie.Validated += new System.EventHandler(this.dtpTranzactie_Validated);
            // 
            // btnAfiseazaTranzactii
            // 
            this.btnAfiseazaTranzactii.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfiseazaTranzactii.Location = new System.Drawing.Point(28, 354);
            this.btnAfiseazaTranzactii.Name = "btnAfiseazaTranzactii";
            this.btnAfiseazaTranzactii.Size = new System.Drawing.Size(290, 38);
            this.btnAfiseazaTranzactii.TabIndex = 36;
            this.btnAfiseazaTranzactii.Text = "Afiseaza lista tranzactiilor";
            this.btnAfiseazaTranzactii.UseVisualStyleBackColor = false;
            this.btnAfiseazaTranzactii.Click += new System.EventHandler(this.btnAfiseazaTranzactii_Click);
            // 
            // lvTransactions
            // 
            this.lvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvTransactions.FullRowSelect = true;
            this.lvTransactions.GridLines = true;
            this.lvTransactions.HideSelection = false;
            this.lvTransactions.Location = new System.Drawing.Point(399, 58);
            this.lvTransactions.Name = "lvTransactions";
            this.lvTransactions.Size = new System.Drawing.Size(525, 334);
            this.lvTransactions.TabIndex = 35;
            this.lvTransactions.UseCompatibleStateImageBehavior = false;
            this.lvTransactions.View = System.Windows.Forms.View.Details;
            this.lvTransactions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvTransactions_MouseClick);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Cod";
            this.columnHeader11.Width = 50;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Data";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Valoare";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Client";
            this.columnHeader14.Width = 100;
            // 
            // menuStripTranzactii
            // 
            this.menuStripTranzactii.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripTranzactii.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripTranzactii.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.vizualizareToolStripMenuItem,
            this.instrumenteToolStripMenuItem});
            this.menuStripTranzactii.Location = new System.Drawing.Point(0, 0);
            this.menuStripTranzactii.Name = "menuStripTranzactii";
            this.menuStripTranzactii.Size = new System.Drawing.Size(970, 33);
            this.menuStripTranzactii.TabIndex = 37;
            this.menuStripTranzactii.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareCaToolStripMenuItem,
            this.importareDinToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareCaToolStripMenuItem
            // 
            this.salvareCaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierBinarbinToolStripMenuItem,
            this.fisierTexttxtToolStripMenuItem});
            this.salvareCaToolStripMenuItem.Name = "salvareCaToolStripMenuItem";
            this.salvareCaToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.salvareCaToolStripMenuItem.Text = "Salvare ca...";
            // 
            // fisierBinarbinToolStripMenuItem
            // 
            this.fisierBinarbinToolStripMenuItem.Name = "fisierBinarbinToolStripMenuItem";
            this.fisierBinarbinToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.fisierBinarbinToolStripMenuItem.Text = "Fisier binar (.bin)";
            this.fisierBinarbinToolStripMenuItem.Click += new System.EventHandler(this.fisierBinarbinToolStripMenuItem_Click);
            // 
            // fisierTexttxtToolStripMenuItem
            // 
            this.fisierTexttxtToolStripMenuItem.Name = "fisierTexttxtToolStripMenuItem";
            this.fisierTexttxtToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.fisierTexttxtToolStripMenuItem.Text = "Fisier text (.txt)";
            this.fisierTexttxtToolStripMenuItem.Click += new System.EventHandler(this.fisierTexttxtToolStripMenuItem_Click);
            // 
            // importareDinToolStripMenuItem
            // 
            this.importareDinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierBinarbinToolStripMenuItem1});
            this.importareDinToolStripMenuItem.Name = "importareDinToolStripMenuItem";
            this.importareDinToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.importareDinToolStripMenuItem.Text = "Importare din...";
            // 
            // fisierBinarbinToolStripMenuItem1
            // 
            this.fisierBinarbinToolStripMenuItem1.Name = "fisierBinarbinToolStripMenuItem1";
            this.fisierBinarbinToolStripMenuItem1.Size = new System.Drawing.Size(243, 34);
            this.fisierBinarbinToolStripMenuItem1.Text = "Fisier binar (.bin)";
            this.fisierBinarbinToolStripMenuItem1.Click += new System.EventHandler(this.fisierBinarbinToolStripMenuItem1_Click);
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaTranzactiiToolStripMenuItem});
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            // 
            // listaTranzactiiToolStripMenuItem
            // 
            this.listaTranzactiiToolStripMenuItem.Name = "listaTranzactiiToolStripMenuItem";
            this.listaTranzactiiToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.listaTranzactiiToolStripMenuItem.Text = "Lista tranzactii";
            this.listaTranzactiiToolStripMenuItem.Click += new System.EventHandler(this.listaTranzactiiToolStripMenuItem_Click);
            // 
            // instrumenteToolStripMenuItem
            // 
            this.instrumenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem,
            this.stergereToolStripMenuItem1});
            this.instrumenteToolStripMenuItem.Name = "instrumenteToolStripMenuItem";
            this.instrumenteToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.instrumenteToolStripMenuItem.Text = "Instrumente";
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.editareToolStripMenuItem.Text = "Editare";
            // 
            // stergereToolStripMenuItem1
            // 
            this.stergereToolStripMenuItem1.Name = "stergereToolStripMenuItem1";
            this.stergereToolStripMenuItem1.Size = new System.Drawing.Size(179, 34);
            this.stergereToolStripMenuItem1.Text = "Stergere";
            this.stergereToolStripMenuItem1.Click += new System.EventHandler(this.stergereToolStripMenuItem1_Click);
            // 
            // contextMenuStripTranzactii
            // 
            this.contextMenuStripTranzactii.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripTranzactii.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem1,
            this.stergereToolStripMenuItem});
            this.contextMenuStripTranzactii.Name = "contextMenuStrip1";
            this.contextMenuStripTranzactii.Size = new System.Drawing.Size(241, 101);
            // 
            // editeazaToolStripMenuItem1
            // 
            this.editeazaToolStripMenuItem1.Name = "editeazaToolStripMenuItem1";
            this.editeazaToolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.editeazaToolStripMenuItem1.Text = "Editare";
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem1_Click);
            // 
            // errCod
            // 
            this.errCod.ContainerControl = this;
            // 
            // errData
            // 
            this.errData.ContainerControl = this;
            // 
            // errValoare
            // 
            this.errValoare.ContainerControl = this;
            // 
            // errClient
            // 
            this.errClient.ContainerControl = this;
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(140, 218);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(187, 26);
            this.tbClient.TabIndex = 44;
            this.tbClient.Validating += new System.ComponentModel.CancelEventHandler(this.tbClient_Validating);
            this.tbClient.Validated += new System.EventHandler(this.tbClient_Validated);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Proiect_PAW.Client);
            // 
            // FormTranzactii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(970, 412);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.btnAfiseazaTranzactii);
            this.Controls.Add(this.lvTransactions);
            this.Controls.Add(this.dtpTranzactie);
            this.Controls.Add(this.lbCodClient);
            this.Controls.Add(this.tbCodTranzactie);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.lbValoare);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.menuStripTranzactii);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripTranzactii;
            this.Name = "FormTranzactii";
            this.Text = "Tranzactii";
            this.Load += new System.EventHandler(this.FormTranzactii_Load);
            this.menuStripTranzactii.ResumeLayout(false);
            this.menuStripTranzactii.PerformLayout();
            this.contextMenuStripTranzactii.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errValoare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodClient;
        private System.Windows.Forms.TextBox tbCodTranzactie;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.Label lbValoare;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DateTimePicker dtpTranzactie;
        private System.Windows.Forms.Button btnAfiseazaTranzactii;
        private System.Windows.Forms.ListView lvTransactions;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.MenuStrip menuStripTranzactii;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTranzactii;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errCod;
        private System.Windows.Forms.ErrorProvider errData;
        private System.Windows.Forms.ErrorProvider errValoare;
        private System.Windows.Forms.ErrorProvider errClient;
        private System.Windows.Forms.ToolStripMenuItem instrumenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareCaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierBinarbinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTexttxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importareDinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierBinarbinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaTranzactiiToolStripMenuItem;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem1;
    }
}