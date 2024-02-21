using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
namespace gestion_ecoles.controls
{

    public partial class Gestion_studient : UserControl
    {

        // Création de l'instance 
        //Gestion_studient student = new Gestion_studient();

        private static Gestion_studient cl_student;
        models.connection conn = new models.connection();
        models.Cl_etudiant eleve = new models.Cl_etudiant();

        public static Gestion_studient instance
        {
            get
            {
                if (cl_student == null)
                {
                    cl_student = new Gestion_studient();
                }
                return cl_student;
            }


        }
        public Gestion_studient()
        {
            InitializeComponent();
            afficher("");
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Formulaires.Fr_inscrire_Student student = new Formulaires.Fr_inscrire_Student();
            student.ShowDialog();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            afficher("");
        }

        void afficher( string recherch)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `students` WHERE stdnames LIKE '%" + recherch + "%'", conn.conndb);
                conn.conndb.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                dgvStudient.Rows.Clear();
                int num = 0;
                while (rd.Read())
                {
                    num++;
                    dgvStudient.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(),rd[6].ToString(),rd[7].ToString(), rd[8].ToString(), rd[9].ToString(), rd[10].ToString(), rd[11].ToString(), rd[12].ToString(), rd[13].ToString(), rd[14].ToString());

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

        private void txtReseach_Enter(object sender, EventArgs e)
        {
            if (txtReseach.Text == "Recherche ......................")
                txtReseach.Text = "";
        }

        private void txtReseach_Leave(object sender, EventArgs e)
        {
            if (txtReseach.Text == "")
                txtReseach.Text = "Recherche ......................";
        }

        private void txtReseach_TextChanged(object sender, EventArgs e)
        {
            if (txtReseach.Text != "Recherche ......................" && txtReseach.Text != "")
                afficher(txtReseach.Text);
            else
                afficher("");
                
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvStudient.CurrentRow != null)
            {
                // Index

                string index = dgvStudient.CurrentRow.Cells[0].Value.ToString();
                if (eleve.supremmer(index) == true)
                {
                    MessageBox.Show("Suppression reussie");
                    afficher("");
                }
                else
                {
                    MessageBox.Show("Echec");
                }
            }
        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficher("");
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.Fr_inscrire_Student student = new Formulaires.Fr_inscrire_Student();
            student.btnClient.Visible = false;
            student.button2.Visible = true;
            student.button1.Visible = false;
            
            if (dgvStudient.CurrentRow != null)
            {
                // Index

                string index = dgvStudient.CurrentRow.Cells[0].Value.ToString();
                if (index!=null)
                {
                    student.txtMat.Text = index;
                    student.txtnomEleve.Text= dgvStudient.CurrentRow.Cells[1].Value.ToString();
                    student.cmbGenreEleve.Text= dgvStudient.CurrentRow.Cells[2].Value.ToString();
                    student.txtLieuNaissanceEleve.Text = dgvStudient.CurrentRow.Cells[3].Value.ToString();
                    student.dateNaissnceEleve.Text = dgvStudient.CurrentRow.Cells[4].Value.ToString();
                    student.txtEcoleProv.Text = dgvStudient.CurrentRow.Cells[5].Value.ToString();
                    student.txtReligion.Text = dgvStudient.CurrentRow.Cells[6].Value.ToString();
                    student.txtAdresse.Text = dgvStudient.CurrentRow.Cells[7].Value.ToString();
                    student.txtDocDeposes.Text = dgvStudient.CurrentRow.Cells[8].Value.ToString();
                    student.txtNomPere.Text = dgvStudient.CurrentRow.Cells[9].Value.ToString();
                    student.txtProfessionPere.Text = dgvStudient.CurrentRow.Cells[10].Value.ToString();
                    student.txtNomMere.Text = dgvStudient.CurrentRow.Cells[11].Value.ToString();
                    student.txtTelephoneTuteur.Text = dgvStudient.CurrentRow.Cells[12].Value.ToString();
                    student.txtpromere.Text = dgvStudient.CurrentRow.Cells[13].Value.ToString();
                    //student.txtNomTuteur.Text = dgvStudient.CurrentRow.Cells[14].Value.ToString();


                    student.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Echec");
                }
            }
        }

        private void cmdupload_Click(object sender, EventArgs e)
        {
            Formulaires.RecordsFromExcel recordsFromExcelForm = new Formulaires.RecordsFromExcel(); 
            recordsFromExcelForm.ShowDialog();
            
            //dgvStudient.Rows.Clear();
            ////Load data from Excel to datagrid view
            //Microsoft.Office.Interop.Excel.Application x1app;
            //Microsoft.Office.Interop.Excel.Workbook x1workbook;
            //Microsoft.Office.Interop.Excel.Worksheet x1worksheet;
            //Microsoft.Office.Interop.Excel.Range x1range;

            //int x1Rows;
            //String strFileName;
            //openFD.Filter = " Excel Office |*.xls; *xlsx";
            //openFD.ShowDialog();
            //strFileName = openFD.FileName;

            //if (strFileName != "")
            //{
            //    x1app = new Microsoft.Office.Interop.Excel.Application();
            //    x1workbook = x1app.Workbooks.Open(strFileName);
            //    x1worksheet = x1workbook.Worksheets["eleves$"];
            //    x1range = x1worksheet.UsedRange;

            //    int i = 0;
            //    for (x1Rows = 2; x1Rows <= x1range.Rows.Count; x1Rows++)
            //    {
            //        if (x1range.Cells[x1Rows, 1].Text != 0)
            //        {
            //            i++;
            //            dgvStudient.Rows.Add(i, x1range.Cells[x1Rows, 1].Text, x1range.Cells[x1Rows, 2].Text, x1range.Cells[x1Rows, 3].Text, x1range.Cells[x1Rows, 4].Text, x1range.Cells[x1Rows, 5].Text, x1range.Cells[x1Rows, 7].Text, x1range.Cells[x1Rows, 8].Text, x1range.Cells[x1Rows, 9].Text, x1range.Cells[x1Rows, 10].Text, x1range.Cells[x1Rows, 11].Text, x1range.Cells[x1Rows, 12].Text, x1range.Cells[x1Rows, 13].Text);
            //        }
            //    }

            //    x1workbook.Close();
            //    x1app.Quit();


           // }  
        }

       
        
    }
}
