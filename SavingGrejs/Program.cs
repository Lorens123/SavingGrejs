using System.IO;
using System.Runtime.ConstrainedExecution;
using System;
using System.Text.Json;

namespace SavingGrejs
{
    class Program
    {
        static void Main(string[] args)
        {

            Karaktär karaktär = new Karaktär();


            Console.WriteLine("Ge din karaktär ett namn: ");
            karaktär.name = Console.ReadLine();
            Console.WriteLine("Hur mycket damage ger " + karaktär.name + "? ");
            karaktär.damage = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket hp har din " + karaktär.name + "? ");
            karaktär.hitPoints = int.Parse(Console.ReadLine());


            Console.WriteLine($"Namn: {karaktär.name} | Damage: {karaktär.damage} | HP: {karaktär.hitPoints} ");
            string karaktjson = JsonSerializer.Serialize<Karaktär>(karaktär);

            Console.WriteLine(karaktjson);
            File.WriteAllText("karaktar.json", karaktjson);








            Console.ReadLine();

        }
    }
}
