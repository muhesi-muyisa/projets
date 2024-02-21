﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_ecoles.Formulaires
{
    public partial class Frm_semestre : Form
    {
        models.connection conn = new models.connection();
        models.Cl_semestre semestre = new models.Cl_semestre();
        public Frm_semestre()
        {
            InitializeComponent();
            affichPeriode();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text!="")
            {
                string datedebut = string.Format("{0}-{1}-{2}", dateDebut.Value.Year, dateDebut.Value.Month, dateDebut.Value.Day);
                string datefin = string.Format("{0}-{1}-{2}", dateFin.Value.Year, dateFin.Value.Month, dateFin.Value.Day);
                if (semestre.ajouter(txtDescription.Text,datedebut,datefin) ==true)
                {
                    MessageBox.Show("Enregistrement réussi");
                    affichPeriode();
                }
                else
                {
                    MessageBox.Show("Echec");
                }
            }
        }

        void affichPeriode()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * from semestre", conn.conndb);
                conn.conndb.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                dgvSemestre.Rows.Clear();
                int num = 0;
                while (rd.Read())
                {
                    num++;
                    dgvSemestre.Rows.Add(rd[0].ToString(), num, rd[1].ToString(), rd[2].ToString(), rd[3].ToString());

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

        private void dgvSemestre_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvSemestre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSemestre.Rows.Count > 0)
            {
                txtDescription.Text = dgvSemestre.CurrentRow.Cells[2].Value.ToString();
                txtId.Text= dgvSemestre.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="" && semestre.suprimer(int.Parse(txtId.Text))==true)
            {
                MessageBox.Show("Suppression effectuée");
                txtId.Text = "";
                txtDescription.Clear();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne du tableau");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "")
            {
                string datedebut = string.Format("{0}-{1}-{2}", dateDebut.Value.Year, dateDebut.Value.Month, dateDebut.Value.Day);
                string datefin = string.Format("{0}-{1}-{2}", dateFin.Value.Year, dateFin.Value.Month, dateFin.Value.Day);
                if (txtId.Text!="" && semestre.modifier(int.Parse(txtId.Text),txtDescription.Text, datedebut, datefin) == true)
                {
                    MessageBox.Show("Modification réussi");
                    affichPeriode();
                    txtId.Text = "";
                    txtDescription.Clear();
                }
                else
                {
                    MessageBox.Show("Echec");
                }
            }
        }
    }
}
