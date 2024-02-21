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
    public partial class frmCateFrais : Form
    {
        // Instance de la classe frais
        models.connection conn = new models.connection();
        models.Cl_frais frais = new models.Cl_frais();
        public frmCateFrais()
        {
            InitializeComponent();
            afficher();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "")
            {
                if (frais.categorie_frais(txtDescription.Text) == true)
                {
                    MessageBox.Show("Catégorie ajoutée");
                    txtDescription.Clear();
                    afficher();
                }
                else MessageBox.Show("Echec d'enregistrement");
            }
            else MessageBox.Show("Completer le champ");
        }

        void afficher()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `categorie_frais`", conn.conndb);
                conn.conndb.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                dgvCatégorieFrais.Rows.Clear();
                int num = 0;
                while (rd.Read())
                {
                    num++;
                    dgvCatégorieFrais.Rows.Add(rd[0].ToString(), num, rd[1].ToString());

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

        private void frmCateFrais_Click(object sender, EventArgs e)
        {
            afficher();
        }

        private void dgvCatégorieFrais_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvCatégorieFrais.Rows.Count > 0)
            {
               txtDescription.Text = dgvCatégorieFrais.CurrentRow.Cells[2].Value.ToString();
                txtId.Text = dgvCatégorieFrais.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "" && txtId.Text!="")
            {
                if (frais.modifier(int.Parse(txtId.Text),txtDescription.Text) == true)
                {
                    MessageBox.Show("ajoutée Modifiée");
                    txtDescription.Clear();
                    txtId.Clear();
                    afficher();
                }
                else MessageBox.Show("Echec de modification");
            }
            else MessageBox.Show("Veuillez selctionner une ligne dans le tableau");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                if (frais.supprimer(int.Parse(txtId.Text)) == true)
                {
                    MessageBox.Show("Catégorie supprimée");
                    txtDescription.Clear();
                    txtId.Clear();
                    afficher();

                }
                else MessageBox.Show("Echec de suppression");
            }
            else MessageBox.Show("Veuillez selctionner une ligne dans le tableau");
        }
    }
}
