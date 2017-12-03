using System;

namespace SuedPedroAmorim
{
    class Program
    {
        static void Main(string[] args)
        {

            // http://patorjk.com/software/taag/#p=display&f=Ogre&t=Pedro%20Amorim

            Console.Title = "ASCII Art";
            string title = @"
   ___         _               _                        _           
  / _ \___  __| |_ __ ___     /_\  _ __ ___   ___  _ __(_)_ __ ___  
 / /_)/ _ \/ _` | '__/ _ \   //_\\| '_ ` _ \ / _ \| '__| | '_ ` _ \ 
/ ___/  __/ (_| | | | (_) | /  _  \ | | | | | (_) | |  | | | | | | |
\/    \___|\__,_|_|  \___/  \_/ \_/_| |_| |_|\___/|_|  |_|_| |_| |_|";

            Console.WriteLine(title);
            Console.WriteLine("");

            Console.WriteLine("Sim, Mestre. Pode perguntar e eu responderei!");



            ConsoleKeyInfo tecla;
            string resposta = "";

            tecla = Console.ReadKey(true); // true para que o que for digitado não seja escrito no console
            string saudacao = "Oh máquina suprema ";

            if (tecla.KeyChar == ';')
            {
                int n = 0;
                do
                {
                    // captura o que está sendo digitado porém o que é exibido na
                    // tela é parte da saudaçao "obrigatória"
                    tecla = Console.ReadKey(true);
                    Console.Write(saudacao.Substring(n, 1));
                    resposta = resposta + tecla.KeyChar;

                    n++;
                    // a resposta será concluída quando o usuário digitar o segundo ";"
                } while (tecla.KeyChar != ';');
                Console.ReadLine();

                n = 0;
                do
                {
                    // Efeito de busca no console
                    Console.Write("Buscando resposta....: ".Substring(n, 1));
                    n++;
                    System.Threading.Thread.Sleep(100);

                } while (n <= "Buscando resposta...: ".Length);
                // remove o último caracter, no caso, o ";"
                Console.WriteLine(resposta.Remove(resposta.Length - 1).ToUpper());

            }
            else
            {
                // se o usuário não comecar com ";" o programa irá zoar o usuário
                Console.Write(tecla.KeyChar);
                Console.Read();
                Console.WriteLine("Eu só respondo ao meu mestre... ");
            }
      
            //Espera por um caracter, evitando o fechamento da tela de prompt  
            Console.ReadKey();
        }
    }
}
