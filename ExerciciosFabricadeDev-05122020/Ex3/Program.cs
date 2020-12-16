using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entre com um valor numérico:");
            var valorConversão = long.TryParse(Console.ReadLine(), out long coletaValor);

            if (valorConversão == true)
            {
                Console.WriteLine("O valor digitado está correto {0}\ne o valor digitado foi: {1}", valorConversão,coletaValor);
                
                if (coletaValor <= sbyte.MaxValue && coletaValor >= sbyte.MinValue)
                {

                    Console.WriteLine("O melhor tipo de váriavel para armazenar este valor é um sbyte.");

                }
                else if (coletaValor <= short.MaxValue && coletaValor >= short.MinValue)
                {
                    
                    Console.WriteLine("O melhor tipo de váriavel para armazenar este valor é um Short");
                }
                else if (coletaValor <= int.MaxValue && coletaValor >= int.MinValue)
                {
                    Console.WriteLine("O melhor tipo de váriavel para armazenar este valor é um INT");

                }
                else
                {
                    Console.WriteLine("O melhor tipo de váriavel para armazenar este valor é um Long");
                }

            }
            else
            {

                Console.WriteLine("Este não é um valor válido, tente novamente");
               
            }
        }
    }
}
