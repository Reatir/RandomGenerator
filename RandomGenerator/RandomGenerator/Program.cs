using RandomGenerator.Models;
using RandomGenerator.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialisation des differente partie du MVP

            Model model = new Model();

            RandomGeneratorView view = new RandomGeneratorView();

            Presenter presenter = new Presenter(model,view);

            Application.Run(view);
        }
    }
}
