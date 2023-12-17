using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace projetFinal
{
    public sealed partial class ModificationEmploye : ContentDialog
    {
        private Employe employeModifiable;
        private string statutEmploye;
        bool checkBtnPermanent = false;
        public ModificationEmploye(int position)
        {
            this.InitializeComponent();

            employeModifiable = SingletonEmploye.getInstance().getEmploye(position); //Prendre l'employ� dans la liste qu'on veux modifier

            txtBoxNomEmploye.Text = employeModifiable.Nom; //Remplir les textBox avec les valeurs de cet employ�
            txtBoxPrenomEmploye.Text= employeModifiable.Prenom;
            txtBoxEmailEmploye.Text = employeModifiable.Email;
            txtBoxAdresseEmploye.Text = employeModifiable.Adresse;
            txtBoxPhotoEmploye.Text = employeModifiable.Photo;
            nbBoxTauxHoraireEmploye.Value = (double) employeModifiable.Taux_horaire;

            int troisans = 1095; // 3 ans en jours
            DateTime aujourdhuiDate = DateTime.Now;
            DateTime employeDateEmbauche = DateTime.ParseExact(employeModifiable.Date_embauche, "yyyy-MM-dd", null);

            int differenceJour = (int)(aujourdhuiDate - employeDateEmbauche).TotalDays;

            if(differenceJour < 1095)
            {
                btnPermanent.Visibility= Visibility.Collapsed;
            }

            if(employeModifiable.Statut.Equals("Permanent"))
            {
                btnPermanent.IsEnabled= false;
            }
        }
        
        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            decimal tauxhoraire = (decimal)nbBoxTauxHoraireEmploye.Value;


            Employe employeModifier = new Employe( //Cr�er un nouvel employ� avec les donn�es entr�es
                employeModifiable.Matriulce,
                txtBoxNomEmploye.Text,
                txtBoxPrenomEmploye.Text,
                employeModifiable.Date_naissance,
                txtBoxEmailEmploye.Text,
                txtBoxAdresseEmploye.Text,
                employeModifiable.Date_embauche,
                txtBoxPhotoEmploye.Text,
                statutEmploye,
                tauxhoraire
            );

            SingletonEmploye.getInstance().ModifierEmploye( //Modifier l'employ� avec ce nouvel employ�
                employeModifier.Matriulce,
                employeModifier.Nom,
                employeModifier.Prenom,
                employeModifier.Email,
                employeModifier.Adresse,
                employeModifier.Taux_horaire,
                employeModifier.Photo
            );
            if(checkBtnPermanent == true ) 
            {
                SingletonEmploye.getInstance().ModifierStatutEmploye(employeModifier.Matriulce, statutEmploye);
            }
        }

        private void btnPermanent_Click(object sender, RoutedEventArgs e)
        {
            btnPermanent.IsEnabled = false;
            statutEmploye = "Permanent";
            checkBtnPermanent = true;
        }
    }
}
