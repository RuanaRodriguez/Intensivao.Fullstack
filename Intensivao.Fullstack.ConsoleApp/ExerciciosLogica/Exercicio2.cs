using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercicio2
{
    public static void Calcular()
    {
        Console.WriteLine("2º - Elabore um algoritmo que recebe o salário mensal atual de um funcionário e um percentual de reajuste e exiba o novo salário.\r\n");
        Console.WriteLine();

        Double salario = 0;
        Double salarioNovo = 0;
        Console.WriteLine("Efetua o reajuste salarial");
        Console.WriteLine("==========================" + "\r\n");
        for (int i = 0; i < 12; i++)
        {
            Console.Write("Informe o salário atual: ");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario <= 300)
            { //50%
                salarioNovo = salario * 1.50;
            }
            else
            { //30%
                salarioNovo = salario + ((salario * 30) / 100);
            }
            Console.WriteLine("Salário reajustado: " + salarioNovo + " R$" + "\r\n");

        }
    }
}

