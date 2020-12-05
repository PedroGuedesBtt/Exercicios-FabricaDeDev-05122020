using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
         
                Console.Write("Entre com um valor numerico: ");
                var valorColetado = int.TryParse(Console.ReadLine(), out int valorDigitadoColetado);

                if (valorColetado == true)
                {

                    Console.WriteLine("O Valor Digitado está certo! \nfoi: {0}", valorDigitadoColetado);
                }
                else
                {
                Console.WriteLine("Infelizmente você não colocou um valor válido...\n{0}",valorColetado, "\n Abra o programa novamente e tente de novo");

                }

             
         

           
        }
    }
}
