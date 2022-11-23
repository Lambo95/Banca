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
            if(prelievo > Saldo)
            {
                Console.WriteLine($"Non hai soldi sufficienti! Il tuo saldo è di {Saldo}");
            }
            else {
                Saldo -= prelievo;
            }
            return Saldo;
        }

        public double Versamento(double versamento)
        {
            return Saldo += versamento;
        }
    }
}
