using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Google.Protobuf.WellKnownTypes;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace projetFinal
{
    public sealed partial class AjouterEmploye : ContentDialog
    {
        public AjouterEmploye()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            bool invalide = false;

            if (tbxNomEmploye.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headNomEmploye.Text = "* (Le nom ne doit pas être vide)";
            }
            else
            {
                headNomEmploye.Text = "";
            }

            if (tbxPrenomEmploye.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headPrenomEmploye.Text = "* (Le prénom ne doit pas être vide)";
            }
            else
            {
                headPrenomEmploye.Text = "";
            }

            if (tbxDateNaissanceEmploye.SelectedDate.ToString().Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headDateNaissanceEmploye.Text = "* (La date de naissance ne doit pas être vide)";
            }
            else
            {
                string anneeNaissance = tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(0, 4);
                string moisNaissance = tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(5, 2);
                string jourNaissance = tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(8, 2);
                int naissance = int.Parse(tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(0, 4) + tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(5, 2) + tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(8, 2));
                string anneeAujourdhui = DateTime.Now.ToString().Substring(0, 4);
                string moisAujourdhui = DateTime.Now.ToString().Substring(5, 2);
                string jourAujourdhui = DateTime.Now.ToString().Substring(8, 2);
                int aujourdhui = int.Parse(DateTime.Now.ToString().Substring(0, 4) + DateTime.Now.ToString().Substring(5, 2) + DateTime.Now.ToString().Substring(8, 2));
                if (aujourdhui - naissance < 0)
                {
                    invalide = true;
                    args.Cancel = true;
                    headDateNaissanceEmploye.Text = "* (L'employé n'est pas née)";
                }
                else if (naissance > int.Parse((int.Parse(anneeAujourdhui) - 18) + moisAujourdhui + jourAujourdhui))
                {
                    invalide = true;
                    args.Cancel = true;
                    headDateNaissanceEmploye.Text = "* (L'employé n'est pas majeur)";
                }
                else
                {
                    headDateNaissanceEmploye.Text = "";
                }
            }

            if (tbxEmailEmploye.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headEmailEmploye.Text = "* (L'adresse mail ne doit pas être vide)";
            }
            else if (!tbxEmailEmploye.Text.Contains("@"))
            {
                invalide = true;
                args.Cancel = true;
                headEmailEmploye.Text = "* (L'adresse mail doit avoir un '@')";
            }
            else if (!tbxEmailEmploye.Text.Substring(tbxEmailEmploye.Text.IndexOf("@")).Contains("."))
            {
                invalide = true;
                args.Cancel = true;
                headEmailEmploye.Text = "* (L'adresse mail doit avoir un domaine)";
            }
            else
            {
                headEmailEmploye.Text = "";
            }

            if (tbxAdresseEmploye.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headAdresseEmploye.Text = "* (L'adresse ne doit pas être vide)";
            }
            else
            {
                headAdresseEmploye.Text = "";
            }

            if (tbxDateEmbaucheEmploye.SelectedDate.ToString().Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headerDateEmbaucheEmploye.Text = "* (La date d'embauche ne doit pas être vide)";
            }
            else if (tbxDateEmbaucheEmploye.SelectedDate > DateTime.Now)
            {
                invalide = true;
                args.Cancel = true;
                headerDateEmbaucheEmploye.Text = "* (La date d'embauche doit être avant aujourd'hui)";
            }
            else if (tbxDateNaissanceEmploye.SelectedDate.ToString().Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headerDateEmbaucheEmploye.Text = "";
            }
            else
            {
                string anneeNaissance = tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(0, 4);
                string moisNaissance = tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(5, 2);
                string jourNaissance = tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(8, 2);
                int naissance = int.Parse(tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(0, 4) + tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(5, 2) + tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(8, 2));

                string anneeEmbauche = tbxDateEmbaucheEmploye.SelectedDate.ToString().Substring(0, 4);
                string moisEmbauche = tbxDateEmbaucheEmploye.SelectedDate.ToString().Substring(5, 2);
                string jourEmbauche = tbxDateEmbaucheEmploye.SelectedDate.ToString().Substring(8, 2);
                int Embauche = int.Parse(tbxDateEmbaucheEmploye.SelectedDate.ToString().Substring(0, 4) + tbxDateEmbaucheEmploye.SelectedDate.ToString().Substring(5, 2) + tbxDateEmbaucheEmploye.SelectedDate.ToString().Substring(8, 2));

                if (naissance <= int.Parse((int.Parse(anneeEmbauche) - 65) + moisEmbauche + jourEmbauche))
                {
                    invalide = true;
                    args.Cancel = true;
                    headerDateEmbaucheEmploye.Text = "* (L'employé a l'âge de la retraite)";
                }
                else if (Embauche - naissance < 0)
                {
                    invalide = true;
                    args.Cancel = true;
                    headerDateEmbaucheEmploye.Text = "* (L'employé ne peut pas être embauché avant la naissance)";
                }
                else if (naissance > int.Parse((int.Parse(anneeEmbauche) - 18) + moisEmbauche + jourEmbauche))
                {
                    invalide = true;
                    args.Cancel = true;
                    headerDateEmbaucheEmploye.Text = "* (L'employé n'est pas majeur)";
                }
                else
                {
                    headerDateEmbaucheEmploye.Text = "";
                }
            }

            if (tbxTauxHoraireEmploye.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headTauxHoraireEmploye.Text = "* (Le taux horaire ne doit pas être vide)";
            }
            else
            {
                headTauxHoraireEmploye.Text = "";
            }

            if (tbxPhotoEmploye.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headPhotoEmploye.Text = "* (La photo ne doit pas être vide)";
            }
            else
            {
                headPhotoEmploye.Text = "";
            }

            if (invalide == false)
            {
                string nom, prenom, date_naissance, email, adresse, date_embauche, photo, statut;
                decimal taux_horaire;

                nom = tbxNomEmploye.Text;
                prenom = tbxPrenomEmploye.Text;
                date_naissance = tbxDateNaissanceEmploye.SelectedDate.ToString();
                date_naissance = date_naissance.Substring(0, date_naissance.IndexOf(" "));
                email = tbxEmailEmploye.Text;
                adresse = tbxAdresseEmploye.Text;
                date_embauche = tbxDateEmbaucheEmploye.SelectedDate.ToString();
                date_embauche = date_embauche.Substring(0, date_embauche.IndexOf(" "));
                taux_horaire = (decimal)tbxTauxHoraireEmploye.Value;
                photo = tbxPhotoEmploye.Text;
                statut = "Journalier";

                SingletonEmploye.getInstance().AjoutEmploye(nom, prenom, date_naissance, email, adresse, date_embauche, taux_horaire, photo, statut);
                args.Cancel = false;
            }
        }
    }
}