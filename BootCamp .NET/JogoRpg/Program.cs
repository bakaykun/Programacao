using System;
using static System.Console;
using JogoRpg.src.Entities;

namespace JogoRpg{
    class Program{
        static void Main(string[] args){ 
            var cont = " "; 
            var name = " "; 
            var lavel = 0;
            var life = 0;
            var magic = 0;
            var category = " ";

            WriteLine ("Deseja Cirar um Personagem? {s/n} "); 
            cont = ReadLine();
            Write("\n");
            ReadLine();
            Console.Clear();

            WriteLine("Digite o nome do personagem: ");
            name = ReadLine();
            Write("\n");
            WriteLine("Digite o lavel: ");
            lavel = int.Parse(ReadLine());
            Write("\n");
            WriteLine("Quantos de vida tem o personagem: ");
            life = int.Parse(ReadLine());
            Write("\n");
            WriteLine("Quantos De magia tem o seu personagem: ");
            magic = int.Parse(ReadLine());
            Write("\n");
            WriteLine("A classe do personagem: ");
            category = ReadLine();
            Write("\n");
                
            Write("\n");
            ReadLine();
            Console.Clear();

            Character arus = new Character(name, lavel, life, magic, category);
            WriteLine(arus.ToString());

        }
    }
}
