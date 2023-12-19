using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    class Travaille
    {
        string matricule, no_projet;
        decimal salaire;
        int id, nb_heure_travaille;

        public Travaille()
        {
            id = 0;
            matricule = "AA-0000-00";
            no_projet = "000-00-0000";
            nb_heure_travaille = 0;
            salaire = 0;
        }

        public Travaille(int id, string matricule, string no_projet, int nb_heure_travaille, decimal salaire)
        {
            this.id = id;
            this.matricule = matricule;
            this.no_projet = no_projet;
            this.nb_heure_travaille = nb_heure_travaille;
            this.salaire = salaire;
        }

        public int Id { get => id; set => id = value; }
        public string Matricule { get => matricule; set => matricule = value; }
        public string No_projet { get => no_projet; set => no_projet = value; }
        public int Nb_heure_travaille { get => nb_heure_travaille; set => nb_heure_travaille = value; }
        public decimal Salaire { get => salaire; set => salaire = value; }

        public override bool Equals(object obj)
        {
            return obj is Travaille travaille &&
                   id == travaille.id &&
                   matricule == travaille.matricule &&
                   no_projet == travaille.no_projet &&
                   nb_heure_travaille == travaille.nb_heure_travaille &&
                   salaire == travaille.salaire &&
                   Id == travaille.Id &&
                   Matricule == travaille.Matricule &&
                   No_projet == travaille.No_projet &&
                   Nb_heure_travaille == travaille.Nb_heure_travaille &&
                   Salaire == travaille.Salaire;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(id);
            hash.Add(matricule);
            hash.Add(no_projet);
            hash.Add(nb_heure_travaille);
            hash.Add(salaire);
            hash.Add(Id);
            hash.Add(Matricule);
            hash.Add(No_projet);
            hash.Add(Nb_heure_travaille);
            hash.Add(Salaire);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"Id = {id} Matricule = {matricule} No_projet = {no_projet} Nb_heure_travaille = {nb_heure_travaille} Salaire = {salaire}";
        }
    }
}
