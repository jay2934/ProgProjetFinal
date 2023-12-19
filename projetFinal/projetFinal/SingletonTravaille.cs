using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    internal class SingletonTravaille
    {
        static SingletonTravaille instance = null;
        MySqlConnection con;
        ObservableCollection<Travaille> liste;

        public SingletonTravaille()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info;Database=a2023_420325ri_fabeq12;Uid=2266983;Pwd=2266983;");
            liste = new ObservableCollection<Travaille>();
        }

        public static SingletonTravaille getInstance()
        {
            if (instance == null)
                instance = new SingletonTravaille();

            return instance;
        }

        public void AjoutTravaille(string matricule, string no_projet, int nb_heure_travaille, decimal salaire)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand("p_ajout_travailles");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("matricule_", matricule);
                commande.Parameters.AddWithValue("no_projet_", no_projet);
                commande.Parameters.AddWithValue("nb_heure_travaille_", nb_heure_travaille);
                commande.Parameters.AddWithValue("salaire_", salaire);

                con.Open();

                commande.Prepare();
                commande.ExecuteNonQuery();

                con.Close();
            }
            catch (MySqlException ex)
            {
                con.Close();
            }
        }

        public string getNoEmploye(string nom)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand("p_get_employes");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;
                commande.Parameters.AddWithValue("nom_", nom);

                con.Open();

                MySqlDataReader r = commande.ExecuteReader();
                r.Read();

                string matricule = (string)r["matricule"];

                r.Close();
                con.Close();

                return matricule;
            }
            catch (MySqlException ex)
            {
                con.Close();
                return "error";
            }
        }
    }
}
