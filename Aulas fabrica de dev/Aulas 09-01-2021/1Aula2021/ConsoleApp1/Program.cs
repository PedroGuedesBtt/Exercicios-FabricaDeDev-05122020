using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        enum Signo
        {
            Áries,
            Touro,
            Gêmeos,
            Câncer,
            Leão,
            Virgem,
            Libra,
            Escorpião,
            Sagitário,
            Capricórnio,
            Aquário,
            Peixes,
            Serpentário



        }
        static void Main(string[] args)
        {


            //Console.WriteLine("Parte 2 do curso");
            ////Estruturas de seleção/decisão

            //Console.WriteLine("Entre com uma idade:");
            //var idade = Console.ReadLine();
            //PegaIdade(idade);

            //Console.WriteLine("Entre com seu signo");
            //var signo = Console.ReadLine();
            //ColetaSigno(signo);
            Console.WriteLine("Programa que lê signos.");
            //string[] vetorSigno = new string[2];

            //vetorSigno[1] = lua;
            //for (int i = 0; i < vetorSigno.Length; i++)
            //{
            //    try
            //    {
            //        ColetaSigno(vetorSigno[i]);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);

            //    }


            //}

            bool continuar;
            //while (continuar)
            // {
            do
            {
                List<string> listSignos = new List<string>();
                Console.WriteLine("entre com seu Sol");
                var sol = Console.ReadLine();
                listSignos.Add(sol);
                //vetorSigno[0] = sol;
                Console.WriteLine("entre com sua Lua");
                var lua = Console.ReadLine();
                listSignos.Add(lua);
                foreach (var signo in listSignos)
                {
                    try
                    {
                        ColetaSigno(signo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                Console.WriteLine("quer escrever outro signo? S/N");
                var usuarioDesejaContinuar = Console.ReadLine();
                if (usuarioDesejaContinuar == "N")
                {
                    continuar = false;

                }
                else{
                    continuar = true;
                }

            }
            while (continuar);
            // }
            Console.WriteLine("fim do programa");


        }

        private static void ColetaSigno(string signo)
        {

            var signoFoiConvertido = Enum.TryParse<Signo>(signo,true, out Signo signoConvertido);

            if (!signoFoiConvertido)
            {
                throw new ArgumentException("Signo Inválido!");
            }
            
            Console.WriteLine("signoConvertido{0} ", signoConvertido);
            if (signo.ToLower() == "peixes")
            {
                Console.WriteLine("Signo Top");
            }
            else if (signo.ToLower() == "áries")
            {
                Console.WriteLine("Signo triste");
            }
            else
            {
                Console.WriteLine("Signo não importante pra situação atual");
            }
            switch (signoConvertido)    
            {
                case Signo.Áries:
                    Console.WriteLine("Áries é impaciente, não suporta limites e não costuma se dar bem com ordens e autoridades em geral. No fundo é uma criança desobediente, mas com um bom coração, com a cabeça cheia de ideias de transformar o mundo. No entanto seus humores bem como suas explosões duram pouco. Quase nunca guardam rancor.");
                    break;
                case Signo.Touro:
                    Console.WriteLine("Regido por Vênus, o planeta do amor, as pessoas do signo de Touro são românticas e não poupam a criatividade para agradar o crush. ... Com terra como seu elemento, os taurinos acabam sendo muito apegados à pessoas e bens materiais também. Daí a fama de ciumentos e possessivos.");
                    break;
                case Signo.Gêmeos:
                    Console.WriteLine("Gêmeos é um signo de ar, regido por Mercúrio, conhecido como o mensageiro dos deuses. É o signo da comunicação, aquele que cria relações. Gêmeos é a mais urbana das criaturas do zodíaco. Você vai encontrá-lo em uma festa rodeado de pessoas, falando e gesticulando alegre e aceleradamente");
                    break;
                case Signo.Câncer:
                    Console.WriteLine("Este é tradicionalmente um signo de família. É conservador, seus humores são instáveis como as marés, sua sensibilidade e intuição suas melhores qualidades. Nunca espere objetividade de uma pessoa de câncer. Se ela quer algo de você, ela vai rodear, rodear, até conseguir o que deseja.");
                    break;
                case Signo.Leão:
                    Console.WriteLine("Quem nasce com o Sol em Leão é corajoso, leal, criativo, tem autoestima e gosta de ser o centro das atenções. São em geral muito otimistas e generosos.");
                    break;
                case Signo.Virgem:
                    Console.WriteLine("Ter o Sol em Libra significa ser cortês, delicado, equilibrado e buscam ter relacionamentos harmoniosos e pacíficos.");
                    break;
                case Signo.Libra:
                    Console.WriteLine("Ter o Sol em Libra significa ser cortês, delicado, equilibrado e buscam ter relacionamentos harmoniosos e pacíficos.");
                    break;
                case Signo.Escorpião:
                    Console.WriteLine("Os nativos que nascem com o Sol em Escorpião são pessoas intensas, misteriosas, magnéticas e com muito poder de transformação.");
                    break;
                case Signo.Sagitário:
                    Console.WriteLine("Sol em Sagitário significa ser otimista, aventureiro, livre, viajante e jovial. Gostam de conhecer coisas novas e filosofar sobre a vida.");
                    break;
                case Signo.Capricórnio:
                    Console.WriteLine("Nascer com o Sol em Capricórnio significa ter persistência, força física, responsabilidade e ser trabalhador. Gostam de ter metas e buscam ascensão social.");
                    break;
                case Signo.Aquário:
                    Console.WriteLine("Quem nasce com o Sol em Aquário é uma pessoa humanitária, criativa, independente e que busca liberdade.");
                    break;
                case Signo.Peixes:
                    Console.WriteLine("Ter o Sol em Peixes significa ter sensibilidade, percepção, intuição e solidariedade. São muito sonhadores e têm forte conexão com a espiritualidade.");
                    break;
                default:
                    Console.WriteLine("Signo {0} não é válido", signoConvertido);
                    break;
            }
        }

        private static void PegaIdade(string idade)
        {
            var foiConvertido = int.TryParse(idade, out int conversaoIdade);


            if (!foiConvertido)
            {
                throw new ArgumentException("O valor da idade deve ser um numero");
            }
            var anodenascimento = System.DateTime.Now.Year - conversaoIdade;
            Console.WriteLine("Seu ano de nascimento é {0}", anodenascimento);
        }
    }
}
