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
    public sealed partial class Projets : Page
    {
        public Projets()
        {
            this.InitializeComponent();
            gridViewProjets.ItemsSource = SingletonProjet.getInstance().GetListeProjet();
            if(Connexion.Connecter == false)
            {
                btnAjouterProjet.Visibility = Visibility.Collapsed;
            }
        }



        private async void btnAjouterProjet_Click(object sender, RoutedEventArgs e)
        {
            AjouterProjet dialog = new AjouterProjet();
            dialog.XamlRoot = GridProjet.XamlRoot;
            dialog.Title = "Ajout d'un projet";
            dialog.PrimaryButtonText = "Ajouter";
            dialog.CloseButtonText = "Annuler";

            ContentDialogResult resultat = await dialog.ShowAsync();
        }

        private void btnRefreshProjet_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Projets));
        }

        private void gridViewProjets_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem;
            //int position = gridViewProjets.Items.IndexOf(e);

            this.Frame.Navigate(typeof(ZoomProjet), item);
        }
 
    }
}