using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace animais_domesticos{
    public class Passaro : Animal{
        public string Especie {get; set;}

        public Passaro(string nome, int idade, string som, string tipo, string tutor, double peso, string especie)
        : base (nome, idade, som, tipo, tutor, peso){
            Especie = especie;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Piu piu");
        }

        public void Voar()
        {
            Console.WriteLine("Voando...");
        }

    }
}