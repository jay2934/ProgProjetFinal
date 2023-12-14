using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    internal class SingletonClient
    {

        static SingletonClient instance = null;
        MySqlConnection con;
        ObservableCollection<Client> liste;

        public SingletonClient()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info;Database=a2023_420325ri_fabeq12;Uid=2266983;Pwd=2266983;");
            liste = new ObservableCollection<Client>();
        }

        public static SingletonClient getInstance()
        {
            if (instance == null)
                instance = new SingletonClient();

            return instance;
        }

        public ObservableCollection<Client> GetListeClient()
        {
            liste.Clear();
            try
            {
                MySqlCommand commande = new MySqlCommand("p_afficher_clients");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                MySqlDataReader r = commande.ExecuteReader();
                while (r.Read())
                {
                    int identifiant = (int)r["identifiant"];
                    string nom = (string)r["nom"];
                    string adresse = (string)r["adresse"];
                    string no_telephone = (string)r["no_telephone"];
                    string email = (string)r["email"];
                    Client client = new Client(identifiant, nom, adresse, no_telephone, email);

                    liste.Add(client);
                }

                r.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                con.Close();
            }

            return liste;
        }
/*
        public void AjoutEmploye(string nom, string prenom, string date_naissance, string email, string adresse, string date_embauche, decimal taux_horaire, string photo, string statut)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand("p_ajout_employes");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("nom_", nom);
                commande.Parameters.AddWithValue("prenom_", prenom);
                commande.Parameters.AddWithValue("date_naissance_", date_naissance);
                commande.Parameters.AddWithValue("email_", email);
                commande.Parameters.AddWithValue("adresse_", adresse);
                commande.Parameters.AddWithValue("date_embauche_", date_embauche);
                commande.Parameters.AddWithValue("taux_horaire_", taux_horaire);
                commande.Parameters.AddWithValue("photo_", photo);
                commande.Parameters.AddWithValue("statut_", statut);

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

        public void ModifierEmploye(string matricule, string nom, string prenom, string email, string adresse, decimal taux_horaire, string photo)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand("p_modifier_employes");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("matricule_", matricule);
                commande.Parameters.AddWithValue("nom_", nom);
                commande.Parameters.AddWithValue("prenom_", prenom);
                commande.Parameters.AddWithValue("email_", email);
                commande.Parameters.AddWithValue("adresse_", adresse);
                commande.Parameters.AddWithValue("taux_horaire_", taux_horaire);
                commande.Parameters.AddWithValue("photo_", photo);

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

        public void ModifierStatutEmploye(string matricule, string statut)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand("p_statut_employes");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("matricule_", matricule);
                commande.Parameters.AddWithValue("statut_", statut);

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

        public Employe getEmploye(int position)
        {
            return liste[position];
        }
*/
    }
}
