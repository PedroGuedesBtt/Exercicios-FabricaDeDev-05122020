using System;


namespace Ex1_12_12_2020
{
     public class Lampada{

        public enum estado
        {
            Ligado,
            Desligado
        }
        public estado Estado { get; set; }
        public Lampada ()
            {
            Estado = estado.Desligado ;
            }
       public void acende()
        {
            Estado = estado.Ligado;
        }
        public void apaga()
        {
            Estado = estado.Desligado;
        }
        public void mostraEstado()
        {
            if (Estado == estado.Ligado)
            {
                Console.WriteLine("Lâmpada Acesa!");
            }
            else
            {
                Console.WriteLine("Lâmpada Apagada");
            }
        }


        }
        


    }

