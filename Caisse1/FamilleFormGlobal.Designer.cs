namespace Caisse1
{
    partial class FamilleFormGlobal
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
            this.label1 = new System.Windows.Forms.Label();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caissefamilleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caisse_famille_DataSet = new Caisse1.Caisse_famille_DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.familleTB = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.familleTableAdapter = new Caisse1.Caisse_famille_DataSetTableAdapters.familleTableAdapter();
            this.familleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caissefamilleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caisse_famille_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des familles";
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataMember = "famille";
            this.familleBindingSource.DataSource = this.caissefamilleDataSetBindingSource;
            // 
            // caissefamilleDataSetBindingSource
            // 
            this.caissefamilleDataSetBindingSource.DataSource = this.caisse_famille_DataSet;
            this.caissefamilleDataSetBindingSource.Position = 0;
            // 
            // caisse_famille_DataSet
            // 
            this.caisse_famille_DataSet.DataSetName = "Caisse_famille_DataSet";
            this.caisse_famille_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter une famille";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // familleTB
            // 
            this.familleTB.Location = new System.Drawing.Point(35, 160);
            this.familleTB.Name = "familleTB";
            this.familleTB.Size = new System.Drawing.Size(100, 20);
            this.familleTB.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(168, 158);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Enregistrer";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // familleTableAdapter
            // 
            this.familleTableAdapter.ClearBeforeFill = true;
            // 
            // familleBindingSource1
            // 
            this.familleBindingSource1.DataMember = "famille";
            this.familleBindingSource1.DataSource = this.caissefamilleDataSetBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // FamilleFormGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.familleTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FamilleFormGlobal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FamilleFormGlobal";
            this.Load += new System.EventHandler(this.FamilleFormGlobal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caissefamilleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caisse_famille_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox familleTB;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource caissefamilleDataSetBindingSource;
        private Caisse_famille_DataSet caisse_famille_DataSet;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private Caisse_famille_DataSetTableAdapters.familleTableAdapter familleTableAdapter;
        private System.Windows.Forms.BindingSource familleBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}