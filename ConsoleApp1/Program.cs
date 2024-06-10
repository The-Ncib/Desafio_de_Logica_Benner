using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Olá! Tudo bem? Informe o tamanho do set de dados: "); 

            
            int numSet = Convert.ToInt32(Console.ReadLine());

            Network rede = null; 

            try
            {
                rede = new Network(numSet);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
                Environment.Exit(1); 

              
            }

            bool saida = false;

            while (!saida)
            {

                Console.WriteLine("1 - Informar duas novas conexões\n" +
                "2 - Verificar se dois números estão conectados\n" +
                "3 - Fechar programa");

                int esc = Convert.ToInt32(Console.ReadLine());

                switch (esc)
                {
                    case 1:

                        try
                        {
                            Console.Clear();
                            Console.Write("Informe o primeiro número a ser conectado: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Informe o segundo número a ser conectado: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            rede.Connect(num1, num2);
                        }
                        catch (Exception e )
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Pressione qualquer tecla para sair");
                            Console.ReadKey();
                            Environment.Exit(1);
                        }
                        break;

                    case 2:

                        try
                        {
                            Console.Clear();
                            Console.Write("Informe o primeiro número a ser verificado: ");
                            int num3 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Informe o segundo número a ser verificado: ");
                            int num4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(rede.Query(num3, num4));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Pressione qualquer tecla para sair");
                            Console.ReadKey();
                            Environment.Exit(1);
                        }
                        break;

                    case 3:
                        saida = true;
                        break;

                    default:
                        Console.WriteLine("Favor informar uma opção válida!");
                        break;
                }

            }

        }
    }
}
