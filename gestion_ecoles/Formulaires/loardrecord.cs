using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using gestion_ecoles.models;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DataTable = System.Data.DataTable;
using System.Data.OleDb;


namespace gestion_ecoles.Formulaires
{
    public partial class loardrecord : Form
    {
        public loardrecord()
        {
            InitializeComponent();
        
        }
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataReader dr=null;
        public MySqlConnection con = new MySqlConnection();
        private void cmdupload_Click(object sender, EventArgs e)
        {
            try
            {
                //Load data from Excel to datagrid view
                Microsoft.Office.Interop.Excel.Application x1app;
                Microsoft.Office.Interop.Excel.Workbook x1workbook;
                Microsoft.Office.Interop.Excel.Worksheet x1worksheet;
                Microsoft.Office.Interop.Excel.Range x1range;

                int x1Rows;
                String strFileName;
                openFD.Filter = " Excel Office |*.xls; *xlsx";
                openFD.ShowDialog();
                strFileName = openFD.FileName;

                if (strFileName != "")
                {
                    x1app = new Microsoft.Office.Interop.Excel.Application();
                    x1workbook = x1app.Workbooks.Open(strFileName);
                    x1worksheet = x1workbook.Worksheets["eleves"];
                    x1range = x1worksheet.UsedRange;

                    int i = 0;
                    for (x1Rows = 2; x1Rows <= x1range.Rows.Count; x1Rows++)
                    {
                        if (x1range.Cells[x1Rows, 1].Text != 0)
                        {
                            i++;
                            dgvStudient.Rows.Add(i, x1range.Cells[x1Rows, 1].Text, x1range.Cells[x1Rows, 2].Text, x1range.Cells[x1Rows, 3].Text, x1range.Cells[x1Rows, 4].Text, x1range.Cells[x1Rows, 5].Text, x1range.Cells[x1Rows, 7].Text, x1range.Cells[x1Rows, 8].Text, x1range.Cells[x1Rows, 9].Text, x1range.Cells[x1Rows, 10].Text, x1range.Cells[x1Rows, 11].Text, x1range.Cells[x1Rows, 12].Text, x1range.Cells[x1Rows, 13].Text);
                        }
                    }

                    x1workbook.Close();
                    x1app.Quit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        private void GetExcel()
        {
           
            DataTable DT = new DataTable();
            try
            {
                if (txtFilePath.Text != "")
                {
                    string connectionString = "Provider=Microsof.ACE.OLEDB.12.0;data source'" + txtFilePath.Text + "';Extended Properties=\"Excel 8.0;HDR=NO;EMEX=1\"";
                    con = new MySqlConnection();
                    con.ConnectionString= connectionString;
                  con.Open();
                    cmd = new MySqlCommand("select * from [eleves$]",con);
                    dr = cmd.ExecuteReader();
                    DT.Load(dr);
                    dgvStudient.DataSource = DT;
                    con.Close();
                }
            }catch (Exception ex)
            {
                //MessageBox.Show("there was an error", "Data import");
                btnsave.Enabled = false;
            }

        }
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BrowsD = new OpenFileDialog();
                BrowsD.Multiselect = false;
                BrowsD.Filter = "Excel Files(*.XLS;*XLSX;)|*.XLS;*XLSX;";
                BrowsD.Title = "select a Excel File.";
                BrowsD.FilterIndex = 1;
                BrowsD.RestoreDirectory= true;
                if(BrowsD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtFilePath.Text = BrowsD.FileName;
                   GetExcel();
                    btnsave.Enabled=true;

                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {


            //GetExcel();
            //btnsave.Enabled=false;
            ////string connectionString ="Provider=Microsof.ACE.OLEDB.12.0;data source'" + txtFilePath.Text + "';Extended Properties=\"Excel 8.0;HDR=NO;EMEX=1\"";
            ////OleDbConnection  theconnection = new OleDbConnection();
            ////theconnection.ConnectionString = connectionString;
            ////theconnection.Open();
            ////OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from [eleves$]",theconnection);
            ////DataSet ds=new DataSet();
            ////DataTable dt = new DataTable();
            ////oleDbDataAdapter.Fill(dt);
            ////this.dgvStudient.DataSource = dt.DefaultView;
        }
    }
}
