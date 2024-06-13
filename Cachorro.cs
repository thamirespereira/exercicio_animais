using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace animais_domesticos{
    public class Cachorro : Animal{
        public string Raca {get; set;}
        public string Cor {get; set;}
        public string Porte {get; set;}
        public bool Adestrado {get; set;}

        public Cachorro(string nome, int idade, string som, string tipo, string tutor, double peso, string raca, string cor, string porte, bool adestrado) 
        : base(nome, idade, som, tipo, tutor, peso){
            Raca = raca;
            Cor = cor;
            Porte = porte;
            Adestrado = adestrado;
        }

        public override void EmitirSom(){
            System.Console.WriteLine("Au au au");
        }

        public void Passear(){
            System.Console.WriteLine("Passeando...");
        }
    }
}