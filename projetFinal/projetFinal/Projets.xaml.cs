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
        private async void btnExporterProjet_Click(object sender, RoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileSavePicker();

            var hWnd = IntPtr.Zero;
            if(SingletonFenetre.getInstance().Fenetre != null)
            {
                hWnd = WinRT.Interop.WindowNative.GetWindowHandle(SingletonFenetre.getInstance().Fenetre);
                WinRT.Interop.InitializeWithWindow.Initialize(picker, hWnd);
            }

            picker.SuggestedFileName = "Projet";
            picker.FileTypeChoices.Add("Fichier texte", new List<string>() { ".csv" });

            //crée le fichier
            Windows.Storage.StorageFile monFichier = await picker.PickSaveFileAsync();

            List<Client> liste = new List<Client>();
            liste.Add(new Client { Nom = "Laroche"});
            liste.Add(new Client { Nom = "Demers"});
            liste.Add(new Client { Nom = "Lavoie"});

            // La fonction ToString de la classe Client retourne: nom + ";" + prenom

            await Windows.Storage.FileIO.WriteLinesAsync(monFichier, liste.ConvertAll(x => x.ToString()), Windows.Storage.Streams.UnicodeEncoding.Utf8);

        }
    }
}