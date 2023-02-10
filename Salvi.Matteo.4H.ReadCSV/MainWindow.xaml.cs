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

        private void PulsanteApri(object sender, RoutedEventArgs e)
        {
            try
            {
                dgDati.ItemsSource = new Utenti("utenti.csv");
            }
            catch (Exception errore)
            {
                MessageBox.Show(errore.Message);
            }
        }
        private void dgDati_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            try
            {
                if (e != null && e.Row != null)
                {
                    Utente u = e.Row.Item as Utente;
                    if (u != null)
                    {
                        if(u.Tipo=="Studente")
                        {
                            e.Row.Background = Brushes.DarkKhaki;
                            e.Row.Foreground = Brushes.DarkViolet;
                        }
                        else if(u.Tipo=="Professore")
                        {
                            e.Row.Foreground= Brushes.Yellow;
                        }
                    }
                }
            }
            catch (Exception errore)
            {
                MessageBox.Show(errore.Message);
            }
        }
    }
}
