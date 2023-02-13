using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Exercicio5
{
    public static void Calcular()
    {
        Console.WriteLine("5º - Verifique se duas strings são iguais, independente da caixa das letras. Por exemplo, este programa deve dizer que 'Teste' é igual a 'TeStE', mas isso \r\n  deve equivaler pra outros valores de entradas.");
        Console.WriteLine();

        Console.WriteLine("Digite a palavra: ");
        string palavra = Console.ReadLine();
        Console.WriteLine("Digite outra palavra");
        string palavra2 = Console.ReadLine();
        if (palavra.ToUpper() == palavra2.ToUpper())
        {
            Console.WriteLine($" {palavra}  {palavra2} As palavras são iguais");
        }
        else
        {
            Console.WriteLine($" {palavra}  {palavra2} As palavras são difentes");
        }
    }
}
