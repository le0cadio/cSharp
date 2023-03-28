using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentosCommon
{
    public class Program
    {
        int[] arrayInteiros = new int[3];

        public void Main(string[] args)
        {
            arrayInteiros[0] = 72;
            arrayInteiros[1] = 73;
            arrayInteiros[2] = 74;
            //Percorrendo o ARRAY com o FOR
            for (int contador = 0; contador < arrayInteiros.Length; contador++)
            {
                Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
            }
            //Percorrendo o ARRAY com FOREACH
            foreach (int item in arrayInteiros)
            {
                Console.WriteLine($"Valor do item: {item}");
            }
        }
    }
}
