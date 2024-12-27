// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;

namespace AulaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro para dimensão da matriz: ");
            int numberInt = int.Parse(Console.ReadLine());
            
            int[,] matrizInt = new int[numberInt,numberInt];
            int negativeCounter = 0;
            
            for (int i = 0; i < numberInt; i++)
            {
                Console.Write($"Digite os números da linha {i+1}: ");
                string[] linha = Console.ReadLine().Split(' ');
                
                for (int j = 0; j < numberInt; j++)
                {
                    matrizInt[i,j] = int.Parse(linha[j]);
                    
                    if (matrizInt[i,j] < 0)
                    {
                        negativeCounter++;
                    }
                }
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Matriz:");
            for (int i = 0; i < numberInt; i++)
            {
                for (int j = 0; j < numberInt; j++)
                {
                    Console.Write($"{matrizInt[i,j]}    ");
                }

                Console.WriteLine(" ");
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < numberInt; i++)
            {
                for (int j = 0; j < numberInt; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{matrizInt[i,j]}    ");
                    }
                    else
                    {
                        Console.Write($".    ");
                    }
                }

                Console.WriteLine(" ");
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Negativos: {negativeCounter}");
            
        }
        
    }
}

