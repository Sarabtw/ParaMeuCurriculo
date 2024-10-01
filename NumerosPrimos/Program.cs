﻿// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Digite um algarismo para verificar se é um número primo: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            int divisor = 2;
            if (numero < 2)
            {
                Console.WriteLine("Este número não entra nesta classificação. ");
            }
            if (numero % divisor == 0)
            {
                Console.WriteLine("Este número não é primo. ");
            }
        }
        else
        {
             Console.WriteLine("Número inválido");
        }
    }
}