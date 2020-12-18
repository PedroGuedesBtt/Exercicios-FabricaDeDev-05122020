using System;


namespace Ex1_12_12_2020
{
     public class Lampada{
        public string estado;
          public Lampada ()
            {
            estado = "Desligado";
            }
       public void acende()
        {
            estado = "Ligada";
        }
        public void apaga()
        {
            estado = "Desligada";
        }
        public void mostraEstado()
        {
            if (estado == "Ligada")
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

