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
    public partial class FrmAjouterMois : Form
    {
        models.Cl_mois mois = new models.Cl_mois();
        models.connection conn = new models.connection();
        public FrmAjouterMois()
        {
            InitializeComponent();
            affichMois();
        }

        private void txtNomCours_Leave(object sender, EventArgs e)
        {
            if (txtNomCours.Text == "") txtNomCours.Text = "Description mois";
        }

        private void txtNomCours_Enter(object sender, EventArgs e)
        {
            if (txtNomCours.Text == "Description mois") txtNomCours.Text = "";
        }

        private void btnAddClasse_Click(object sender, EventArgs e)
        {
            // Enregistrement mois 
            if (txtNomCours.Text != "" && txtNomCours.Text != "Description mois")
            {
                if (mois.ajouter(txtNomCours.Text) == true) MessageBox.Show("Enregistrement réussi");
                else MessageBox.Show("Echec");
                txtNomCours.Text = "Description mois";
            }
            else MessageBox.Show("Champ obligatoire");
        }


        void affichMois()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * from mois", conn.conndb);
                conn.conndb.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                dgvMois.Rows.Clear();
                int num = 0;
                while (rd.Read())
                {
                    num++;
                    dgvMois.Rows.Add(rd[0].ToString(), num, rd[1].ToString());

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

        private void FrmAjouterMois_Click(object sender, EventArgs e)
        {
            affichMois();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomCours.Text != "" && txtNomCours.Text != "Description mois")
            {
                if (mois.modifier(int.Parse(txtId.Text),txtNomCours.Text) == true) MessageBox.Show("Modification réussi");
                else MessageBox.Show("Echec");
                txtNomCours.Text = "Description mois";
                affichMois();
            }
            else MessageBox.Show("Champ obligatoire");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                if (mois.supprimer(int.Parse(txtId.Text)) == true) MessageBox.Show("Suppression réussi");
                else MessageBox.Show("Echec");
                txtNomCours.Text = "Description mois";
                affichMois();
            }
            else MessageBox.Show("Veuillez selectionner une ligne dans le tableau");
        }

        private void dgvMois_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMois.Rows.Count > 0)
            {
                txtNomCours.Text = dgvMois.CurrentRow.Cells[2].Value.ToString();
                txtId.Text= dgvMois.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
