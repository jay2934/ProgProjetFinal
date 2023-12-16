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
    class Singleton
    {
        static Singleton instance = null;
        MySqlConnection con;

        public Singleton()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info;Database=a2023_420325ri_fabeq12;Uid=2266983;Pwd=2266983;");
        }

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }

        public Admin CheckAdmin()
        {
            try
            {
                MySqlCommand commande = new MySqlCommand("p_afficher_admin");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                MySqlDataReader r = commande.ExecuteReader();
                if (r.Read()) //Si reussie a lire un admin dans BD, le retourner
                {
                    int id = (int)r["id"];
                    string nom = (string)r["nom"];
                    string mot_de_passe = (string)r["mot_de_passe"];

                    Admin admin = new Admin(id, nom, mot_de_passe);

                    return admin;
                }
                else
                {
                    return new Admin(0, null, null); //Sinon je retourne un admin null
                }
            }
            catch (MySqlException ex)
            {
                return new Admin(); //Si des erreurs, je retourne un admin avec le constructeur de base
            }
            finally
            { 
                con.Close(); //Dans tout les cas, fermer la connexion
            }
        }

        public void AjoutAdmin(string nom, string mot_de_passe)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand("p_ajout_admin");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("nom_", nom);
                commande.Parameters.AddWithValue("mot_de_passe_", mot_de_passe);

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
    }
}
