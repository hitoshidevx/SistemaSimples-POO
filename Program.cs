using System;

namespace SistemaSimplesPOO_Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();

            celular.modelo = "iPhone X";
            celular.cor = "Preto";
            celular.tamanho = 7.7f;

            Console.WriteLine("O modelo do celular é: "+ celular.modelo);
            Console.WriteLine("Sua cor é: "+ celular.cor);
            Console.WriteLine("E seu tamanho é igual a: "+ celular.tamanho);
            
            Console.WriteLine("O celular está ligado?");
            celular.estado = celular.EstadoCelular(Console.ReadLine());

            celular.mensagem = "O celular pode enviar mensagens.";
            celular.ligacao = "O celular pode fazer ligações.";

            Console.WriteLine(celular.mensagem);
            Console.WriteLine(celular.ligacao);
        }
    }
}
