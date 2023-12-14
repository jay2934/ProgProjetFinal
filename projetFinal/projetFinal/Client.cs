using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    class Client
    {
        string nom, adresse, no_telephone, email;
        int identifiant;
        public Client() {
            identifiant = 000;
            nom = "Client";
            adresse = "123 Rue principal";
            no_telephone = "123-456-7890";
            email = "client@gmail.com";
        }

        public Client (int identifiant, string nom, string adresse, string no_telephone, string email)
        {
            this.identifiant = identifiant;
            this.nom = nom;
            this.adresse = adresse;
            this.no_telephone = no_telephone;
            this.email = email;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string No_telephone { get => no_telephone; set => no_telephone = value; }
        public string Email { get => email; set => email = value; }
        public int Identifiant { get => identifiant; set => identifiant = value; }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   nom == client.nom &&
                   adresse == client.adresse &&
                   no_telephone == client.no_telephone &&
                   email == client.email &&
                   identifiant == client.identifiant &&
                   Nom == client.Nom &&
                   Adresse == client.Adresse &&
                   No_telephone == client.No_telephone &&
                   Email == client.Email &&
                   Identifiant == client.Identifiant;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(nom);
            hash.Add(adresse);
            hash.Add(no_telephone);
            hash.Add(email);
            hash.Add(identifiant);
            hash.Add(Nom);
            hash.Add(Adresse);
            hash.Add(No_telephone);
            hash.Add(Email);
            hash.Add(Identifiant);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"Identifiant = {identifiant} Nom = {nom} Adresse = {adresse} Numéro de téléphone = {no_telephone} Email = {email}";
        }
    }
}
