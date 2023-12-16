using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    internal class Admin
    {
        int id;
        string nom, mot_de_passe;
        public Admin()
        { 
            id = 0;
            nom = "Admin";
            mot_de_passe = "qwerty";
        }

        public Admin(int id, string nom, string mot_de_passe)
        {
            this.id = id;
            this.nom = nom;
            this.mot_de_passe = mot_de_passe;
        }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Mot_de_passe { get => mot_de_passe; set => mot_de_passe = value; }

        public override bool Equals(object obj)
        {
            return obj is Admin admin &&
                   id == admin.id &&
                   nom == admin.nom &&
                   mot_de_passe == admin.mot_de_passe &&
                   Id == admin.Id &&
                   Nom == admin.Nom &&
                   Mot_de_passe == admin.Mot_de_passe;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, nom, mot_de_passe, Id, Nom, Mot_de_passe);
        }

        public override string ToString()
        {
            return $"Id = {id} Nom = {nom} Mot de passe = {mot_de_passe}";
        }
    }
}
