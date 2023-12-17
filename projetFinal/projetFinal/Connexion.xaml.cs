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
using System.Security.Cryptography;
using System.Text;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace projetFinal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Connexion : Page
    {
        private static bool connecter;
        public Connexion()
        {
            this.InitializeComponent();
        }

        public static bool Connecter { get => connecter; set => connecter = value; }

        public string GetSha1(string text)
        {
            if (text == null)
            {
                return string.Empty;
            }

            byte[] message = System.Text.Encoding.ASCII.GetBytes(text);
            byte[] hashValue = GetSha1(message);

            string hashString = string.Empty;
            foreach (byte x in hashValue)
            {
                hashString += string.Format("{0:x2}", x);
            }

            return hashString;

        }

        private byte[] GetSha1(byte[] message)
        {
            SHA1Managed hashString = new SHA1Managed();
            return hashString.ComputeHash(message);
        }

        private void btnConnexion_Click(object sender, RoutedEventArgs e)
        {
            string nom = txtBoxNomAdmin.Text;
            string mdp = txtBoxMotDePasseAdmin.Text;
            
            if(Singleton.getInstance().CheckAdmin().Nom == nom && Singleton.getInstance().CheckAdmin().Mot_de_passe == GetSha1(mdp))
            {
                
                Connexion.connecter = true;
                this.Frame.Navigate(typeof(Projets));
            }
            else
            {
                headConAdmin.Text = "* (Le Nom ou le Mot de passe est invalide)";
            }
        }
    }
}
