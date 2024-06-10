using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Network
    {
        private int[] pai;

        public Network(int tamanho)
        {
            if (tamanho <= 1)
            {
                throw new Exception("O valor informado precisa ser válido!");
            }

            pai = new int[tamanho + 1];
            for (int i = 1; i <= tamanho; i++)
            {
                pai[i] = i; 
            }
        }

        private int Achar(int x)
        {
            if (pai[x] != x) 
            {
                pai[x] = Achar(pai[x]); 
            }
            return pai[x];
        }

        public void Connect(int num1, int num2)
        {
            if (num1 <= 0 || num2 <= 0 || num1 >= pai.Length || num2 >= pai.Length)
            {
                throw new Exception("Número inválido.");
            }

            int raiz1 = Achar(num1);
            int raiz2 = Achar(num2);

            if (raiz1 != raiz2)
            {
                pai[raiz2] = raiz1; // Torna o raiz2 filho do raiz1, assim sendo, no query, os dois terão o mesmo valor, logo, mesmo conjunto. 
            }
        }

        public bool Query(int num1, int num2)
        {
            if (num1 <= 0 || num2 <= 0 || num1 >= pai.Length || num2 >= pai.Length)
            {
                throw new Exception("Número inválido.");
            }

            return Achar(num1) == Achar(num2); //
        }
    }
}