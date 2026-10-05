using System;

class Program
{
    static void Main()
    {
        double capital = 1200;
        double taux = 0.013; 

        Console.Write("Quelle somme souhaitez-vous atteindre (en euro) ? ");
        double objectif = double.Parse(Console.ReadLine());

        int annees = 0;

        while (capital < objectif)
        {
            capital = capital + capital * taux;
            annees++;
        }

        Console.WriteLine($"Il faudra {annees} année(s) pour atteindre {objectif} €.");
        Console.WriteLine($"Capital au bout de {annees} année(s) : {capital:F2} €");
    }
}