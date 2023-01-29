namespace Proiect_PAW
{
    partial class FormProduse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduse));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbCantitate = new System.Windows.Forms.Label();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.lbPret = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.lbDenumire = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.lbCodProdus = new System.Windows.Forms.Label();
            this.tbCodProdus = new System.Windows.Forms.TextBox();
            this.btnAfiseazaProduse = new System.Windows.Forms.Button();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripProduse = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierBinarbinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTexttxtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importareDinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierBinarbinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProduse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errCod = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDenumire = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPret = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCantitate = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStripProduse.SuspendLayout();
            this.contextMenuStripProduse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDenumire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(209, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 40);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOK.Location = new System.Drawing.Point(26, 287);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 40);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "Adauga";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbCantitate
            // 
            this.lbCantitate.AutoSize = true;
            this.lbCantitate.Location = new System.Drawing.Point(22, 217);
            this.lbCantitate.Name = "lbCantitate";
            this.lbCantitate.Size = new System.Drawing.Size(74, 20);
            this.lbCantitate.TabIndex = 19;
            this.lbCantitate.Text = "Cantitate";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(128, 217);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(187, 26);
            this.tbCantitate.TabIndex = 18;
            this.tbCantitate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantitate_KeyPress);
            this.tbCantitate.Validating += new System.ComponentModel.CancelEventHandler(this.tbCantitate_Validating);
            this.tbCantitate.Validated += new System.EventHandler(this.tbCantitate_Validated);
            // 
            // lbPret
            // 
            this.lbPret.AutoSize = true;
            this.lbPret.Location = new System.Drawing.Point(22, 163);
            this.lbPret.Name = "lbPret";
            this.lbPret.Size = new System.Drawing.Size(38, 20);
            this.lbPret.TabIndex = 17;
            this.lbPret.Text = "Pret";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(128, 163);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(187, 26);
            this.tbPret.TabIndex = 16;
            this.tbPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPret_KeyPress);
            this.tbPret.Validating += new System.ComponentModel.CancelEventHandler(this.tbPret_Validating);
            this.tbPret.Validated += new System.EventHandler(this.tbPret_Validated);
            // 
            // lbDenumire
            // 
            this.lbDenumire.AutoSize = true;
            this.lbDenumire.Location = new System.Drawing.Point(22, 107);
            this.lbDenumire.Name = "lbDenumire";
            this.lbDenumire.Size = new System.Drawing.Size(78, 20);
            this.lbDenumire.TabIndex = 15;
            this.lbDenumire.Text = "Denumire";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(128, 107);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(187, 26);
            this.tbDenumire.TabIndex = 14;
            this.tbDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.tbDenumire_Validating);
            this.tbDenumire.Validated += new System.EventHandler(this.tbDenumire_Validated);
            // 
            // lbCodProdus
            // 
            this.lbCodProdus.AutoSize = true;
            this.lbCodProdus.Location = new System.Drawing.Point(22, 53);
            this.lbCodProdus.Name = "lbCodProdus";
            this.lbCodProdus.Size = new System.Drawing.Size(91, 20);
            this.lbCodProdus.TabIndex = 13;
            this.lbCodProdus.Text = "Cod produs";
            // 
            // tbCodProdus
            // 
            this.tbCodProdus.Location = new System.Drawing.Point(128, 53);
            this.tbCodProdus.Name = "tbCodProdus";
            this.tbCodProdus.Size = new System.Drawing.Size(187, 26);
            this.tbCodProdus.TabIndex = 12;
            this.tbCodProdus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodProdus_KeyPress);
            this.tbCodProdus.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodProdus_Validating);
            this.tbCodProdus.Validated += new System.EventHandler(this.tbCodProdus_Validated);
            // 
            // btnAfiseazaProduse
            // 
            this.btnAfiseazaProduse.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfiseazaProduse.Location = new System.Drawing.Point(26, 356);
            this.btnAfiseazaProduse.Name = "btnAfiseazaProduse";
            this.btnAfiseazaProduse.Size = new System.Drawing.Size(289, 35);
            this.btnAfiseazaProduse.TabIndex = 23;
            this.btnAfiseazaProduse.Text = "Afiseaza lista produselor";
            this.btnAfiseazaProduse.UseVisualStyleBackColor = false;
            this.btnAfiseazaProduse.Click += new System.EventHandler(this.btnAfiseazaProduse_Click);
            // 
            // lvProducts
            // 
            this.lvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(363, 53);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(500, 338);
            this.lvProducts.TabIndex = 24;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cod";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Denumire";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Pret";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Cantitate";
            this.columnHeader10.Width = 80;
            // 
            // menuStripProduse
            // 
            this.menuStripProduse.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripProduse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.instrumenteToolStripMenuItem,
            this.bazaDeDateToolStripMenuItem});
            this.menuStripProduse.Location = new System.Drawing.Point(0, 0);
            this.menuStripProduse.Name = "menuStripProduse";
            this.menuStripProduse.Size = new System.Drawing.Size(907, 36);
            this.menuStripProduse.TabIndex = 25;
            this.menuStripProduse.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareCaToolStripMenuItem,
            this.importareDinToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareCaToolStripMenuItem
            // 
            this.salvareCaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierBinarbinToolStripMenuItem1,
            this.fisierTexttxtToolStripMenuItem1});
            this.salvareCaToolStripMenuItem.Name = "salvareCaToolStripMenuItem";
            this.salvareCaToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.salvareCaToolStripMenuItem.Text = "Salvare ca...";
            // 
            // fisierBinarbinToolStripMenuItem1
            // 
            this.fisierBinarbinToolStripMenuItem1.Name = "fisierBinarbinToolStripMenuItem1";
            this.fisierBinarbinToolStripMenuItem1.Size = new System.Drawing.Size(243, 34);
            this.fisierBinarbinToolStripMenuItem1.Text = "Fisier binar (.bin)";
            this.fisierBinarbinToolStripMenuItem1.Click += new System.EventHandler(this.fisierBinarbinToolStripMenuItem1_Click);
            // 
            // fisierTexttxtToolStripMenuItem1
            // 
            this.fisierTexttxtToolStripMenuItem1.Name = "fisierTexttxtToolStripMenuItem1";
            this.fisierTexttxtToolStripMenuItem1.Size = new System.Drawing.Size(243, 34);
            this.fisierTexttxtToolStripMenuItem1.Text = "Fisier text (.txt)";
            this.fisierTexttxtToolStripMenuItem1.Click += new System.EventHandler(this.fisierTexttxtToolStripMenuItem1_Click);
            // 
            // importareDinToolStripMenuItem
            // 
            this.importareDinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierBinarbinToolStripMenuItem});
            this.importareDinToolStripMenuItem.Name = "importareDinToolStripMenuItem";
            this.importareDinToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.importareDinToolStripMenuItem.Text = "Importare din...";
            // 
            // fisierBinarbinToolStripMenuItem
            // 
            this.fisierBinarbinToolStripMenuItem.Name = "fisierBinarbinToolStripMenuItem";
            this.fisierBinarbinToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.fisierBinarbinToolStripMenuItem.Text = "Fisier binar (.bin)";
            this.fisierBinarbinToolStripMenuItem.Click += new System.EventHandler(this.fisierBinarbinToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaProduseToolStripMenuItem});
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.stergeToolStripMenuItem.Text = "Vizualizare";
            // 
            // listaProduseToolStripMenuItem
            // 
            this.listaProduseToolStripMenuItem.Name = "listaProduseToolStripMenuItem";
            this.listaProduseToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.listaProduseToolStripMenuItem.Text = "Lista produse";
            // 
            // instrumenteToolStripMenuItem
            // 
            this.instrumenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem1,
            this.stergereToolStripMenuItem1});
            this.instrumenteToolStripMenuItem.Name = "instrumenteToolStripMenuItem";
            this.instrumenteToolStripMenuItem.Size = new System.Drawing.Size(123, 32);
            this.instrumenteToolStripMenuItem.Text = "Instrumente";
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
            this.afisareToolStripMenuItem,
            this.adaugareToolStripMenuItem,
            this.actualizareToolStripMenuItem,
            this.stergereToolStripMenuItem2});
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(129, 32);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de date";
            // 
            // afisareToolStripMenuItem
            // 
            this.afisareToolStripMenuItem.Name = "afisareToolStripMenuItem";
            this.afisareToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.afisareToolStripMenuItem.Text = "Afisare";
            this.afisareToolStripMenuItem.Click += new System.EventHandler(this.afisareToolStripMenuItem_Click);
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            // 
            // actualizareToolStripMenuItem
            // 
            this.actualizareToolStripMenuItem.Name = "actualizareToolStripMenuItem";
            this.actualizareToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.actualizareToolStripMenuItem.Text = "Actualizare";
            // 
            // stergereToolStripMenuItem2
            // 
            this.stergereToolStripMenuItem2.Name = "stergereToolStripMenuItem2";
            this.stergereToolStripMenuItem2.Size = new System.Drawing.Size(199, 34);
            this.stergereToolStripMenuItem2.Text = "Stergere";
            // 
            // contextMenuStripProduse
            // 
            this.contextMenuStripProduse.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripProduse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem,
            this.stergereToolStripMenuItem});
            this.contextMenuStripProduse.Name = "contextMenuStripProduse";
            this.contextMenuStripProduse.Size = new System.Drawing.Size(150, 68);
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
            // errCod
            // 
            this.errCod.ContainerControl = this;
            // 
            // errDenumire
            // 
            this.errDenumire.ContainerControl = this;
            // 
            // errPret
            // 
            this.errPret.ContainerControl = this;
            // 
            // errCantitate
            // 
            this.errCantitate.ContainerControl = this;
            // 
            // FormProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(907, 411);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.btnAfiseazaProduse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbCantitate);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.lbPret);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.lbDenumire);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.lbCodProdus);
            this.Controls.Add(this.tbCodProdus);
            this.Controls.Add(this.menuStripProduse);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripProduse;
            this.Name = "FormProduse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Produse";
            this.menuStripProduse.ResumeLayout(false);
            this.menuStripProduse.PerformLayout();
            this.contextMenuStripProduse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDenumire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbCantitate;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label lbPret;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label lbDenumire;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label lbCodProdus;
        private System.Windows.Forms.TextBox tbCodProdus;
        private System.Windows.Forms.Button btnAfiseazaProduse;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.MenuStrip menuStripProduse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProduse;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errCod;
        private System.Windows.Forms.ErrorProvider errDenumire;
        private System.Windows.Forms.ErrorProvider errPret;
        private System.Windows.Forms.ErrorProvider errCantitate;
        private System.Windows.Forms.ToolStripMenuItem instrumenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareCaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importareDinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fisierBinarbinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fisierTexttxtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fisierBinarbinToolStripMenuItem;
    }
}