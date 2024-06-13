using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace animais_domesticos{
    public class Gato : Animal{
        public string Raca {get; set;}
        public string Cor {get; set;}

        public Gato(string nome, int idade, string som, string tipo, string tutor, double peso, string raca, string cor)
        : base (nome, idade, som, tipo, tutor, peso){
            Raca = raca;
            Cor = cor;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Miau miau");
        }

        public void Arranhar()
        {
            Console.WriteLine("Arranhando...");
    }

    public void SubirNaArvore()
    {
        Console.WriteLine("Subindo na árvore...");
    }
}
}
