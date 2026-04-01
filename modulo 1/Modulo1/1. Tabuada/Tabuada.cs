/* ## 1. Tabuada
 * 
 * Peça ao usuário um número inteiro e exiba a tabuada dele de 1 a 10 usando `for`.
 */

using System;

class Tabuada
{
    public static void Executar()
    {
        Console.Clear();

        bool isSucess = false;
        int num = 0;
        bool sair = false;

        while (!sair)
        {
            while (!isSucess)
            {
                Console.WriteLine("Digite um numero para saber a tabuada do 1 - 10 :");
                isSucess = int.TryParse(Console.ReadLine(), out num);

                Console.Clear();

                if (!isSucess)
                {
                    Console.WriteLine("Digite um numero valido!");
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }

            Console.WriteLine("\n 1. Digitar outro numero.\n 2. sair.");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    isSucess = false;
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Progama finalizado...");
                    sair = true;
                    break;
            }
        }

    }


}
