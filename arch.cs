using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo cultura = new CultureInfo("pt-BR");

        Console.Write("Valor presente investido: ");
        double valorPresente = double.Parse(Console.ReadLine(), cultura);

        Console.Write("Taxa de juros mensal (%): ");
        double taxa = double.Parse(Console.ReadLine(), cultura) / 100;

        Console.Write("Número de meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Número de dias: ");
        int dias = int.Parse(Console.ReadLine());

        double periodo = Math.Round(meses + (dias / 30.0), 2);
        double valorFuturo = valorPresente * Math.Pow(1 + taxa, periodo);

        Console.WriteLine();
        Console.WriteLine("Valor Presente\tTaxa\tPeríodo\tValor Futuro");

        for (int mes = 1; mes <= meses; mes++)
        {
            double rendimentoMes = valorPresente * Math.Pow(1 + taxa, mes);

            Console.WriteLine(
                $"{valorPresente.ToString("C", cultura)}\t" +
                $"{taxa.ToString("P2", cultura)}\t" +
                $"{mes}\t" +
                $"{rendimentoMes.ToString("C", cultura)}"
            );
        }

        Console.WriteLine(
            $"{valorPresente.ToString("C", cultura)}\t" +
            $"{taxa.ToString("P2", cultura)}\t" +
            $"{periodo.ToString("N2", cultura)}\t" +
            $"{valorFuturo.ToString("C", cultura)}"
        );
    }
}