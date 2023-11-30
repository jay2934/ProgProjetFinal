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
        public Client() {
            nom = "Client";
            adresse = "123 Rue principal";
            no_telephone = "123-456-7890";
            email = "client@gmail.com";
        }

        public Client (string nom, string adresse, string no_telephone, string email)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.no_telephone = no_telephone;
            this.email = email;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string No_telephone { get => no_telephone; set => no_telephone = value; }
        public string Email { get => email; set => email = value; }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   nom == client.nom &&
                   adresse == client.adresse &&
                   no_telephone == client.no_telephone &&
                   email == client.email &&
                   Nom == client.Nom &&
                   Adresse == client.Adresse &&
                   No_telephone == client.No_telephone &&
                   Email == client.Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nom, adresse, no_telephone, email, Nom, Adresse, No_telephone, Email);
        }

        public override string ToString()
        {
            return $"Nom = {nom} Adresse = {adresse} Numéro de téléphone = {no_telephone} Email = {email}";
        }
    }
}
