namespace gestion_ecoles
{
    partial class Rlivre
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
            this.btnaffiche = new System.Windows.Forms.Button();
            this.tabdepenses = new System.Windows.Forms.TabControl();
            this.Stabdepenses = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnrecettes = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.agent = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOption = new System.Windows.Forms.Label();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.lblMatEleve = new System.Windows.Forms.Label();
            this.cmbMatEleve = new System.Windows.Forms.ComboBox();
            this.lblMatAgent = new System.Windows.Forms.Label();
            this.lblMois = new System.Windows.Forms.Label();
            this.cmbMois = new System.Windows.Forms.ComboBox();
            this.cmbMatAgent = new System.Windows.Forms.ComboBox();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.lblCatFrais = new System.Windows.Forms.Label();
            this.cmbFrais = new System.Windows.Forms.ComboBox();
            this.cmbAnnee = new System.Windows.Forms.ComboBox();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.tabdepenses.SuspendLayout();
            this.Stabdepenses.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.agent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaffiche
            // 
            this.btnaffiche.BackColor = System.Drawing.Color.Gainsboro;
            this.btnaffiche.FlatAppearance.BorderSize = 0;
            this.btnaffiche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnaffiche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnaffiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaffiche.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaffiche.ForeColor = System.Drawing.Color.Black;
            this.btnaffiche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaffiche.Location = new System.Drawing.Point(884, 20);
            this.btnaffiche.Name = "btnaffiche";
            this.btnaffiche.Size = new System.Drawing.Size(217, 30);
            this.btnaffiche.TabIndex = 38;
            this.btnaffiche.Text = "Afficher Depenses";
            this.btnaffiche.UseVisualStyleBackColor = false;
            this.btnaffiche.Click += new System.EventHandler(this.btnaffiche_Click);
            // 
            // tabdepenses
            // 
            this.tabdepenses.Controls.Add(this.Stabdepenses);
            this.tabdepenses.Controls.Add(this.tabPage2);
            this.tabdepenses.Controls.Add(this.tabPage1);
            this.tabdepenses.Controls.Add(this.tabPage3);
            this.tabdepenses.Controls.Add(this.agent);
            this.tabdepenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabdepenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabdepenses.Location = new System.Drawing.Point(0, 0);
            this.tabdepenses.Name = "tabdepenses";
            this.tabdepenses.SelectedIndex = 0;
            this.tabdepenses.Size = new System.Drawing.Size(1168, 100);
            this.tabdepenses.TabIndex = 39;
            this.tabdepenses.Click += new System.EventHandler(this.tabdepenses_Click);
            // 
            // Stabdepenses
            // 
            this.Stabdepenses.BackColor = System.Drawing.Color.Gainsboro;
            this.Stabdepenses.Controls.Add(this.btnaffiche);
            this.Stabdepenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stabdepenses.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Stabdepenses.Location = new System.Drawing.Point(4, 29);
            this.Stabdepenses.Name = "Stabdepenses";
            this.Stabdepenses.Padding = new System.Windows.Forms.Padding(3);
            this.Stabdepenses.Size = new System.Drawing.Size(1160, 67);
            this.Stabdepenses.TabIndex = 0;
            this.Stabdepenses.Text = "Livre des depenses";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.btnrecettes);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1160, 67);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Livre des recettes";
            // 
            // btnrecettes
            // 
            this.btnrecettes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnrecettes.FlatAppearance.BorderSize = 0;
            this.btnrecettes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnrecettes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnrecettes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecettes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecettes.ForeColor = System.Drawing.Color.Black;
            this.btnrecettes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrecettes.Location = new System.Drawing.Point(958, 19);
            this.btnrecettes.Name = "btnrecettes";
            this.btnrecettes.Size = new System.Drawing.Size(194, 30);
            this.btnrecettes.TabIndex = 39;
            this.btnrecettes.Text = "Afficher Recettes";
            this.btnrecettes.UseVisualStyleBackColor = false;
            this.btnrecettes.Click += new System.EventHandler(this.btnrecettes_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1160, 67);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Livre synthese";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(955, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 40;
            this.button1.Text = "Afficher Synthese";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1160, 67);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Etats de Sorties";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(281, 27);
            this.button5.TabIndex = 3;
            this.button5.Text = "Fiche de paie par Elève";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(607, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(266, 27);
            this.button4.TabIndex = 2;
            this.button4.Text = "Registre des eleves par classe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // agent
            // 
            this.agent.Controls.Add(this.button3);
            this.agent.Controls.Add(this.button2);
            this.agent.Location = new System.Drawing.Point(4, 29);
            this.agent.Name = "agent";
            this.agent.Padding = new System.Windows.Forms.Padding(3);
            this.agent.Size = new System.Drawing.Size(1160, 67);
            this.agent.TabIndex = 4;
            this.agent.Text = "Livre Agent";
            this.agent.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Fiche de paie par Agent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Fiche de paie des agents ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.AutoScroll = true;
            this.crystalReportViewer1.AutoSize = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 194);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1152, 555);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblOption);
            this.panel1.Controls.Add(this.cmbOption);
            this.panel1.Controls.Add(this.lblClasse);
            this.panel1.Controls.Add(this.cmbClasse);
            this.panel1.Controls.Add(this.lblMatEleve);
            this.panel1.Controls.Add(this.cmbMatEleve);
            this.panel1.Controls.Add(this.lblMatAgent);
            this.panel1.Controls.Add(this.lblMois);
            this.panel1.Controls.Add(this.cmbMois);
            this.panel1.Controls.Add(this.cmbMatAgent);
            this.panel1.Controls.Add(this.lblSemestre);
            this.panel1.Controls.Add(this.cmbSemestre);
            this.panel1.Controls.Add(this.lblCatFrais);
            this.panel1.Controls.Add(this.cmbFrais);
            this.panel1.Controls.Add(this.cmbAnnee);
            this.panel1.Controls.Add(this.lblAnnee);
            this.panel1.Location = new System.Drawing.Point(4, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 86);
            this.panel1.TabIndex = 41;
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.Location = new System.Drawing.Point(662, 54);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(62, 20);
            this.lblOption.TabIndex = 56;
            this.lblOption.Text = "Option";
            // 
            // cmbOption
            // 
            this.cmbOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Location = new System.Drawing.Point(781, 46);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(137, 28);
            this.cmbOption.TabIndex = 55;
            this.cmbOption.SelectedIndexChanged += new System.EventHandler(this.cmbOption_SelectedIndexChanged);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.Location = new System.Drawing.Point(961, 52);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(63, 20);
            this.lblClasse.TabIndex = 54;
            this.lblClasse.Text = "Classe";
            // 
            // cmbClasse
            // 
            this.cmbClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(1030, 44);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(122, 28);
            this.cmbClasse.TabIndex = 53;
            this.cmbClasse.SelectedIndexChanged += new System.EventHandler(this.cmbClasse_SelectedIndexChanged);
            // 
            // lblMatEleve
            // 
            this.lblMatEleve.AutoSize = true;
            this.lblMatEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatEleve.Location = new System.Drawing.Point(25, 44);
            this.lblMatEleve.Name = "lblMatEleve";
            this.lblMatEleve.Size = new System.Drawing.Size(88, 20);
            this.lblMatEleve.TabIndex = 52;
            this.lblMatEleve.Text = "Matrucule";
            // 
            // cmbMatEleve
            // 
            this.cmbMatEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMatEleve.FormattingEnabled = true;
            this.cmbMatEleve.Location = new System.Drawing.Point(137, 41);
            this.cmbMatEleve.Name = "cmbMatEleve";
            this.cmbMatEleve.Size = new System.Drawing.Size(152, 28);
            this.cmbMatEleve.TabIndex = 51;
            this.cmbMatEleve.SelectedIndexChanged += new System.EventHandler(this.cmbMatEleve_SelectedIndexChanged);
            // 
            // lblMatAgent
            // 
            this.lblMatAgent.AutoSize = true;
            this.lblMatAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatAgent.Location = new System.Drawing.Point(416, 49);
            this.lblMatAgent.Name = "lblMatAgent";
            this.lblMatAgent.Size = new System.Drawing.Size(82, 20);
            this.lblMatAgent.TabIndex = 50;
            this.lblMatAgent.Text = "Matricule";
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMois.Location = new System.Drawing.Point(970, 18);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(54, 20);
            this.lblMois.TabIndex = 48;
            this.lblMois.Text = "MOIS";
            // 
            // cmbMois
            // 
            this.cmbMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMois.FormattingEnabled = true;
            this.cmbMois.Location = new System.Drawing.Point(1030, 10);
            this.cmbMois.Name = "cmbMois";
            this.cmbMois.Size = new System.Drawing.Size(122, 28);
            this.cmbMois.TabIndex = 47;
            // 
            // cmbMatAgent
            // 
            this.cmbMatAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMatAgent.FormattingEnabled = true;
            this.cmbMatAgent.Location = new System.Drawing.Point(504, 41);
            this.cmbMatAgent.Name = "cmbMatAgent";
            this.cmbMatAgent.Size = new System.Drawing.Size(152, 28);
            this.cmbMatAgent.TabIndex = 49;
            this.cmbMatAgent.SelectedIndexChanged += new System.EventHandler(this.cmbMatAgent_SelectedIndexChanged);
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(660, 15);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(106, 20);
            this.lblSemestre.TabIndex = 45;
            this.lblSemestre.Text = "SEMESTRE";
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(781, 10);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(162, 28);
            this.cmbSemestre.TabIndex = 46;
            // 
            // lblCatFrais
            // 
            this.lblCatFrais.AutoSize = true;
            this.lblCatFrais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatFrais.Location = new System.Drawing.Point(327, 13);
            this.lblCatFrais.Name = "lblCatFrais";
            this.lblCatFrais.Size = new System.Drawing.Size(177, 20);
            this.lblCatFrais.TabIndex = 44;
            this.lblCatFrais.Text = "CATEGORIE FRAIS:";
            // 
            // cmbFrais
            // 
            this.cmbFrais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrais.FormattingEnabled = true;
            this.cmbFrais.Location = new System.Drawing.Point(504, 10);
            this.cmbFrais.Name = "cmbFrais";
            this.cmbFrais.Size = new System.Drawing.Size(152, 28);
            this.cmbFrais.TabIndex = 43;
            // 
            // cmbAnnee
            // 
            this.cmbAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnnee.FormattingEnabled = true;
            this.cmbAnnee.Location = new System.Drawing.Point(200, 7);
            this.cmbAnnee.Name = "cmbAnnee";
            this.cmbAnnee.Size = new System.Drawing.Size(121, 28);
            this.cmbAnnee.TabIndex = 42;
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnee.Location = new System.Drawing.Point(25, 10);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(169, 20);
            this.lblAnnee.TabIndex = 41;
            this.lblAnnee.Text = "ANNEE SCOLAIRE:";
            // 
            // Rlivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1168, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabdepenses);
            this.Controls.Add(this.crystalReportViewer1);
            this.HelpButton = true;
            this.Name = "Rlivre";
            this.Text = "Rlivre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rlivre_Load);
            this.tabdepenses.ResumeLayout(false);
            this.Stabdepenses.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.agent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnaffiche;
        private System.Windows.Forms.TabControl tabdepenses;
        private System.Windows.Forms.TabPage Stabdepenses;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button btnrecettes;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.Label lblCatFrais;
        private System.Windows.Forms.ComboBox cmbFrais;
        private System.Windows.Forms.ComboBox cmbAnnee;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.ComboBox cmbMois;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage agent;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblMatAgent;
        private System.Windows.Forms.ComboBox cmbMatAgent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Label lblMatEleve;
        private System.Windows.Forms.ComboBox cmbMatEleve;
    }
}