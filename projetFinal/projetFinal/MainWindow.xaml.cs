using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            Admin admin = Singleton.getInstance().CheckAdmin();

            if (admin.Nom != null)
            {
                mainFrame.Navigate(typeof(Projets));
            }
            else
            {
                mainFrame.Navigate(typeof(AjoutAdmin));
                navEmployes.IsEnabled = false;
                navClients.IsEnabled = false;
                navProjets.IsEnabled = false;
                navDeconnection.IsEnabled = false;
                navConnexion.IsEnabled = false;
            }
        }


        private async void navView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var item = (NavigationViewItem)args.SelectedItem;

            switch (item.Name)
            {
                case "navEmployes":
                    mainFrame.Navigate(typeof(Employes));
                    break;
                case "navClients":
                    mainFrame.Navigate(typeof(Clients));
                    break;
                case "navProjets":
                    mainFrame.Navigate(typeof(Projets));
                    break;
                case "navConnexion":
                    mainFrame.Navigate(typeof(Connexion));
                    break;
                case "navDeconnection":
                    mainFrame.Navigate(typeof(Deconnexion));
                    break;
                case "navExporter":
                    var picker = new Windows.Storage.Pickers.FileSavePicker();

                    var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
                    WinRT.Interop.InitializeWithWindow.Initialize(picker, hWnd);

                    picker.SuggestedFileName = "Projets";
                    picker.FileTypeChoices.Add("Fichier texte", new List<string>() { ".csv" });

                    Windows.Storage.StorageFile monFichier = await picker.PickSaveFileAsync();

                    List<Projet> liste = new List<Projet>();

                    SingletonProjet singletonInstance = SingletonProjet.getInstance();

                    ObservableCollection<Projet> observableCollection = singletonInstance.GetListeProj();

                    List<Projet> projetList = observableCollection.ToList();

                    liste.AddRange(projetList);

                    if (monFichier != null)
                        await Windows.Storage.FileIO.WriteLinesAsync(monFichier, liste.ConvertAll(x => x.stringCSV()), Windows.Storage.Streams.UnicodeEncoding.Utf8);
                    break;
                default:
                    break;
            }

        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            navEmployes.IsEnabled = true; //Quand on navigue entre chaque page: réactiver les items du navigationview (utile quand l'on a fini de créer l'admin)
            navClients.IsEnabled = true;
            navProjets.IsEnabled = true;
            navDeconnection.IsEnabled = true;
            navConnexion.IsEnabled = true;

            if (Connexion.Connecter == true)
            {
                navConnexion.IsEnabled = false;
                navExporter.IsEnabled = true;
            }
            else
            {
                navConnexion.IsEnabled = true;
                navDeconnection.IsEnabled = false;
                navExporter.IsEnabled = false;
            }
        }
    }
}