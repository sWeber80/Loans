using Loans;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        //input
        Console.WriteLine("Bitte gib den Vorname ein:");
        string? vorname = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(vorname))
        {
            Console.WriteLine("Vorname daft nicht leer sein.");
            return;
        }
        Console.WriteLine("Bitte gib den Nachname ein:");
        string? nachname = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nachname))
        {
            Console.WriteLine("Nachname daft nicht leer sein.");
            return;
        }
        Console.WriteLine("Bitte gib den Betrag ein:");
        decimal betrag = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Bitte gib den LeihDatum ein (yyyy.MM.dd):");
        DateTime leihDatum = Convert.ToDateTime(Console.ReadLine());

        EintragLoans eintrag = new EintragLoans(vorname, nachname, (decimal)betrag, leihDatum);
        List<EintragLoans> eintraege = new List<EintragLoans>();
        eintraege.Add(eintrag);

        //create a file (relativer Pfad)
        string filePath = Path.Combine(Environment.CurrentDirectory, "Leans.csv");
        //check -> file Leans.csv exists.
        if (!File.Exists(filePath))
        {
            //definiere Kopfzeile
            string headLine = "Vorname; Nachname; Betrag; LeihDatum";
            File.WriteAllText(filePath, headLine + Environment.NewLine);

        }
        //add a new entry
        string newLine = $"{vorname}; {nachname}; {betrag}; {leihDatum:yyyy.MM.dd}";
        File.AppendAllText(filePath, newLine + Environment.NewLine);
        Console.WriteLine("Eintrag gespeichert");

        //ToDo remove entries


    }

}


