using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_ecoles.models
{
     class Cl_semestre
    {
        // Addd période 
        connection connexion = new connection();
        public bool ajouter(string description, string dateDebut, string dateFin)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO semestre(`date_debut_sem`, `date_fin_sem`,`description_sem`) VALUES('" + dateDebut + "','" + dateFin + "','" + description + "')", connexion.conndb);

                // Ouverture de la connexion
                connexion.conndb.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    connexion.conndb.Close();
                    return true;
                }
                else
                {
                    connexion.conndb.Close();
                    
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return false;
        }



        public bool modifier(int id,string description, string dateDebut, string dateFin)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE semestre SET `date_debut_sem`='"+dateDebut+"', `date_fin_sem`='"+dateFin+"',`description_sem`='"+description+ "' WHERE id_semestre='"+id+"'", connexion.conndb);

                // Ouverture de la connexion
                connexion.conndb.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    connexion.conndb.Close();
                    return true;
                }
                else
                {
                    connexion.conndb.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }


        public bool suprimer(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM semestre WHERE id_semestre='" + id + "'", connexion.conndb);

                // Ouverture de la connexion
                connexion.conndb.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    connexion.conndb.Close();
                    return true;
                }
                else
                {
                    connexion.conndb.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
