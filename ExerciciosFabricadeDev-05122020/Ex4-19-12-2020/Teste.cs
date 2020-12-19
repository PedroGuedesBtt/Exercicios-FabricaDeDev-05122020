using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2_12_12_2020
{
    class Teste
    {

        static void Main(string[] args)

        {

            double areaRetangulo1, areaRetangulo2, areaRetangulo3;
            double perimetroRetangulo1, perimetroRetangulo2, perimetroRetangulo3;

            Retangulo caixa1 = new Retangulo(0,0);
            Retangulo caixa2 = new Retangulo(18.0, 17.2);
            Retangulo caixa3 = new Retangulo(13.5, 14.5);
            
            areaRetangulo1 = caixa1.CalculaArea(0,0);
            areaRetangulo2 = caixa2.CalculaArea(18.0, 17.2);
            areaRetangulo3 = caixa3.CalculaArea(13.5, 14.5);

            perimetroRetangulo1 = caixa1.CalculaPerimetro(0,0);
            perimetroRetangulo2 = caixa2.CalculaPerimetro(18.0, 17.2);
            perimetroRetangulo3 = caixa3.CalculaPerimetro(13.5, 14.5);


            Console.WriteLine("A altura do seu primeiro retangulo é:{0}\nA largura do seu primeiro retangulo é:{1}\nO perímetro do seu primeiro retangulo é:{2}" +
                "\nE a Área do seu primeiro retangulo é: {3}", caixa1.altura, caixa1.largura,perimetroRetangulo1, areaRetangulo1);
            

            Console.WriteLine("\nA altura do seu segundo retangulo é:{0}\nA largura do seu segundo retangulo é:{1}\nO perímetro do seu seu retangulo é:{2}" +
                "\nE a Área do seu segundo retangulo é: {3}", caixa2.altura, caixa2.largura, perimetroRetangulo2, areaRetangulo2);

            Console.WriteLine("\nA altura do seu terceiro retangulo é:{0}\nA largura do seu terceiro retangulo é:{1}\nO perímetro do seu terceiro retangulo é:{2}" +
               "\nE a Área do seu terceiro retangulo é: {3}", caixa3.altura, caixa3.largura, perimetroRetangulo3, areaRetangulo3);


        }
    }
}
