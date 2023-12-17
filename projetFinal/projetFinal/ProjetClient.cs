using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    internal class ProjetClient
    {
        string no_projet, titre, date_debut, description, statut;
        decimal budget, total_salaire;
        int nb_employe, client;

        string nom, adresse, no_telephone, email;
        int identifiant;

        public ProjetClient()
        {
            no_projet = "000-00-0000";
            titre = "Le projet";
            date_debut = "2020-01-01";
            description = "Un tout nouveaux projet";
            budget = 300;
            nb_employe = 0;
            total_salaire = 0;
            client = 0;
            statut = "En cours";

            identifiant = 000;
            nom = "Client";
            adresse = "123 Rue principal";
            no_telephone = "123-456-7890";
            email = "client@gmail.com";
        }
        
        public ProjetClient(string no_projet, string titre, string date_debut, string description, decimal budget, int nb_employe, decimal total_salaire, int client, string statut, int identifiant, string nom, string adresse, string no_telephone, string email)
        {
            this.no_projet = no_projet;
            this.titre = titre;
            this.date_debut = date_debut;
            this.description = description;
            this.budget = budget;
            this.nb_employe = nb_employe;
            this.total_salaire = total_salaire;
            this.client = client;
            this.statut = statut;
            this.identifiant = identifiant;
            this.nom = nom;
            this.adresse = adresse;
            this.no_telephone = no_telephone;
            this.email = email;

        }

        public string No_projet { get => no_projet; set => no_projet = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Date_debut { get => date_debut; set => date_debut = value; }
        public string Description { get => description; set => description = value; }
        public string Statut { get => statut; set => statut = value; }
        public decimal Budget { get => budget; set => budget = value; }
        public decimal Total_salaire { get => total_salaire; set => total_salaire = value; }
        public int Nb_employe { get => nb_employe; set => nb_employe = value; }
        public int Client { get => client; set => client = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string No_telephone { get => no_telephone; set => no_telephone = value; }
        public string Email { get => email; set => email = value; }
        public int Identifiant { get => identifiant; set => identifiant = value; }

        public override bool Equals(object obj)
        {
            return obj is ProjetClient client &&
                   no_projet == client.no_projet &&
                   titre == client.titre &&
                   date_debut == client.date_debut &&
                   description == client.description &&
                   statut == client.statut &&
                   budget == client.budget &&
                   total_salaire == client.total_salaire &&
                   nb_employe == client.nb_employe &&
                   this.client == client.client &&
                   nom == client.nom &&
                   adresse == client.adresse &&
                   no_telephone == client.no_telephone &&
                   email == client.email &&
                   identifiant == client.identifiant &&
                   No_projet == client.No_projet &&
                   Titre == client.Titre &&
                   Date_debut == client.Date_debut &&
                   Description == client.Description &&
                   Statut == client.Statut &&
                   Budget == client.Budget &&
                   Total_salaire == client.Total_salaire &&
                   Nb_employe == client.Nb_employe &&
                   Client == client.Client &&
                   Nom == client.Nom &&
                   Adresse == client.Adresse &&
                   No_telephone == client.No_telephone &&
                   Email == client.Email &&
                   Identifiant == client.Identifiant;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(no_projet);
            hash.Add(titre);
            hash.Add(date_debut);
            hash.Add(description);
            hash.Add(statut);
            hash.Add(budget);
            hash.Add(total_salaire);
            hash.Add(nb_employe);
            hash.Add(client);
            hash.Add(nom);
            hash.Add(adresse);
            hash.Add(no_telephone);
            hash.Add(email);
            hash.Add(identifiant);
            hash.Add(No_projet);
            hash.Add(Titre);
            hash.Add(Date_debut);
            hash.Add(Description);
            hash.Add(Statut);
            hash.Add(Budget);
            hash.Add(Total_salaire);
            hash.Add(Nb_employe);
            hash.Add(Client);
            hash.Add(Nom);
            hash.Add(Adresse);
            hash.Add(No_telephone);
            hash.Add(Email);
            hash.Add(Identifiant);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"No_projet = {no_projet} Titre = {titre} Date de début = {date_debut} Description = {description} " +
                $"Budget = {budget} Nombre d'employés {nb_employe} Total des salaires = {total_salaire} Client = {client} " +
                $"Statut = {statut} Identifiant = {identifiant} Nom = {nom} Adresse = {adresse} Numéro de téléphone = {no_telephone} Email = {email}";
        }
    }
}
