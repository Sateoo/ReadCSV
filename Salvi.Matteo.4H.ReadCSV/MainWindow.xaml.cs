using Salvi.Matteo._4H.ReadCSV.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Salvi.Matteo._4H.ReadCSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            List<Utente> valori = new List<Utente>();
            /*try
            {
                StreamReader fin = new StreamReader("utenti.csv");
                while(!fin.EndOfStream)
                {
                    string str = fin.ReadLine();
                    if (i != 0)
                    {
                        string[] colonne = str.Split(";");
                        Utente u = new Utente { Nome = colonne[0], Cognome = colonne[1], Email = colonne[2] };
                        valori.Add(u);
                    }
                    i++;

                } 
            }
            catch (Exception errore)
            {
                MessageBox.Show(errore.Message);
            }*/
            for (StreamReader fin = new StreamReader("utenti.csv"); !fin.EndOfStream ;)
            {
                string str = fin.ReadLine();
                if (i != 0)
                {
                    string[] colonne = str.Split(";");
                    Utente u = new Utente { Nome = colonne[0], Cognome = colonne[1], Email = colonne[2] };
                    valori.Add(u);
                }
                i++;
            }
            dgDati.ItemsSource= valori ;

        }
    }
}
