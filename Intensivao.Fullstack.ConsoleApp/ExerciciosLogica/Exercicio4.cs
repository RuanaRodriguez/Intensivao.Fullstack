using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercicio4
{
    public static void Calcular()
    {
        Console.WriteLine("4º - Crie um vetor que com os seguintes valores: 2, 5, 15, 56, 22, 3, 9, sabendo disso, ordene os valores de forma sequencial e repita 3x o valor '22'.");
        Console.WriteLine();

        int[] numeros = new int[] { 2, 5, 15, 56, 22, 3, 9 };
        Array.Sort(numeros);
        foreach (int num in numeros)
        {
            if (num == 22)
            {
                Console.Write(num + " , ");
                Console.Write(num + " , ");
                Console.Write(num + " , ");
            }
            else
            {
                Console.Write(num + " , ");
            }
        }
    }
}
