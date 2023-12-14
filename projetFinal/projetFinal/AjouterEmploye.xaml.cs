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

            if (tbxDateNaissanceEmploye.SelectedDate.ToString() == "")
            {
                invalide = true;
                args.Cancel = true;
                headDateNaissanceEmploye.Text = "* (La date ne doit pas être vide)";
            }
                //tbxDateNaissanceEmploye.SelectedDate.ToString().Substring(0, tbxDateNaissanceEmploye.SelectedDate.ToString().IndexOf(" "))
            else
            {
                headDateNaissanceEmploye.Text = "";
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
