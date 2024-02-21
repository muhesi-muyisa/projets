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

namespace gestion_ecoles.Formulaires
{
    public partial class FrmPeriode : Form
    {
        models.connection conn = new models.connection();
        models.Cl_periode periode = new models.Cl_periode();
        public FrmPeriode()
        {
            InitializeComponent();
            affich();
            affichPeriode();
            txtId.Text = "";
            btnClient.Visible = true;
            button1.Visible = false;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "" && cmbSemestre.Text != "")
            {
                string datedebut = string.Format("{0}-{1}-{2}", dateDebut.Value.Year, dateDebut.Value.Month, dateDebut.Value.Day);
                string datefin = string.Format("{0}-{1}-{2}", dateFin.Value.Year, dateFin.Value.Month, dateFin.Value.Day);
                if (periode.ajouter(cmbSemestre.Text,txtDescription.Text,datedebut,datefin)==true)
                {
                    MessageBox.Show("Enregistrement réussi");
                    txtDescription.Clear();
                    cmbSemestre.Text = "";

                    // Affuicher période 
                    affichPeriode();
                }
                else
                {
                    MessageBox.Show("Echec");
                }
            }
            else MessageBox.Show("Tous les champs sont nécessaires");
        }

        // Selection 
        void affich()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * from semestre",conn.conndb);
                conn.conndb.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                cmbSemestre.Items.Clear();
                while (rd.Read())
                {
                    cmbSemestre.Items.Add ( rd[1].ToString());
                    
                }rd.Close();
                conn.conndb.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.conndb.Close();
            }
        }

        void affichPeriode()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT `id_periode`, `date_debut`, `date_fin`, `description_sem`, `description` FROM semestre,periode WHERE periode.id_semestre=semestre.id_semestre", conn.conndb);
                conn.conndb.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                dgvPeriode.Rows.Clear();
                int num = 0;
                while (rd.Read())
                {
                    num++;
                    dgvPeriode.Rows.Add(rd[0].ToString(), num, rd[4].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString());

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

        private void sUPPRIMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Suppression 

            if (dgvPeriode.CurrentRow != null)
            {
                // Index

                int index = int.Parse(dgvPeriode.CurrentRow.Cells[0].Value.ToString());

                txtId.Text = index.ToString();
                if (periode.supprimer(index) == true)
                {
                    MessageBox.Show("Suppression reussie");
                    affichPeriode();
                }
                else
                {
                    MessageBox.Show("Echec");
                }
            }
            else
            {
                    MessageBox.Show("Vieullez selectionner");
               
            }
        }

        private void mODIFIERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Modification 
            if (dgvPeriode.CurrentRow != null)
            {
                // Index
                btnClient.Visible = false;
                button1.Visible = true;
                txtId.Text = dgvPeriode.CurrentRow.Cells[0].Value.ToString();
                cmbSemestre.Text= dgvPeriode.CurrentRow.Cells[5].Value.ToString();
                txtDescription.Text= dgvPeriode.CurrentRow.Cells[2].Value.ToString();


            }
            else
            {
                MessageBox.Show("Vieullez selectionner");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string datedebut = string.Format("{0}-{1}-{2}", dateDebut.Value.Year, dateDebut.Value.Month, dateDebut.Value.Day);
                string datefin = string.Format("{0}-{1}-{2}", dateFin.Value.Year, dateFin.Value.Month, dateFin.Value.Day);
                if (periode.modifier(int.Parse(txtId.Text),cmbSemestre.Text, txtDescription.Text, datedebut, datefin) == true)
                {
                    MessageBox.Show("Enregistrement réussi");
                    txtDescription.Clear();
                    cmbSemestre.Text = "";


                    // Affuicher période 
                    affichPeriode();
                    btnClient.Visible = true;
                    button1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Echec");
                }
            
        }
    }
}
