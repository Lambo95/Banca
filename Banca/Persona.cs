using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    internal class Persona
    {
        public string Nome { get; set; }
        private string Cognome { get; set; }

        public Persona(string nome, string cognome) { 
            Nome= nome;
            Cognome= cognome;
        }

        public override string ToString()
        {
            return $"Benvenuto al tuo conto Sig. {Nome} {Cognome}! \n Che operazione desidera effettuare?";
        }

    }
}
