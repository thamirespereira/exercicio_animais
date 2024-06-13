using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace animais_domesticos{
    public abstract class Animal
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Som {get; set;}
        public string Tipo {get; set;}
        public string Tutor {get; set;}
        public double Peso {get; set;}

        public Animal(string nome, int idade, string som, string tipo, string tutor, double peso){
        Nome = nome;
        Idade = idade;
        Som = som;
        Tipo = tipo;
        Tutor = tutor;
        Peso = peso;
        }
        
        public abstract void EmitirSom();
    }
}
