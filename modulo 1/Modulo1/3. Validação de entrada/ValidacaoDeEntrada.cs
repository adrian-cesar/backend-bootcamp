/* ## 3. Validação de entrada
 * 
 * Usando `do while`, peça ao usuário que digite uma senha. 
 * Continue pedindo até que a senha digitada seja `"bootcamp123"`. 
 * Exiba uma mensagem de boas-vindas ao acertar.
 */

using System;

class ValidacaoDeEntrada
{
    public static void Executar()
    {
        string senha;

        do
        {
            Console.WriteLine("Digite a senha para entrar: ");
            senha = Console.ReadLine();

            if (senha != "bootcamp123")
            {
                Console.Clear();
                Console.WriteLine("Senha Incorreta!");
            }

        } while (senha != "bootcamp123");

        Console.Clear();
        Console.WriteLine("Bem vindo!");

    }
}

