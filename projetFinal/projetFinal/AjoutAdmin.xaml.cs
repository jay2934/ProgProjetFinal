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
            bool invalide = false;

            if (txtBoxNomAdmin.Text.Equals(""))
            {
                invalide = true;
                headNomAdmin.Text = "* (Le nom ne doit pas être vide)";
            }
            else
            {
                headNomAdmin.Text = "";
            }

            if (txtBoxMotDePasseAdmin.Text.Equals(""))
            {
                invalide = true;
                headMotDePasseAdmin.Text = "* (Le mot de passe ne doit pas être vide)";
            }
            else if (txtBoxMotDePasseAdmin.Text.Equals(txtBoxNomAdmin.Text))
            {
                invalide = true;
                headMotDePasseAdmin.Text = "* (Le mot de passe ne peut pas être votre nom)";
            }
            else if (txtBoxMotDePasseAdmin.Text.Length < 8 || txtBoxMotDePasseAdmin.Text.Length > 25)
            {
                invalide = true;
                headMotDePasseAdmin.Text = "* (Le mot de passe doit contenir entre 8 et 25 charactères)";
            }
            else if (!txtBoxMotDePasseAdmin.Text.Contains('0') && !txtBoxMotDePasseAdmin.Text.Contains('1') && !txtBoxMotDePasseAdmin.Text.Contains('2') && !txtBoxMotDePasseAdmin.Text.Contains('3') && !txtBoxMotDePasseAdmin.Text.Contains('4') && !txtBoxMotDePasseAdmin.Text.Contains('5') && !txtBoxMotDePasseAdmin.Text.Contains('6') && !txtBoxMotDePasseAdmin.Text.Contains('7') && !txtBoxMotDePasseAdmin.Text.Contains('8') && !txtBoxMotDePasseAdmin.Text.Contains('9'))
            {
                invalide = true;
                headMotDePasseAdmin.Text = "* (Le mot de passe doit contenir au moins un chiffre)";
            }
            else
            {
                headMotDePasseAdmin.Text = "";
            }

            if (invalide == false)
            {
                Singleton.getInstance().AjoutAdmin(txtBoxNomAdmin.Text, txtBoxMotDePasseAdmin.Text);
                Connexion.Connecter = true;
                this.Frame.Navigate(typeof(Projets));
            }
        }
    }
}