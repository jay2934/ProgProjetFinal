using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetFinal
{
    internal class SingletonFenetre
    {
        static SingletonFenetre instance = null;
        Window fenetre;

        public SingletonFenetre() { }
        public Window Fenetre { get => fenetre; set => fenetre = value; }
        public static SingletonFenetre getInstance()
        {
            if (instance == null)
                instance = new SingletonFenetre();
            return instance;
        }
    }
}
