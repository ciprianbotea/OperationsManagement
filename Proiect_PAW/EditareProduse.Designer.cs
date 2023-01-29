namespace Proiect_PAW
{
    partial class EditareProduse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditareProduse));
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
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(205, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 40);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(22, 281);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 40);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "Editeaza";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbCantitate
            // 
            this.lbCantitate.AutoSize = true;
            this.lbCantitate.Location = new System.Drawing.Point(18, 197);
            this.lbCantitate.Name = "lbCantitate";
            this.lbCantitate.Size = new System.Drawing.Size(74, 20);
            this.lbCantitate.TabIndex = 29;
            this.lbCantitate.Text = "Cantitate";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(124, 197);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(187, 26);
            this.tbCantitate.TabIndex = 28;
            // 
            // lbPret
            // 
            this.lbPret.AutoSize = true;
            this.lbPret.Location = new System.Drawing.Point(18, 143);
            this.lbPret.Name = "lbPret";
            this.lbPret.Size = new System.Drawing.Size(38, 20);
            this.lbPret.TabIndex = 27;
            this.lbPret.Text = "Pret";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(124, 143);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(187, 26);
            this.tbPret.TabIndex = 26;
            // 
            // lbDenumire
            // 
            this.lbDenumire.AutoSize = true;
            this.lbDenumire.Location = new System.Drawing.Point(18, 87);
            this.lbDenumire.Name = "lbDenumire";
            this.lbDenumire.Size = new System.Drawing.Size(78, 20);
            this.lbDenumire.TabIndex = 25;
            this.lbDenumire.Text = "Denumire";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(124, 87);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(187, 26);
            this.tbDenumire.TabIndex = 24;
            // 
            // lbCodProdus
            // 
            this.lbCodProdus.AutoSize = true;
            this.lbCodProdus.Location = new System.Drawing.Point(18, 33);
            this.lbCodProdus.Name = "lbCodProdus";
            this.lbCodProdus.Size = new System.Drawing.Size(91, 20);
            this.lbCodProdus.TabIndex = 23;
            this.lbCodProdus.Text = "Cod produs";
            // 
            // tbCodProdus
            // 
            this.tbCodProdus.Location = new System.Drawing.Point(124, 33);
            this.tbCodProdus.Name = "tbCodProdus";
            this.tbCodProdus.Size = new System.Drawing.Size(187, 26);
            this.tbCodProdus.TabIndex = 22;
            // 
            // EditareProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(378, 356);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditareProduse";
            this.Text = "EditareProduse";
            this.Load += new System.EventHandler(this.EditareProduse_Load);
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
    }
}