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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ZoomProjet : Page
    {
        ProjetClient item;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is not null)
            {
                item = (ProjetClient)e.Parameter;
                tblno_projet.Text = item.No_projet;
                tbltitre.Text = item.Titre;
                tbldate_debut.Text = item.Date_debut.Substring(0,10);
                tbldescription.Text = item.Description;
                tblbudget.Text = item.Budget.ToString();
                tblnb_employe.Text = item.Nb_employe.ToString();
                tbltotal_salaire.Text = item.Total_salaire.ToString();
                tblclient.Text = item.Nom;
                tblstatut.Text = item.Statut;
            }
        }


        private ProjetClient projetAffichable;
        public ZoomProjet()
        {
            this.InitializeComponent();


        }

        private void btnAttribueEmploye_Click(object sender, RoutedEventArgs e)
        {
            bool invalide = true;

            if (autoSuggBoxEmploye.Text.Equals(""))
            {
                invalide = true;
                headEmployeProjet.Text = "* (aucun employé saisi)";
            }
            else
            {
                var suitableItems = new List<string>();
                var employes = SingletonEmploye.getInstance().GetListeEmploye();
                foreach (var employe in employes)
                {

                    var employeNom = employe.Nom;

                    if (autoSuggBoxEmploye.Text.Equals(employeNom))
                    {
                        invalide = false;
                        break;
                    }
                }
                if (invalide)
                {
                    headEmployeProjet.Text = "* (L'employé n'existe pas)";
                }
                else
                {
                    headEmployeProjet.Text = "";
                }
            }

            if (invalide == false)
            {
                string matricule, no_projet;
                int nb_heure_travaille;
                decimal salaire;

                matricule = SingletonTravaille.getInstance().getNoEmploye(autoSuggBoxEmploye.Text);
                no_projet = tblno_projet.Text;

                //SingletonTravaille.getInstance().AjoutTravaille(matricule, no_projet, nb_heure_travaille, salaire);
            }
        }
        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                var suitableItems = new List<string>();
                var splitText = sender.Text.ToLower().Split(" ");


                var employes = SingletonEmploye.getInstance().GetListeEmploye();

                foreach (var employe in employes)
                {

                    var employeNom = employe.Nom;

                    var found = splitText.All((key) =>
                    {
                        return employeNom.ToLower().Contains(key);
                    });

                    if (found)
                    {
                        suitableItems.Add(employeNom);
                    }
                }

                if (suitableItems.Count == 0)
                {
                    suitableItems.Add("No results found");
                }

                sender.ItemsSource = suitableItems;

            }
        }

        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            //SuggestionOutput.Text = args.SelectedItem.ToString();
            autoSuggBoxEmploye.Text = args.SelectedItem.ToString();
        }
    }
}