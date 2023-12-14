using Microsoft.WindowsAppSDK.Runtime.Packages;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    internal class SingletonProjet
    {
        static SingletonProjet instance = null;
        MySqlConnection con;
        ObservableCollection<Projet> liste;

        public SingletonProjet()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info;Database=a2023_420325ri_fabeq12;Uid=2266983;Pwd=2266983;");
            liste = new ObservableCollection<Projet>();
        }

        public static SingletonProjet getInstance()
        {
            if (instance == null)
                instance = new SingletonProjet();

            return instance;
        }

        public ObservableCollection<Projet> GetListeProjet()
        {
            liste.Clear();
            try
            {
                MySqlCommand commande = new MySqlCommand("p_afficher_projets");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                MySqlDataReader r = commande.ExecuteReader();
                while (r.Read())
                {
                    string no_projet = (string)r["no_projet"];
                    string titre = (string)r["titre"];
                    string date_debut = Convert.ToString(r["date_debut"]);
                    string description = (string)r["description"];
                    decimal budget = (decimal)r["budget"];
                    int nb_employe = (int)r["nb_employe"];
                    decimal total_salaire = (decimal)r["total_salaire"];
                    int client = (int)r["client"];
                    string statut = (string)r["statut"];
                    Projet projet = new Projet(no_projet,titre,date_debut,description,budget,nb_employe,total_salaire,client,statut);

                    liste.Add(projet);
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

        public void AjoutProjet(string no_projet, string titre, string date_debut, string description, decimal budget, int nb_employe, decimal total_salaire, int client, string statut)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand("p_ajout_projets");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("no_projet_", no_projet);
                commande.Parameters.AddWithValue("titre_", titre);
                commande.Parameters.AddWithValue("date_debut_", date_debut);
                commande.Parameters.AddWithValue("description_", description);
                commande.Parameters.AddWithValue("budget_", budget);
                commande.Parameters.AddWithValue("nb_employe_", nb_employe);
                commande.Parameters.AddWithValue("total_salaire_", total_salaire);
                commande.Parameters.AddWithValue("client_", client);
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
        /*
            public Maison getMaison(int position)
            {
                return liste[position];
            }

            public void ajouter(Maison maison)
            {
                string categorie = maison.Categorie;
                decimal prix = maison.Prix;
                string ville = maison.Ville;
                int id_proprietaire = maison.Id_proprietaire;
                try
                {
                    MySqlCommand commande = new MySqlCommand("p_ajouter_maison");
                    commande.Connection = con;
                    commande.CommandType = System.Data.CommandType.StoredProcedure;

                    commande.Parameters.AddWithValue("categorie", categorie);
                    commande.Parameters.AddWithValue("prix", prix);
                    commande.Parameters.AddWithValue("ville", ville);
                    commande.Parameters.AddWithValue("id_proprietaire", id_proprietaire);

                    con.Open();
                    commande.Prepare();
                    commande.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close();
                }

                liste.Add(maison);
            }
        
        public void modifier(int position, Employe maison)
        {
            liste[position] = maison;
        }

        public void supprimer(int position)
        {
            liste.RemoveAt(position);
        }
        */
    }
}
