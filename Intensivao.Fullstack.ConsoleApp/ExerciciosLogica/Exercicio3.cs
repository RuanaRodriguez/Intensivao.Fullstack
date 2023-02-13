using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercicio3
{
    public static void Calcular()
    {
        Console.WriteLine("3º - Realize um cálculo de média final entre quatro notas e informe se ele está na média, abaixo ou acima, considerando que \r\n  abaixo (menor que 4 pontos), na média (entre 4 e menor que 7 pontos) e acima (maior ou igual que 7 pontos).");
        Console.WriteLine();

        Console.WriteLine("Digite a primeira nota: ");
        Double Nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        Double Nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        Double Nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota: ");
        Double Nota4 = Convert.ToDouble(Console.ReadLine());

        Double Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

        if (Media < 4)
        {
            Console.WriteLine("Aluno está abaixo da media! ");
            Console.WriteLine("Sua nota é: " + Media);
        }
        else if (Media == 4 && Media < 7)
        {
            Console.WriteLine("O aluno está na media! ");
            Console.WriteLine("Sua nota é: " + Media);
        }
        else if (Media >= 7)
        {

            Console.WriteLine("Aluno está acima da media! ");
            Console.WriteLine("Sua nota é: " + Media);
        }
    }
}

