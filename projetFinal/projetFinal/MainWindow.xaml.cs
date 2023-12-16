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



        private void navView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
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
                default:
                    break;
            }

        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            navEmployes.IsEnabled = true;
            navClients.IsEnabled = true;
            navProjets.IsEnabled = true;
            navDeconnection.IsEnabled = true;
            navConnexion.IsEnabled = true;
        }
    }
}
