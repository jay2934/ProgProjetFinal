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
    public sealed partial class AjouterProjet : ContentDialog
    {
        public AjouterProjet()
        {
            this.InitializeComponent();


        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            bool invalide = true;

            if (autoSuggBoxClient.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headClientProjet.Text = "* (Le projet doit avoir un client)";
            }
            else
            {
                var suitableItems = new List<string>();
                var clients = SingletonClient.getInstance().GetListeClient();
                foreach (var client in clients)
                {

                    var clientNom = client.Nom;

                    if (autoSuggBoxClient.Text.Equals(clientNom))
                    {
                        invalide = false;
                        break;
                    }
                }
                if(invalide)
                {
                    args.Cancel = true;
                    headClientProjet.Text = "* (Le client n'existe pas)";
                }
                else
                {
                    headClientProjet.Text = "";
                }
            }

            if (tbxTitreProjet.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headTitreProjet.Text = "* (Le titre ne doit pas être vide)";
            }
            else
            {
                headTitreProjet.Text = "";
            }

            if (tbxDateProjet.SelectedDate.ToString().Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headDateProjet.Text = "* (La date de début ne doit pas être vide)";
            }
            else
            {
                string anneeProjet = tbxDateProjet.SelectedDate.ToString().Substring(0, 4);
                string moisProjet = tbxDateProjet.SelectedDate.ToString().Substring(5, 2);
                string jourProjet = tbxDateProjet.SelectedDate.ToString().Substring(8, 2);
                int projet = int.Parse(tbxDateProjet.SelectedDate.ToString().Substring(0, 4) + tbxDateProjet.SelectedDate.ToString().Substring(5, 2) + tbxDateProjet.SelectedDate.ToString().Substring(8, 2));
                string anneeAujourdhui = DateTime.Now.ToString().Substring(0, 4);
                string moisAujourdhui = DateTime.Now.ToString().Substring(5, 2);
                string jourAujourdhui = DateTime.Now.ToString().Substring(8, 2);
                int aujourdhui = int.Parse(DateTime.Now.ToString().Substring(0, 4) + DateTime.Now.ToString().Substring(5, 2) + DateTime.Now.ToString().Substring(8, 2));
                if (projet - aujourdhui <= 0)
                {
                    invalide = true;
                    args.Cancel = true;
                    headDateProjet.Text = "* (la projet ne peut pas être dans le passé)";
                }
                else
                {
                    headDateProjet.Text = "";
                }
            }

            if (tbxDescriptionProjet.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headDescriptionProjet.Text = "* (la description ne doit pas être vide)";
            }
            else
            {
                headDescriptionProjet.Text = "";
            }

            if (nbxBudgetProjet.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headBudgetProjet.Text = "* (Le budget ne doit pas être vide)";
            }
            else
            {
                headBudgetProjet.Text = "";
            }

            if (nbxNbEmployeProjet.Text.Equals(""))
            {
                invalide = true;
                args.Cancel = true;
                headNbrEmployeProjet.Text = "* (Le nombre d'employé ne doit pas être vide)";
            }
            else
            {
                headNbrEmployeProjet.Text = "";
            }

            if (invalide == false)
            {
                string titre, date_debut, description, statut;
                decimal budget, total_salaire;
                int nb_employe, client;


                titre = tbxTitreProjet.Text;
                date_debut = tbxDateProjet.SelectedDate.ToString();
                date_debut = date_debut.Substring(0, date_debut.IndexOf(" "));
                description = tbxDescriptionProjet.Text;
                budget = (decimal)nbxBudgetProjet.Value;
                nb_employe = (int)nbxNbEmployeProjet.Value;
                client = SingletonProjet.getInstance().getNoClient(autoSuggBoxClient.Text);
                statut = "En cours";

                SingletonProjet.getInstance().AjoutProjet(titre, date_debut, description, budget, nb_employe, client, statut);
            }
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                var suitableItems = new List<string>();
                var splitText = sender.Text.ToLower().Split(" ");


                var clients = SingletonClient.getInstance().GetListeClient();

                foreach (var client in clients)
                {

                    var clientNom = client.Nom;

                    var found = splitText.All((key) =>
                    {
                        return clientNom.ToLower().Contains(key);
                    });

                    if (found)
                    {
                        suitableItems.Add(clientNom);
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
            autoSuggBoxClient.Text = args.SelectedItem.ToString();
        }

    }
}
