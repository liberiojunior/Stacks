using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora Científica";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep();
            int aux = 0;
            Pilha Pilha = new Pilha(100);
            string msg = null;
            while (msg != "s")
            {

                Console.WriteLine("Digite um número");

                msg = Console.ReadLine();
                if (msg == "s" || msg == "S") return;
                if (msg == "+")
                {
                    while (Pilha.vazia()) { Console.WriteLine("Pilha vazia, favor digitar um número:"); msg = Console.ReadLine(); if (msg != "+") break; }
                    int n1 = Convert.ToInt32(Pilha.desempilhar());
                    while (Pilha.vazia()) { Console.WriteLine("Pilha vazia, favor digitar um número:"); msg = Console.ReadLine(); if (msg != "+") { aux = Convert.ToInt32(msg); Pilha.empilhar(aux); break; } }
                    int n2 = Convert.ToInt32(Pilha.desempilhar());
                    int temp = n1 + n2;
                    Pilha.empilhar(temp);
                    Console.WriteLine(temp);
                }

                else if (msg == "-")
                {
                    while (Pilha.vazia()) { Console.WriteLine("Pilha vazia, favor digitar um número:"); msg = Console.ReadLine(); if (msg != "-") break; }
                    int n1 = Convert.ToInt32(Pilha.desempilhar());
                    while (Pilha.vazia()) { Console.WriteLine("Pilha vazia, favor digitar um número:"); msg = Console.ReadLine(); if (msg != "-") { aux = Convert.ToInt32(msg); Pilha.empilhar(aux); break; } }
                    int n2 = Convert.ToInt32(Pilha.desempilhar());
                    int temp = n2 - n1;
                    Pilha.empilhar(temp);
                    Console.WriteLine(temp);
                }
                else if (msg == "*")
                {
                    while (Pilha.vazia()) { Console.WriteLine("Pilha vazia, favor digitar um número:"); msg = Console.ReadLine(); if (msg != "*") break; }
                    int n1 = Convert.ToInt32(Pilha.desempilhar());
                    while (Pilha.vazia()) { Console.WriteLine("Pilha vazia, favor digitar um número:"); msg = Console.ReadLine(); if (msg != "*") { aux = Convert.ToInt32(msg); Pilha.empilhar(aux); break; } }
                    int n2 = Convert.ToInt32(Pilha.desempilhar());
                    int temp = n1 * n2;
                    Pilha.empilhar(temp);
                    Console.WriteLine(temp);
                }
                else if (msg == "/")
                {
                    while (Pilha.vazia()) { Console.WriteLine("Pilha vazia, favor digitar um número:"); msg = Console.ReadLine(); if (msg != "/") break; }
                    int n1 = Convert.ToInt32(Pilha.desempilhar());
                    while (Pilha.vazia()) { Console.WriteLine("Pilha vazia, favor digitar um número:"); msg = Console.ReadLine(); if (msg != "/") { aux = Convert.ToInt32(msg); Pilha.empilhar(aux); break; } }
                    int n2 = Convert.ToInt32(Pilha.desempilhar());
                    int temp = n2 / n1;
                    Pilha.empilhar(temp);
                    Console.WriteLine(temp);
                }
                else Pilha.empilhar(Convert.ToInt32(msg));
            }
            Console.ReadKey();
        }
    }
}
