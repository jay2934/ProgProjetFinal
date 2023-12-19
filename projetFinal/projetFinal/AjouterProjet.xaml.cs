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
            string titre, date_debut, description, statut;
            decimal budget, total_salaire;
            int nb_employe, client;


            titre = tbxTitreProjet.Text;
            date_debut = tbxDateProjet.SelectedDate.ToString();
            date_debut = date_debut.Substring(0, date_debut.IndexOf(" "));
            description = tbxDescriptionProjet.Text;
            budget = (decimal) nbxBudgetProjet.Value;
            nb_employe = (int) nbxNbEmployeProjet.Value;
            client = SingletonProjet.getInstance().getNoClient(autoSuggBoxClient.Text);
            statut = "En cours";

            SingletonProjet.getInstance().AjoutProjet(titre, date_debut, description, budget, nb_employe, client, statut);

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
