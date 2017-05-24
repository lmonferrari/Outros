using System;

namespace Exercicio5
{
    class Program
    {
        //É O TAMANHO DO VETOR, CASO VOCÊ QUEIRA UM VETOR 
        //MAIOR VOCÊ DEVE ALTERAR O NUMERO NA FRENTE
        static int TAMANHO = 5;

        static void Main(string[] args)
        {
            var A = new int[TAMANHO]; //VETOR A
            var B = new int[TAMANHO]; //VETOR B
            var resultado = 0; // VARIAVEL QUE ARMAZENA A SOMA

            //recebendo dados do usuário
            //vetor A
            for (int i = 0; i < TAMANHO; i++)
            {
                Console.WriteLine(i+ 1 + " Vetor A -  Digite um numero: ");
                // convertendo a string digitada para inteiro
                // armazeando na posição i do vetor
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            //recebendo dados do usuário
            //vetor B
            for (int i = 0; i < TAMANHO; i++)
            { 
                Console.WriteLine(i + 1 + " Vetor B -  Digite um numero: ");
                // convertendo a string digitada para inteiro
                // armazeando na posição i do vetor
                B[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                //AQUI O RESULTADO RECEBE RESULTADO + ELEMENTO A NA POSIÇÃO I
                //E ELEMENTO B NA POSIÇÃO FINAL, POIS TAMANHO - 1 - I = FIM DO VETOR
                 resultado += A[i] - B[TAMANHO -1 - i];
            }

            //AQUI ESTAMOS IMPRIMINDO OS VETORES
            //PODE USAR O FOR(i = 0; i < TAMANHO; i++)
            foreach (var item in A)
            {
                Console.WriteLine("Vetor A : {0}", item);
            }
            foreach (var item in B)
            {
                Console.WriteLine("Vetor B : {0}", item);
            }

            //IMPRIMINDO O RESULTADO DAS SOMAS
            Console.WriteLine("Resultado {0}",resultado);
        }
    }
}
