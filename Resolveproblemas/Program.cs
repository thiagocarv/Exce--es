using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resolveproblemas
{
    class Program
    {
        static int media(int[] v)
        {
            int s = v[0];
            int i = 1;
            while (i < v.Length)
            {
                s += v[i];
                i++;
            }
            return s / i;
        }

        static void Main(string[] args)
        {
            int qtd = 0;
            Console.WriteLine("Entre com o tamanho do vetor");
            bool vf = int.TryParse(Console.ReadLine(),out qtd);

            if (vf && qtd > 0)
            {
                int[] vetor = new int[qtd];
                for (int c = 0; c < qtd; c++)
                {
                    Console.Write("Digite o valor {0}: ", c);
                    bool vff = int.TryParse(Console.ReadLine(),out vetor[c]);
                    if (vff == false)
                    {
                        Console.WriteLine("Entre com um valor numerico");
                        c = c - 1;
                    }
                    
                }
                Console.WriteLine("A média é {0}", media(vetor));
            }
            else
                Console.WriteLine("Entre com o valor numérico e o vetor tem que ser maior que 0");

                       
           
            Console.Read();

        }
    }
}
