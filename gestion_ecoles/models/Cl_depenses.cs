using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_ecoles.models
{
   class Cl_depenses
    {
        models.connection conn = new connection();



        // Depenses 
        public bool supprimer(int iddepense)
        {
            try
            {
                conn.conndb.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM depenses WHERE`id_depense`='"+iddepense+"'", conn.conndb);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    conn.conndb.Close();
                    return true;

                }
                conn.conndb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }


        public bool supprimerAfft(int iddepense)
        {
            try
            {
                conn.conndb.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM aff_depenses WHERE`id_depense`='" + iddepense + "'", conn.conndb);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    conn.conndb.Close();
                    return true;

                }
                conn.conndb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
