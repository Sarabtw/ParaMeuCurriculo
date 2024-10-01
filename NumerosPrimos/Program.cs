// See https://aka.ms/new-console-template for more information
using System; 

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Digite um algarismo para verificar se é um número primo: "); // Escreve a instrução para o usuário;
        if (int.TryParse(Console.ReadLine(), out int numero)) // Lê a mensagem enviada e tenta converter a entrada em um número inteiro, se não for um número identificado como inteiro o programa escreve uma mensagem; 
        {
            int divisor = 2; // Indica que a variável chamada divisor é inicializada com o valor 2;
            if (numero < 2) // Verifica se o número é menor que 2, pois números menores que 2 não são caracterizados como primos;
            {
                Console.WriteLine("Este número não entra nesta classificação. "); //Informa ao usuário que o número digitado não está nesta classificação;
            }
            if (numero % divisor == 0) // Verifica se o número é divisível por 2, se o resultado for igual a zero significa que o número não é classificado como primo;
            {
                Console.WriteLine("Este número não é primo. "); //Informa ao usuário que o número não se classifica como primo;
            }
            else
            {
                Console.WriteLine("Este número é primo.")
            }
        }
        else // Este bloco só será executado se a conversão do número falhar;
        {
             Console.WriteLine("Número inválido"); // Informa ao usuário que o número digitado é inválido, não conseguiu ser convertido antes.
        }
    }
}