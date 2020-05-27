using System;

namespace SistemaSimplesPOO_Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            celular celular = new celular();
            Console.WriteLine ("Qual é a cor do dispositivo?");
            celular.color = Console.ReadLine();

            Console.WriteLine ("E o modelo?");
            celular.model = Console.ReadLine();

            Console.WriteLine ("Digite agora o tamanho do dispositivo.");
            celular.size = float.Parse(Console.ReadLine());

            Console.WriteLine ("Deseja ligar o dispositivo? (responda com sim ou nao)");
            celular.on = celular.On(Console.ReadLine());

            Console.WriteLine ("O que deseja fazer agora? Digite (off) para desligar o dispositivo, (m) para enviar uma mensagem e (c) para realizar uma chamada.");
            string decisao = Console.ReadLine();

            switch(decisao){
                case "off":
                    if(celular.on == true){
                        Console.WriteLine ("O dispositivo foi desligado com sucesso.");
                    }else{
                        Console.WriteLine ("O dispositivo já estava desligado.");
                    }
                break;
                case "m":
                    if (celular.on == true){
                        Console.WriteLine ("Mensagem enviada!");
                    }else{
                        Console.WriteLine ("Não é possível realizar tal ação com o dispositivo desligado.");
                    }
                break;    
                case "c":
                    if (celular.on == true){
                        Console.WriteLine ("Chamada realizada!");
                    }else{
                        Console.WriteLine ("Não é possível realizar tal ação com o dispositivo desligado.");
                    }
                break;
                default:
                    Console.WriteLine ("Comando inválido ou inacessível.");
                break;
                }
            }


        }
    }
