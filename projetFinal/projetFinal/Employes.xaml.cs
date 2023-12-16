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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Employes : Page
    {
        public Employes()
        {
            this.InitializeComponent();
            gridViewEmployes.ItemsSource = SingletonEmploye.getInstance().GetListeEmploye();
            if(Connexion.Connecter == false)
            {
                btnAjouterEmploye.Visibility = Visibility.Collapsed;
            }
        }
        private async void btnAjouterEmploye_Click(object sender, RoutedEventArgs e)
        {
            AjouterEmploye dialog = new AjouterEmploye();
            dialog.XamlRoot = GridEmploye.XamlRoot;
            dialog.Title = "Ajout d'un employé";
            dialog.PrimaryButtonText = "Ajouter";
            dialog.CloseButtonText = "Annuler";

            ContentDialogResult resultat = await dialog.ShowAsync();
        }
        private async void gridViewEmployes_ItemClick(object sender, ItemClickEventArgs e)
        {

            var item = e.ClickedItem;
            int position = gridViewEmployes.Items.IndexOf(item);

            if (position != -1)
            {
                // Assuming ModificationEmploye is a ContentDialog
                ModificationEmploye dialog = new ModificationEmploye(position);
                dialog.XamlRoot = gridViewEmployes.XamlRoot;
                dialog.Title = "Modification d'un employé";
                dialog.PrimaryButtonText = "Modifier";
                dialog.CloseButtonText = "Annuler";

                ContentDialogResult resultat = await dialog.ShowAsync();
            }
        }

        private void btnRefreshEmploye_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Employes));
        }


    }
}
