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
            string  nom, prenom, date_naissance, email, adresse, date_embauche, photo, statut;
            decimal taux_horaire;

            nom = txtBoxNomEmploye.Text;
            prenom = txtBoxPrenomEmploye.Text;
            date_naissance = datePickerDateNaissanceEmploye.SelectedDate.ToString();
            date_naissance = date_naissance.Substring(0, date_naissance.IndexOf(" "));
            email = txtBoxEmailEmploye.Text;
            adresse = txtBoxAdresseEmploye.Text;
            date_embauche = datePickerDateEmbaucheEmploye.SelectedDate.ToString();
            date_embauche = date_embauche.Substring(0, date_embauche.IndexOf(" "));
            taux_horaire = (decimal) nbBoxTauxHoraireEmploye.Value;
            photo = txtBoxPhotoEmploye.Text;
            statut = "Journalier";

            SingletonEmploye.getInstance().AjoutEmploye(nom, prenom, date_naissance, email, adresse, date_embauche, taux_horaire, photo, statut);
        }
    }
}
