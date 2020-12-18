using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte valorMaximoDeUmSByte = sbyte.MaxValue;
            sbyte valorMinimoDeUmSByte = sbyte.MinValue;

            Console.WriteLine("Valor máximo de um sbyte: {0}", valorMaximoDeUmSByte);
            Console.WriteLine("Valor mínimo de um sbyte: {0}", valorMinimoDeUmSByte);

            short valorMaximoDeUmShort = short.MaxValue;
            short valorMínimoDeUmShort = short.MinValue;
            Console.WriteLine("Valor máximo de um short: {0}", valorMaximoDeUmShort);
            Console.WriteLine("Valor mínimo de um short: " + valorMínimoDeUmShort);

            int valorMaximoDeUmInteiro = int.MaxValue;
            int valorMinimoDeUmInteiro = int.MinValue;
            Console.WriteLine($"Valor Máximo de um Inteiro: {valorMaximoDeUmInteiro}");
            string valorMinimoDeUmInteiroTexto = "Valor Mínimo de " +
                "um Intero:" +
                $"{valorMinimoDeUmInteiro}";
            Console.WriteLine(valorMinimoDeUmInteiroTexto);

            string malandragemDoChute = string.Empty;
            malandragemDoChute += "";

            long valorMaximoDeUmLong = long.MaxValue;
            long valorMinimoDeUmLong = long.MinValue;

            string sugestaoDePularLinhaDoChute = "Valor Máximo de" + "\n" +
                "um long" + "\n" +
                $"{valorMaximoDeUmLong}";
            Console.WriteLine(sugestaoDePularLinhaDoChute);

            string sugestaoDePularLinhaMaisElegante = "Valor Mínimo de" + Environment.NewLine
                + "um long" + Environment.NewLine +
                $"{valorMinimoDeUmLong}";
            Console.WriteLine(sugestaoDePularLinhaMaisElegante);

            Int64 valorMaximoInt64 = Int64.MaxValue;
            Console.WriteLine("Valor Máximo de um Int64: {0}", valorMaximoInt64);


            var valorMaximoDeUmByte = byte.MaxValue;
            var valorMinimoDeUmByte = byte.MinValue;
            Console.WriteLine("Valor máximo de um Byte: {0}", valorMaximoDeUmByte);
            Console.WriteLine("Valor mínimo de um Byte: {0}", valorMinimoDeUmByte);


            var valorMaximoDeUmUShort = ushort.MaxValue;
            var valorMinimoDeUmUShort = ushort.MinValue;
            Console.WriteLine("Valor máximo de um ushort: {0}", valorMaximoDeUmUShort);
            Console.WriteLine("Valor Mínimo de um ushort: {0}", valorMinimoDeUmUShort);

            var valorMaximoDeUmUInt = uint.MaxValue;
            var valorMinimoDeUmUInt = uint.MinValue;
            Console.WriteLine("Valor máximo de um uint: {0}", valorMaximoDeUmUInt);
            Console.WriteLine("Valor Mínimo de um uint: {0}", valorMinimoDeUmUInt);

            var valorMaximoDeUmULong = ulong.MaxValue;
            var valorMinimoDeUmULong = ulong.MaxValue;
            Console.WriteLine("Valor máximo de um ulong: {0}", valorMaximoDeUmULong);
            Console.WriteLine("Valor Mínimo de um ulong: {0}", valorMinimoDeUmULong);


            var inteiroLiteral = 1;
            var hexaDecimaLiteral = 0x9809B84A1F8478F;//0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F
            var binarioLiteral = 0b_010101011111000111011;//0,1
            Console.WriteLine("Inteiro literal: {0}", inteiroLiteral);
            Console.WriteLine("hexadecimal literal: {0}", hexaDecimaLiteral);
            Console.WriteLine("binario literal: {0}", binarioLiteral);

            char caracterRepresentandoALetraAMinuscula = 'a';
            Console.WriteLine("a: {0}", caracterRepresentandoALetraAMinuscula);


            float valorMaximoFloat = float.MaxValue;
            float valorMinimoFloat = float.MinValue;
            Console.WriteLine("Valor Máximo de um float: {0}", valorMaximoFloat);
            Console.WriteLine("Valor Minimo de um float: {0}", valorMinimoFloat);

            double valorMaximoDouble = double.MaxValue;
            double valorMinimoDouble = double.MinValue;
            Console.WriteLine("Valor Máximo de um double: {0}", valorMaximoDouble);
            Console.WriteLine("Valor Minimo de um double: {0}", valorMinimoDouble);
        }
    }
}