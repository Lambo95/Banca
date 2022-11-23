using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    internal class Conto : Persona
    {
        public double Saldo { get; set; }

        public Conto(string nome, string cognome, double saldo) : base(nome, cognome)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return $"Il tuo saldo è di {Saldo}";
        }

        public double Prelievo(double prelievo)
        {
            return Saldo -= prelievo;
        }

        public double Versamento(double versamento)
        {
            return Saldo += versamento;
        }
    }
}
