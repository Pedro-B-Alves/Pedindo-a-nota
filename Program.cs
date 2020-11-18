using System;

namespace Pedindo_a_nota
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            Console.WriteLine("Digite uma nota com o valor entre 0 e 10");
            numero = float.Parse(Console.ReadLine());
            bool Condicao = true;
            while(Condicao == true)
            {
                if (numero >= 0 && numero <=10)
                {
                   Console.WriteLine("Você digitou um valor válido");
                   Condicao = false;
                }else
                {
                    Console.WriteLine("Você digitou um valor inválido");
                    Console.WriteLine("Digite um valor válido");
                    numero = float.Parse(Console.ReadLine());
                }
            }
        }
    }
}
