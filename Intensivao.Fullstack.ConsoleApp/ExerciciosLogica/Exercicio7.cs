using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics.Metrics;

public class Exercicio7
{
    public static void Calcular()
    {


        Console.WriteLine("2º Uma fábrica controla o tempo de trabalho sem acidentes pela quantidade de dias. Faça um algoritmo para converter este tempo em anos, meses e dias. Assuma que cada mês possui sempre\r\n30 dias.");
        
        Console.WriteLine();
        Console.Write("Insira o tempo de trabalho sem acidentes em dias: ");
        int dias = int.Parse(Console.ReadLine());

        int anos = dias / 365;
        int meses = (dias % 365) / 30;
        int restantesDias = (dias % 365) % 30;

        Console.WriteLine("{0} dias de trabalho sem acidentes é equivalente a {1} anos, {2} meses e {3} dias", dias, anos, meses, restantesDias);
        Thread.Sleep(2500);
        Console.Clear();
        Calcular();
    }

}


