// See https://aka.ms/new-console-template for more information
using animais_domesticos;
using System;
using System.Reflection;

Cachorro cachorro = new Cachorro("Apolo", 8, "Au au au", "Mamífero", "Thamires", 15d, "Raça não definida", "Caramelo", "Médio", false);
Gato gato = new Gato("Violeta", 1, "Miau miau", "Mamífero", "Thamires", 1d, "Raça não definida", "Siamês");
Passaro passaro = new Passaro("Kyara", 10, "Piu piu", "Ave", "Thamires", 0.5d, "Periquito");

Console.WriteLine("Cachorro\n");
Console.WriteLine("Nome: " + cachorro.Nome + "\nIdade: " + cachorro.Idade + "\nTipo: " + cachorro.Tipo + "\nPeso: " + cachorro.Peso + "\nRaca: " + cachorro.Raca + "\nCor: " + cachorro.Cor + "\nPorte: " + cachorro.Porte + "\nAdestrado: " + cachorro.Adestrado + "\nTutor: " + cachorro.Tutor);
cachorro.EmitirSom();
cachorro.Passear();
Console.WriteLine("\n-----------------------------------------------\n");
Console.WriteLine("Gato\n");
Console.WriteLine("Nome: " + gato.Nome + "\nIdade: " + gato.Idade + "\nTipo: " + gato.Tipo + "\nPeso: " + gato.Peso + "\nRaca: " + gato.Raca + "\nCor: " + gato.Cor + "\nTutor: " + gato.Tutor);
gato.EmitirSom();
gato.Arranhar();
gato.SubirNaArvore();
Console.WriteLine("\n-----------------------------------------------\n");
Console.WriteLine("Pássaro\n");
Console.WriteLine("Nome: " + passaro.Nome + "\nIdade: " + passaro.Idade + "\nTipo: " + passaro.Tipo + "\nPeso: " + passaro.Peso + "\nEspecie: " + passaro.Especie + "\nTutor: " + passaro.Tutor);
passaro.EmitirSom();
passaro.Voar();


