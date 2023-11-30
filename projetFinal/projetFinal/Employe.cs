using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    class Employe
    {
        string nom, prenom, date_naissance, email, adresse, date_embauche, photo, statut;
        decimal taux_horaire;

        public Employe()
        {
            nom = "Employe";
            prenom = "Un";
            date_naissance = "2000-01-01";
            email = "employe@gmail.com";
            adresse = "123 Rue principal";
            date_embauche = "1990-01-01";
            taux_horaire = 15;
            photo = "https://static.vecteezy.com/system/resources/previews/003/337/584/non_2x/default-avatar-photo-placeholder-profile-icon-vector.jpg";
            statut = "Permanent";
        }

        public Employe(string nom, string prenom, string date_naissance, string email, string adresse, string date_embauche, string photo, string statut, decimal taux_horaire)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
            this.email = email;
            this.adresse = adresse;
            this.date_embauche = date_embauche;
            this.photo = photo;
            this.statut = statut;
            this.taux_horaire = taux_horaire;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Date_naissance { get => date_naissance; set => date_naissance = value; }
        public string Email { get => email; set => email = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Date_embauche { get => date_embauche; set => date_embauche = value; }
        public string Photo { get => photo; set => photo = value; }
        public string Statut { get => statut; set => statut = value; }
        public decimal Taux_horaire { get => taux_horaire; set => taux_horaire = value; }

        public override bool Equals(object obj)
        {
            return obj is Employe employe &&
                   nom == employe.nom &&
                   prenom == employe.prenom &&
                   date_naissance == employe.date_naissance &&
                   email == employe.email &&
                   adresse == employe.adresse &&
                   date_embauche == employe.date_embauche &&
                   photo == employe.photo &&
                   statut == employe.statut &&
                   taux_horaire == employe.taux_horaire &&
                   Nom == employe.Nom &&
                   Prenom == employe.Prenom &&
                   Date_naissance == employe.Date_naissance &&
                   Email == employe.Email &&
                   Adresse == employe.Adresse &&
                   Date_embauche == employe.Date_embauche &&
                   Photo == employe.Photo &&
                   Statut == employe.Statut &&
                   Taux_horaire == employe.Taux_horaire;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(nom);
            hash.Add(prenom);
            hash.Add(date_naissance);
            hash.Add(email);
            hash.Add(adresse);
            hash.Add(date_embauche);
            hash.Add(photo);
            hash.Add(statut);
            hash.Add(taux_horaire);
            hash.Add(Nom);
            hash.Add(Prenom);
            hash.Add(Date_naissance);
            hash.Add(Email);
            hash.Add(Adresse);
            hash.Add(Date_embauche);
            hash.Add(Photo);
            hash.Add(Statut);
            hash.Add(Taux_horaire);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"Nom = {nom} Prenom = {prenom} Date de naissance = {date_naissance} " +
                $"Email = {email} Adresse = {adresse} Date d'embauche {date_embauche} Taux horaire = {taux_horaire} Photo = {photo} Statut = {statut}";
        }
    }
}
