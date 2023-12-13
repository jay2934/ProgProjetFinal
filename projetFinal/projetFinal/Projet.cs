using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    class Projet
    {
        string titre, date_debut, description, statut;
        decimal budget, total_salaire;
        int nb_employe, client;

        public Projet() {
            titre = "Le projet";
            date_debut = "2020-01-01";
            description = "Un tout nouveaux projet";
            budget = 300;
            nb_employe = 0;
            total_salaire = 0;
            client = 0;
            statut = "En cours";
        }

        public Projet(string titre, string date_debut, string description, decimal budget, int nb_employe, decimal total_salaire, int client, string statut)
        {
            this.titre = titre;
            this.date_debut = date_debut;
            this.description = description;
            this.budget = budget;
            this.nb_employe = nb_employe;
            this.total_salaire = total_salaire;
            this.client = client;
            this.statut = statut;
        }

        public string Titre { get => titre; set => titre = value; }
        public string Date_debut { get => date_debut; set => date_debut = value; }
        public string Description { get => description; set => description = value; }
        public decimal Budget { get => budget; set => budget = value; }
        public int Nb_employe { get => nb_employe; set => nb_employe = value; }
        public decimal Total_salaire { get => total_salaire; set => total_salaire = value; }
        public int Client { get => client; set => client = value; }
        public string Statut { get => statut; set => statut = value; }

        public override bool Equals(object obj)
        {
            return obj is Projet projet &&
                   titre == projet.titre &&
                   date_debut == projet.date_debut &&
                   description == projet.description &&
                   budget == projet.budget &&
                   nb_employe == projet.nb_employe &&
                   total_salaire == projet.total_salaire &&
                   client == projet.client &&
                   statut == projet.statut &&
                   Titre == projet.Titre &&
                   Date_debut == projet.Date_debut &&
                   Description == projet.Description &&
                   Statut == projet.Statut &&
                   Budget == projet.Budget &&
                   Total_salaire == projet.Total_salaire &&
                   Nb_employe == projet.Nb_employe &&
                   Client == projet.Client;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(titre);
            hash.Add(date_debut);
            hash.Add(description);
            hash.Add(budget);
            hash.Add(nb_employe);
            hash.Add(total_salaire);
            hash.Add(client);
            hash.Add(statut);
            hash.Add(Titre);
            hash.Add(Date_debut);
            hash.Add(Description);
            hash.Add(Budget);
            hash.Add(Nb_employe);
            hash.Add(Total_salaire);
            hash.Add(Client);
            hash.Add(Statut);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"Titre = {titre} Date de début = {date_debut} Description = {description} Budget = {budget} Nombre d'employés {nb_employe} Total des salaires = {total_salaire} Client = {client} Statut = {statut}";
        }
    }
}
