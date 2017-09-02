namespace Caisse1
{
    partial class Form2
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
            this.NomProduit = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.prixTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prixAchatTB = new System.Windows.Forms.TextBox();
            this.prixAchatLabel = new System.Windows.Forms.Label();
            this.tvaTB = new System.Windows.Forms.TextBox();
            this.TVALabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomProduit
            // 
            this.NomProduit.AutoSize = true;
            this.NomProduit.Location = new System.Drawing.Point(43, 50);
            this.NomProduit.Name = "NomProduit";
            this.NomProduit.Size = new System.Drawing.Size(29, 13);
            this.NomProduit.TabIndex = 0;
            this.NomProduit.Text = "Nom";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(122, 47);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(100, 20);
            this.productName.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(147, 355);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Enregistrer";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(271, 355);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Annuler";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // prixTB
            // 
            this.prixTB.Location = new System.Drawing.Point(122, 96);
            this.prixTB.Name = "prixTB";
            this.prixTB.Size = new System.Drawing.Size(100, 20);
            this.prixTB.TabIndex = 5;
            this.prixTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prix";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stockTB
            // 
            this.stockTB.Location = new System.Drawing.Point(122, 140);
            this.stockTB.Name = "stockTB";
            this.stockTB.Size = new System.Drawing.Size(100, 20);
            this.stockTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stock";
            // 
            // prixAchatTB
            // 
            this.prixAchatTB.Location = new System.Drawing.Point(122, 183);
            this.prixAchatTB.Name = "prixAchatTB";
            this.prixAchatTB.Size = new System.Drawing.Size(100, 20);
            this.prixAchatTB.TabIndex = 9;
            // 
            // prixAchatLabel
            // 
            this.prixAchatLabel.AutoSize = true;
            this.prixAchatLabel.Location = new System.Drawing.Point(43, 186);
            this.prixAchatLabel.Name = "prixAchatLabel";
            this.prixAchatLabel.Size = new System.Drawing.Size(62, 13);
            this.prixAchatLabel.TabIndex = 8;
            this.prixAchatLabel.Text = "Prix d\'achat";
            // 
            // tvaTB
            // 
            this.tvaTB.Location = new System.Drawing.Point(122, 227);
            this.tvaTB.Name = "tvaTB";
            this.tvaTB.Size = new System.Drawing.Size(100, 20);
            this.tvaTB.TabIndex = 11;
            // 
            // TVALabel
            // 
            this.TVALabel.AutoSize = true;
            this.TVALabel.Location = new System.Drawing.Point(43, 230);
            this.TVALabel.Name = "TVALabel";
            this.TVALabel.Size = new System.Drawing.Size(28, 13);
            this.TVALabel.TabIndex = 10;
            this.TVALabel.Text = "TVA";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 445);
            this.Controls.Add(this.tvaTB);
            this.Controls.Add(this.TVALabel);
            this.Controls.Add(this.prixAchatTB);
            this.Controls.Add(this.prixAchatLabel);
            this.Controls.Add(this.stockTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prixTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.NomProduit);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau Produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomProduit;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox prixTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stockTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prixAchatTB;
        private System.Windows.Forms.Label prixAchatLabel;
        private System.Windows.Forms.TextBox tvaTB;
        private System.Windows.Forms.Label TVALabel;
    }
}