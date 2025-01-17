﻿using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("----------------------------");
            Console.WriteLine("          Gritador          ");
            Console.WriteLine("----------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Por favor, digite alguma coisa:");
            String algumaCoisa = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{algumaCoisa.ToUpper()}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("para de gritar comigo!, vc pensa que eu sou só uma maquína?, eu sinto emoções também!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("clique em uma tecla para limpar a tela");
            Console.ReadKey();
            
            Console.Clear();
        }
    }
}
