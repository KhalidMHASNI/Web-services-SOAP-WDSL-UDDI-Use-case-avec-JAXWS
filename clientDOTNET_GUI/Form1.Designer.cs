namespace clientDOTNET_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConversion = new System.Windows.Forms.Button();
            this.textBoxMT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComptes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.compteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConversion
            // 
            this.btnConversion.BackColor = System.Drawing.Color.Crimson;
            this.btnConversion.ForeColor = System.Drawing.Color.White;
            this.btnConversion.Location = new System.Drawing.Point(417, 133);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(155, 50);
            this.btnConversion.TabIndex = 0;
            this.btnConversion.Text = "Convertir";
            this.btnConversion.UseVisualStyleBackColor = false;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click_1);
            // 
            // textBoxMT
            // 
            this.textBoxMT.Location = new System.Drawing.Point(200, 94);
            this.textBoxMT.Name = "textBoxMT";
            this.textBoxMT.Size = new System.Drawing.Size(198, 38);
            this.textBoxMT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(77, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Montant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnComptes
            // 
            this.btnComptes.BackColor = System.Drawing.Color.Crimson;
            this.btnComptes.ForeColor = System.Drawing.Color.White;
            this.btnComptes.Location = new System.Drawing.Point(541, 277);
            this.btnComptes.Name = "btnComptes";
            this.btnComptes.Size = new System.Drawing.Size(296, 50);
            this.btnComptes.TabIndex = 3;
            this.btnComptes.Text = "Liste des comptes";
            this.btnComptes.UseVisualStyleBackColor = false;
            this.btnComptes.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(75, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Résultat";
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(200, 175);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(198, 38);
            this.textBoxRes.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.soldeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.compteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 415);
            this.dataGridView1.TabIndex = 6;
            // 
            // compteBindingSource
            // 
            this.compteBindingSource.DataSource = typeof(clientDOTNET_GUI.ServiceReference1.compte);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 250;
            // 
            // soldeDataGridViewTextBoxColumn
            // 
            this.soldeDataGridViewTextBoxColumn.DataPropertyName = "solde";
            this.soldeDataGridViewTextBoxColumn.HeaderText = "solde";
            this.soldeDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.soldeDataGridViewTextBoxColumn.Name = "soldeDataGridViewTextBoxColumn";
            this.soldeDataGridViewTextBoxColumn.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 833);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComptes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMT);
            this.Controls.Add(this.btnConversion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.TextBox textBoxMT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComptes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource compteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldeDataGridViewTextBoxColumn;
    }
}

