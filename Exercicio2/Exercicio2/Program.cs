using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //claro que o programa da pra ficar muito mais optimizado
            //mas eu não sei o que você ja viu então tentei deixar 
            //sem ferramentas complexas

            var A = new int[10];
            var B = new int[10];
            var C = new int[10];
            var contadorDePositivos = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + " - Digite um numero: ");

                //como o resultado é uma string devemos converter em inteiro
                var input = Convert.ToInt32(Console.ReadLine());

                if (input >= 0) contadorDePositivos++;


                if (contadorDePositivos == 4)
                    Console.WriteLine("Este e o seu ultimo numero positivo.");

                //vai segurar até a pessoa digitar um numero negativo
                while (input >= 0 && contadorDePositivos >= 6)
                {
                    Console.WriteLine("Voce deve entrar com numero negativo.");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input < 0) A[i] = input;
                }

                A[i] = input;
            }

            //vai ajudar a controlar a posição do vetor
            //para nao precisar de dois for
            int indexMaiorQueZero = 0;
            int indexMenorQueZero = 0;

            for (int i = 0; i < 10; i++)
            {
                if (A[i] < 0)
                {
                    C[indexMenorQueZero] = A[i];
                    indexMenorQueZero++;
                }
                else
                {
                    B[indexMaiorQueZero] = A[i];
                    indexMaiorQueZero++;
                }
            }

            //imprimindo vetor
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("VETOR A : " + A[i]);
            }

            //imprimindo vetor
            for (int i = 0; i < indexMenorQueZero; i++)
            {
                Console.WriteLine("VETOR B : " + B[i]);
            }

            //imprimindo vetor
            for (int i = 0; i < indexMaiorQueZero; i++)
            {
                Console.WriteLine("VETOR C : " + C[i]);
            }
        }
    }
}
