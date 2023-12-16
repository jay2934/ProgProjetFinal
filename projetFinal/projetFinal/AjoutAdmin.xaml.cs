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
    public sealed partial class AjoutAdmin : Page
    {
        public AjoutAdmin()
        {
            this.InitializeComponent();
        }

        private void btnAjouterAdmin_Click(object sender, RoutedEventArgs e)
        {
            Singleton.getInstance().AjoutAdmin(txtBoxNomAdmin.Text, txtBoxMotDePasseAdmin.Text);
            Connexion.Connecter = true;
            this.Frame.Navigate(typeof(Projets));
        }
    }
}