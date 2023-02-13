using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

public class Exercicio6
{
    public static void Calcular()
    {
        Double pesoPrato, valorPagar;

        Console.WriteLine("6º O restaurante sancho - pança cobra R$12,00 por cada quilo de refeição.Escreva um algoritmo" +
                          "que leia o peso do prato montado pelo cliente(em quilos) e imprima o valor a pagar. Assuma que a" +
                          "balança já desconte o peso do prato.");

        Console.WriteLine();
        Console.Write("Qual o peso do prato (Kg): ");
        pesoPrato = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        valorPagar = pesoPrato * 12.0;

        Console.Write($"Valor a pagar = R$ {valorPagar.ToString("F2", CultureInfo.InvariantCulture)} ");
        Thread.Sleep(2500);
        Console.Clear();
        Calcular();
    }

}


