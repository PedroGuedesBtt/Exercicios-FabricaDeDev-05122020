using System;

namespace Ex2_12_12_2020
{
    class Retangulo
    {
        public double altura;
        public double largura;
        private double padrãoAltura = 1.0;
        private double padrãoLargura =1.0;

        public Retangulo()
        {
            altura=1.0;
            largura = 1.0;
        }
        public Retangulo(double recebeAltura, double recebeLargura)
        {
            if (recebeAltura>=1.0 && recebeAltura<=20)
            {
                altura = recebeAltura;
            }
            else
            {
                Console.WriteLine("Valor digitado para algura está inválido, favor digitar um valor entre 1.0 e 20.0");
            }

            if (recebeLargura >= 1.0 && recebeLargura <= 20)
            {
                largura = recebeLargura;
            }
            else
            {
                Console.WriteLine("Valor digitado para largura está inválido, favor digitar um valor entre 1.0 e 20.0");
            }
          

        }

        public double CalculaPerimetro(double valorAltura,double valorLargura)
        {
            double resultadoPerimetro = valorAltura * 2 + valorLargura * 2;
            return resultadoPerimetro;
        }
        public double CalculaArea (double valorAltura, double valorLargura)
        {
            double resultadoArea = valorLargura * valorAltura;
            return resultadoArea;
        }

    }
}
