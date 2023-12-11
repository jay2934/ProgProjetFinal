﻿using Microsoft.WindowsAppSDK.Runtime.Packages;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    internal class SingletonEmploye
    {
        static SingletonEmploye instance = null;
        MySqlConnection con;
        ObservableCollection<Employe> liste;

        public SingletonEmploye()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info;Database=a2023_420325ri_fabeq12;Uid=2266983;Pwd=2266983;");
            liste = new ObservableCollection<Employe>();
        }

        public static SingletonEmploye getInstance()
        {
            if (instance == null)
                instance = new SingletonEmploye();

            return instance;
        }

        public ObservableCollection<Employe> GetListeEmploye()
        {
            liste.Clear();
            try
            {
                MySqlCommand commande = new MySqlCommand("p_afficher_employes");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                MySqlDataReader r = commande.ExecuteReader();
                while (r.Read())
                {
                    string matricule = (string)r["matricule"];
                    string nom = (string)r["nom"];
                    string prenom = (string)r["prenom"];
                    string date_naissance = Convert.ToString(r["date_naissance"]);
                    date_naissance = date_naissance.Remove(11);
                    string email = (string)r["email"];
                    string adresse = (string)r["adresse"];
                    string date_embauche = Convert.ToString(r["date_embauche"]);
                    date_embauche = date_embauche.Remove(11);
                    decimal taux_horaire = (decimal)r["taux_horaire"];
                    string photo = (string)r["photo"];
                    string statut = (string)r["statut"];
                    Employe employe = new Employe(matricule, nom, prenom, date_naissance, email, adresse, date_embauche, photo, statut, taux_horaire);

                    liste.Add(employe);
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
        */
        public void modifier(int position, Employe maison)
        {
            liste[position] = maison;
        }

        public void supprimer(int position)
        {
            liste.RemoveAt(position);
        }
    }
}