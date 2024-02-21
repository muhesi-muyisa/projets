using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_ecoles.models;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

namespace gestion_ecoles
{
    public partial class Rlivre : Form
    {
        public Rlivre()
        {
            InitializeComponent();
            remplireAnneeScolaire();
            rempliresemestre();
            remplireFrais();
            remplireMois();
            remplireMatAgent("");
            remplireMatEleve("");
            remplireOption("");
            remplireClasse("");
            invisibleField();

           
        }
        models.connection conn=new models.connection();
        private void Rlivre_Load(object sender, EventArgs e)
        {
            models.connection conn = new models.connection();
        }


        void remplireAnneeScolaire()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM school_year", conn.conndb);

                // Ouverture de la connexion à la BDD
                conn.conndb.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                cmbAnnee.Items.Clear();
                while (rd.Read())
                {
                    cmbAnnee.Items.Add(rd[1]).ToString();
                }
                rd.Close();
                conn.conndb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.conndb.Close();
            }

        }


        // Matrucles des agent 

        void remplireMatAgent(string mate)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM agent WHERE id_agent like '%"+mate+"%'", conn.conndb);

                // Ouverture de la connexion à la BDD
                conn.conndb.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                cmbMatAgent.Items.Clear();
                while (rd.Read())
                {
                    cmbMatAgent.Items.Add(rd[0]).ToString();
                }
                rd.Close();
                conn.conndb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.conndb.Close();
            }

        }
        // Fin methode

        // Debu methode Affichage Matrucle eleve

        void remplireMatEleve(string mate)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE num_mat like '%" + mate + "%'", conn.conndb);

                // Ouverture de la connexion à la BDD
                conn.conndb.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                cmbMatEleve.Items.Clear();
                while (rd.Read())
                {
                    cmbMatEleve.Items.Add(rd[0]).ToString();
                }
                rd.Close();
                conn.conndb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.conndb.Close();
            }

        }
        // Fin de la methode mat eleve

        // Debut methode de remplissage cmbClasse
        void remplireClasse(string mate)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM classes WHERE code_class like '%" + mate + "%'", conn.conndb);

                // Ouverture de la connexion à la BDD
                conn.conndb.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                cmbClasse.Items.Clear();
                while (rd.Read())
                {
                    cmbClasse.Items.Add(rd[0]).ToString();
                }
                rd.Close();
                conn.conndb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.conndb.Close();
            }

        }
        // Fin de methode Classe



        // Debut methode de remplissage cmbOption
        void remplireOption(string mate)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM options WHERE code_option like '%" + mate + "%'", conn.conndb);

                // Ouverture de la connexion à la BDD
                conn.conndb.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                cmbOption.Items.Clear();
                while (rd.Read())
                {
                    cmbOption.Items.Add(rd[0]).ToString();
                }
                rd.Close();
                conn.conndb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.conndb.Close();
            }

        }
        // Fin de methode Option

        void remplireMois()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM mois", conn.conndb);

                // Ouverture de la connexion à la BDD
                conn.conndb.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                cmbMois.Items.Clear();
                while (rd.Read())
                {
                    cmbMois.Items.Add(rd[1]).ToString();
                }
                rd.Close();
                conn.conndb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.conndb.Close();
            }

        }

        void remplireFrais()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM categorie_frais", conn.conndb);

                // Ouverture de la connexion à la BDD
                conn.conndb.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                cmbFrais.Items.Clear();
                while (rd.Read())
                {
                    cmbFrais.Items.Add(rd[1]).ToString();
                }
                rd.Close();
                conn.conndb.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.conndb.Close();
            }

        }


        void rempliresemestre()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM semestre", conn.conndb);

                // Ouverture de la connexion à la BDD
                conn.conndb.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                cmbSemestre.Items.Clear();
                while (rd.Read())
                {
                    cmbSemestre.Items.Add(rd[1]).ToString();
                }
                rd.Close();
                conn.conndb.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.conndb.Close();
            }

        }

        private void btnaffiche_Click(object sender, EventArgs e)
        {
            try
            {
                models.connection con = new models.connection();
                CrystalReport1 fcli = new CrystalReport1();

                if (con.conndb.State != ConnectionState.Open)
                {
                    con.conndb.Open();
                }
                MySqlCommand cmd = new MySqlCommand("select * from caisse_depenses where description_annee='"+cmbAnnee.Text + "' AND description_frais='"+cmbFrais.Text+ "' AND description_mois='"+cmbMois.Text +"'", con.conndb);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                //DataSet2 ds=new DataSet2();
                DataSet1 ds = new DataSet1();
                ada.Fill(ds, "caisse_depenses");
                fcli.SetDataSource(ds.Tables["caisse_depenses"]);
                crystalReportViewer1.ReportSource = fcli;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.conndb.Close();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnrecettes_Click(object sender, EventArgs e)
        {
            try
            {
                models.connection con = new models.connection();
               CrystalReport2 fcli = new CrystalReport2();

                if (con.conndb.State != ConnectionState.Open)
                {
                    con.conndb.Open();
                }
                MySqlCommand cmd = new MySqlCommand("select * from caisse_recette where description_annee='" + cmbAnnee.Text + "' AND description_frais='" + cmbFrais.Text + "' AND description_mois='" +cmbMois.Text+ "'", con.conndb);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet1 ds = new DataSet1();
                ada.Fill(ds, "caisse_recette");
               fcli.SetDataSource(ds.Tables["caisse_recette"]);
               crystalReportViewer1.ReportSource = fcli;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.conndb.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                models.connection con = new models.connection();
              CrystalReport3 fcli = new CrystalReport3();

                if (con.conndb.State != ConnectionState.Open)
                {
                    con.conndb.Open();
                }
                MySqlCommand cmd = new MySqlCommand("select * from solde_globale where description_annee='"+cmbAnnee.Text+ "' AND description_frais='"+cmbFrais.Text+ "'AND description_mois='"+cmbMois.Text+"'", con.conndb);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet1 ds = new DataSet1();
                ada.Fill(ds, "solde_globale");
              fcli.SetDataSource(ds.Tables["solde_globale"]);
                crystalReportViewer1.ReportSource = fcli;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.conndb.Close();
        }

        private void tabdepenses_Click(object sender, EventArgs e)
        {
           if(tabdepenses.SelectedIndex ==0)
            {
                lblAnnee.Visible = true;
                cmbAnnee.Visible = true;
                cmbFrais.Visible = true;
                cmbMois.Visible = true;
                lblMois.Visible = true;
                lblCatFrais.Visible = true;

                cmbMatAgent.Visible = false;
                lblMatAgent.Visible =false;

                lblSemestre.Visible =false;
                cmbSemestre.Visible = false;

                lblMatEleve.Visible =false;
                cmbMatEleve.Visible = false;

                lblOption.Visible = false;
                cmbOption.Visible = false;
                lblClasse.Visible = false;
                cmbClasse.Visible = false;
            }
           else if (tabdepenses.SelectedIndex ==1)
            {
                lblAnnee.Visible = true;
                cmbAnnee.Visible = true;
                cmbFrais.Visible = true;
                cmbMois.Visible = true;
                lblMois.Visible = true;
                lblCatFrais.Visible = true;

                cmbMatAgent.Visible = false;
                lblMatAgent.Visible = false;
                lblSemestre.Visible = false;
                cmbSemestre.Visible = false;
                lblMatEleve.Visible = false;
                cmbMatEleve.Visible = false;
                lblOption.Visible = false;
                cmbOption.Visible = false;
                lblClasse.Visible = false;
                cmbClasse.Visible = false;
            }
            else if (tabdepenses.SelectedIndex==2)
            {
                lblAnnee.Visible = true;
                cmbAnnee.Visible = true;
                lblCatFrais.Visible=true;
                lblMois.Visible=true;
                cmbMois.Visible=true;
                cmbAnnee.Visible=true;
                cmbFrais.Visible = true;

                lblSemestre.Visible = false;
                cmbSemestre.Visible =false;

                lblMatEleve.Visible = false;
                cmbMatEleve.Visible = false;
                lblOption.Visible = false;
                cmbOption.Visible = false;
                lblClasse.Visible = false;
                cmbClasse.Visible = false;
            }
           else if(tabdepenses.SelectedIndex==3){
                lblAnnee.Visible = true;
                cmbAnnee.Visible = true;
                cmbMatAgent.Visible = false;
                lblMatAgent.Visible =false;
                lblMois.Visible = false;
                cmbMois.Visible = false;

                lblSemestre.Visible = true;
                cmbSemestre.Visible = true;
                lblCatFrais.Visible = true;
                cmbFrais.Visible = true;
                lblMatEleve.Visible = true;
                cmbMatEleve.Visible = true;
                lblOption.Visible = true;
                cmbOption.Visible = true;
                lblClasse.Visible = true;
                cmbClasse.Visible = true;

            }
           else if (tabdepenses.SelectedIndex==4)
            {
                lblAnnee.Visible = true;
                cmbAnnee.Visible = true;
                cmbMatAgent.Visible = true;
                lblMatAgent.Visible = true;
                lblMois.Visible = true;
                cmbMois.Visible = true;

                lblSemestre.Visible = false;
                cmbSemestre.Visible = false;
                lblCatFrais.Visible = false;
                cmbFrais.Visible = false;
                lblMatEleve.Visible = false;
                cmbMatEleve.Visible = false;
                lblOption.Visible = false;
                cmbOption.Visible = false;
                lblClasse.Visible = false;
                cmbClasse.Visible = false;

            }
            else
            {
                lblSemestre.Visible = true;
                cmbSemestre.Visible = true;
                lblMois.Visible = false;
                cmbMois.Visible = false;
                lblCatFrais.Visible = true;
                cmbFrais.Visible = true;
                lblAnnee.Visible = true;
                cmbAnnee.Visible=true;
                cmbMatAgent.Visible = false;
                lblMatAgent.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void cmbMatAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbMatAgent.Text!=null) remplireMatAgent(cmbMatAgent.Text);
            //else remplireMatAgent("");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //LISTE DES PAIE DES AGENTS
            try
            {
                models.connection con = new models.connection();
                liste_paie_agent fcli = new liste_paie_agent();

                if (con.conndb.State != ConnectionState.Open)
                {
                    con.conndb.Open();
                }
                MySqlCommand cmd = new MySqlCommand("select * from liste_paie where description_mois='"+cmbMois.Text+ "' AND description_annee='"+cmbAnnee.Text+"'", con.conndb);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet1 ds = new DataSet1();
                ada.Fill(ds, "liste_paie");
                fcli.SetDataSource(ds.Tables["liste_paie"]);
                crystalReportViewer1.ReportSource = fcli;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.conndb.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            // Fiche personnelle de paiement des agents
            try
            {
                models.connection con = new models.connection();
                liste_individuel_agent fcli = new liste_individuel_agent();

                if (con.conndb.State != ConnectionState.Open)
                {
                    con.conndb.Open();
                }
                MySqlCommand cmd = new MySqlCommand("select * from liste_paie where description_annee='"+ cmbAnnee.Text+"' AND  id_agent='" + cmbMatAgent.Text + "'", con.conndb);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet1 ds = new DataSet1();
                ada.Fill(ds, "liste_paie");
                fcli.SetDataSource(ds.Tables["liste_paie"]);
                crystalReportViewer1.ReportSource = fcli;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.conndb.Close();
        }

        private void cmbMatEleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbMatEleve.Text!="") remplireMatEleve(cmbMatEleve.Text);
            //else remplireMatEleve("");
        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbClasse.Text!=null) remplireClasse(cmbClasse.Text);
            //else remplireClasse("");
        }

        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbOption.Text != null) remplireOption(cmbOption.Text);
            //else remplireOption("");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Fiche personnelle de paiement des agents
            try
            {
                models.connection con = new models.connection();
                fiche_paie_individuel_eleve fcli = new fiche_paie_individuel_eleve();

                if (con.conndb.State != ConnectionState.Open)
                {
                    con.conndb.Open();
                }
                MySqlCommand cmd = new MySqlCommand("select * from fiche_paie_student where description_annee='" + cmbAnnee.Text + "' AND num_mat='" + cmbMatEleve.Text + "'", con.conndb);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet1 ds = new DataSet1();
                ada.Fill(ds, "fiche_paie_student");
                fcli.SetDataSource(ds.Tables["fiche_paie_student"]);
                crystalReportViewer1.ReportSource = fcli;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.conndb.Close();
        }

        void invisibleField()
        {
            lblAnnee.Visible = false;
            cmbAnnee.Visible = false;
            cmbMatAgent.Visible = false;
            lblMatAgent.Visible = false;
            lblMois.Visible = false;
            cmbMois.Visible = false;

            lblSemestre.Visible = false;
            cmbSemestre.Visible = false;
            lblCatFrais.Visible = false;
            cmbFrais.Visible = false;
            lblMatEleve.Visible = false;
            cmbMatEleve.Visible = false;
            lblOption.Visible = false;
            cmbOption.Visible = false;
            lblClasse.Visible = false;
            cmbClasse.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Fiche d'inscription des eleves_classe 
            try
            {
                models.connection con = new models.connection();
                liste_student_classe_by_year listeeleves = new liste_student_classe_by_year();

                if (con.conndb.State != ConnectionState.Open)
                {
                    con.conndb.Open();
                }
                MySqlCommand cmd = new MySqlCommand("select * from liste_des_eleves where description_annee='" + cmbAnnee.Text + "' AND code_class='"+cmbClasse.Text+ "' AND code_option='"+cmbOption.Text+"'", con.conndb);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet1 ds = new DataSet1();
                ada.Fill(ds, "liste_des_eleves");
                listeeleves.SetDataSource(ds.Tables["liste_des_eleves"]);
                crystalReportViewer1.ReportSource = listeeleves;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.conndb.Close();
        }
    }
}
