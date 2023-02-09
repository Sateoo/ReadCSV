using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvi.Matteo._4H.ReadCSV.Models
{
    public class Utente
    {
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public string Email { get; set; }
            public string Tipo { get; set; }

        public Utente(string str,StreamReader fin)
        {
            str = fin.ReadLine();
            string[] colonne = str.Split(";");
            Nome = colonne[0];
            Cognome = colonne[1];
            Email = colonne[2];
            Tipo = colonne[3];
        }
    }
    
}
