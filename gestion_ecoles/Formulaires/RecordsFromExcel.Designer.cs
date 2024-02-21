namespace gestion_ecoles.Formulaires
{
    partial class RecordsFromExcel
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
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.txtfeuille = new System.Windows.Forms.TextBox();
            this.lblsExcelSheetname = new System.Windows.Forms.Label();
            this.btnCharger = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtSecope = new System.Windows.Forms.TextBox();
            this.dateInscription = new System.Windows.Forms.DateTimePicker();
            this.cmbAnneeScolaire = new System.Windows.Forms.ComboBox();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstudent
            // 
            this.dgvstudent.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvstudent.Location = new System.Drawing.Point(0, 225);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstudent.Size = new System.Drawing.Size(1153, 281);
            this.dgvstudent.TabIndex = 0;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(227, 19);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(215, 29);
            this.txtFilePath.TabIndex = 34;
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnbrowse.FlatAppearance.BorderSize = 0;
            this.btnbrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnbrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrowse.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnbrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbrowse.Location = new System.Drawing.Point(12, 22);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(197, 28);
            this.btnbrowse.TabIndex = 33;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // txtfeuille
            // 
            this.txtfeuille.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeuille.Location = new System.Drawing.Point(706, 19);
            this.txtfeuille.Name = "txtfeuille";
            this.txtfeuille.Size = new System.Drawing.Size(215, 29);
            this.txtfeuille.TabIndex = 36;
            // 
            // lblsExcelSheetname
            // 
            this.lblsExcelSheetname.AutoSize = true;
            this.lblsExcelSheetname.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsExcelSheetname.Location = new System.Drawing.Point(453, 19);
            this.lblsExcelSheetname.Name = "lblsExcelSheetname";
            this.lblsExcelSheetname.Size = new System.Drawing.Size(238, 26);
            this.lblsExcelSheetname.TabIndex = 37;
            this.lblsExcelSheetname.Text = "Nom de la feuille Excel:";
            // 
            // btnCharger
            // 
            this.btnCharger.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCharger.FlatAppearance.BorderSize = 0;
            this.btnCharger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCharger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCharger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharger.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharger.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCharger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCharger.Location = new System.Drawing.Point(926, 19);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(197, 31);
            this.btnCharger.TabIndex = 38;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = false;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(910, 63);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(213, 28);
            this.btnsave.TabIndex = 39;
            this.btnsave.Text = "Save Records";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtSecope
            // 
            this.txtSecope.Location = new System.Drawing.Point(227, 183);
            this.txtSecope.Name = "txtSecope";
            this.txtSecope.Size = new System.Drawing.Size(293, 20);
            this.txtSecope.TabIndex = 44;
            // 
            // dateInscription
            // 
            this.dateInscription.Location = new System.Drawing.Point(227, 153);
            this.dateInscription.Name = "dateInscription";
            this.dateInscription.Size = new System.Drawing.Size(293, 20);
            this.dateInscription.TabIndex = 43;
            // 
            // cmbAnneeScolaire
            // 
            this.cmbAnneeScolaire.FormattingEnabled = true;
            this.cmbAnneeScolaire.Location = new System.Drawing.Point(227, 121);
            this.cmbAnneeScolaire.Name = "cmbAnneeScolaire";
            this.cmbAnneeScolaire.Size = new System.Drawing.Size(293, 21);
            this.cmbAnneeScolaire.TabIndex = 42;
            // 
            // cmbOption
            // 
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Location = new System.Drawing.Point(227, 92);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(293, 21);
            this.cmbOption.TabIndex = 41;
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(227, 63);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(293, 21);
            this.cmbClasse.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 45;
            this.label1.Text = "Classe ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "Option";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "Annee scolaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 49;
            this.label5.Text = "Secop";
            // 
            // RecordsFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecope);
            this.Controls.Add(this.dateInscription);
            this.Controls.Add(this.cmbAnneeScolaire);
            this.Controls.Add(this.cmbOption);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.lblsExcelSheetname);
            this.Controls.Add(this.txtfeuille);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.dgvstudent);
            this.Name = "RecordsFromExcel";
            this.Text = "RecordsFromExcel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.TextBox txtFilePath;
        public System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox txtfeuille;
        private System.Windows.Forms.Label lblsExcelSheetname;
        public System.Windows.Forms.Button btnCharger;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.TextBox txtSecope;
        public System.Windows.Forms.DateTimePicker dateInscription;
        public System.Windows.Forms.ComboBox cmbAnneeScolaire;
        public System.Windows.Forms.ComboBox cmbOption;
        public System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}