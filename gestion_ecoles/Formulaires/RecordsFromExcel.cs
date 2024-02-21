using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_ecoles.Formulaires
{
    public partial class RecordsFromExcel : Form
    {
        MySqlCommand cmd;
        string matricule;
        models.connection conn=new models.connection();
        public RecordsFromExcel()
        {
            InitializeComponent();
            remplireAnneeScolaire();
            remplireCmbClasse();
            remplireCmbOption();
            remplireEcole();
        }
        public string Nomfichier;
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BrowsD = new OpenFileDialog();
                BrowsD.Multiselect = false;
                BrowsD.Filter = "Excel Files(*.XLS;*XLSX;)|*.XLS;*XLSX;";
                BrowsD.Title = "select a Excel File.";
                BrowsD.FilterIndex = 1;
                BrowsD.RestoreDirectory = true;
                if (BrowsD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Nomfichier= BrowsD.FileName;
                    txtFilePath.Text = BrowsD.FileName;
                    btnsave.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {

            DataSet dat = default(DataSet);
            dat = new DataSet();

            //declaration  et utilisation de oledbconnection
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"
                + "Data Source='" + Nomfichier + "';Extended Properties=\"Excel 12.0;\""))
            {
                conn.Open();
                //declaration du dataadapter
                //la requette selectionner pour tous les champs de la feuille une

                string table = txtfeuille.Text;

                using (OleDbDataAdapter Adap = new OleDbDataAdapter("SELECT * FROM [" + table + "$]", conn))
                {
                    Adap.TableMappings.Add("Table", "TestTable");
                    //chargement du dataset
                    Adap.Fill(dat);
                    //on binde les donnes sur le DGV
                  dgvstudent.DataSource = dat.Tables[0];
                }
                //A la fin on ferme la connexion
                conn.Close();
            }

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
           // dgvstudent.Rows.Clear();
            try
            {
                models.Cl_etudiant et = new models.Cl_etudiant();
                string dateInscripti = string.Format("{0}-{1}-{2}", dateInscription.Value.Year, dateInscription.Value.Month, dateInscription.Value.Day);
                for (int i = 0;i < dgvstudent.Rows.Count; i++)
                {
                    conn.conndb.Open();
                    // Création de matricule de l'élève
                    // Compteur 
                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(num_mat) as compte from students", conn.conndb);
                    MySqlDataReader rd = cmd.ExecuteReader();
                    int compt = 0;
                    if (rd.Read())
                    {
                        compt = int.Parse(rd[0].ToString()) + 1;
                    }
                    rd.Close();


                    if (dgvstudent.Rows[i].Cells[0].Value!=null)
                    {
                        string mateleve1 = dgvstudent.Rows[i].Cells[0].Value.ToString();
                        mateleve1 = mateleve1.Substring(0, 2);
                        string mateleve2 = dgvstudent.Rows[i].Cells[1].Value.ToString();
                        mateleve2 = mateleve2.Substring(0, 2);

                        matricule = mateleve1 + "" + mateleve2 + compt + "/" + cmbAnneeScolaire.Text;
                        string noms = dgvstudent.Rows[i].Cells[0].Value.ToString() + " " + dgvstudent.Rows[i].Cells[1].Value.ToString() + " " + dgvstudent.Rows[i].Cells[2].Value.ToString();
                        cmd = new MySqlCommand("INSERT INTO students(num_mat,stdnames,genre,lieu_naissance,date_naissance,ecole_provenance,religion,adresse,documents_deposes,noms_pere,profession_pere,tele_tuteur,noms_mere,tuteur)  VALUES(@matricule,@noms,@genre,@lieu_naissance,@date_naissance,@ecole_provenance,@religion,@adresse,@documents_deposes,@noms_pere,@profession_pere,@tele_tuteur,@noms_mere,@tuteur)", conn.conndb);
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.Parameters.AddWithValue("@noms", noms);
                        cmd.Parameters.AddWithValue("@genre", dgvstudent.Rows[i].Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("@lieu_naissance", dgvstudent.Rows[i].Cells[4].Value.ToString());
                        cmd.Parameters.AddWithValue("@date_naissance", dgvstudent.Rows[i].Cells[5].Value.ToString());
                        cmd.Parameters.AddWithValue("@ecole_provenance", dgvstudent.Rows[i].Cells[6].Value.ToString());
                        cmd.Parameters.AddWithValue("@religion", dgvstudent.Rows[i].Cells[7].Value.ToString());
                        cmd.Parameters.AddWithValue("@adresse", dgvstudent.Rows[i].Cells[8].Value.ToString());
                        cmd.Parameters.AddWithValue("@documents_deposes", dgvstudent.Rows[i].Cells[9].Value.ToString());
                        cmd.Parameters.AddWithValue("@noms_pere", dgvstudent.Rows[i].Cells[10].Value.ToString());
                        cmd.Parameters.AddWithValue("@profession_pere", dgvstudent.Rows[i].Cells[11].Value.ToString());
                        cmd.Parameters.AddWithValue("@tele_tuteur", dgvstudent.Rows[i].Cells[12].Value.ToString());
                        cmd.Parameters.AddWithValue("@noms_mere", dgvstudent.Rows[i].Cells[13].Value.ToString());
                        cmd.Parameters.AddWithValue("@profession_mere", dgvstudent.Rows[i].Cells[14].Value.ToString());
                        cmd.Parameters.AddWithValue("@tuteur", dgvstudent.Rows[i].Cells[15].Value.ToString());
                        cmd.ExecuteNonQuery();
                        conn.conndb.Close();

                        et.inscriret(dateInscripti, cmbClasse.Text, cmbOption.Text, cmbAnneeScolaire.Text, txtSecope.Text, matricule);
                    }

                    
                }
                    MessageBox.Show("Inscription reussie", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                conn.conndb.Close();
                DialogResult dialog = MessageBox.Show(ex.ToString());
           
            }
            conn.conndb.Close();
        }







        void remplireCmbClasse()
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM classes", conn.conndb);

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

        void remplireCmbOption()
        {
            try
            {
                // Ouverture de la connexion à la BDD
                conn.conndb.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM options", conn.conndb);
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

        void remplireAnneeScolaire()
        {

            try
            {
                // Ouverture de la connexion à la BDD
                conn.conndb.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM school_year", conn.conndb);



                MySqlDataReader rd = cmd.ExecuteReader();
                cmbAnneeScolaire.Items.Clear();
                while (rd.Read())
                {
                    cmbAnneeScolaire.Items.Add(rd[1]).ToString();
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

        void remplireEcole()
        {
            try
            {
                conn.conndb.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM school", conn.conndb);

                // Ouverture de la connexion à la BDD


                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtSecope.Text = rd[0].ToString();
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

    }
}