using System.Runtime.CompilerServices;

namespace HelloWorld;

internal class Program
{
    static void Main(string[] args)
    {
        // autoObject _is_ een object.
        // Wordt ook wel de _instantie_ van class Auto genoemd.
        Auto autoObject = new Auto();
        autoObject.Snelheid = 200;
        autoObject.Kleur = ConsoleColor.Gray;
        autoObject.Versnel(50010);

        autoObject.Rem(50);

        Auto ferrari = new RaceAuto { Kleur = ConsoleColor.Red, HasRollbar=true };
        ferrari.Versnel(60);
        ferrari.Rem(160);



        //Console.WriteLine($"1e: {args[0]}, 2e: {args[1]}");
        //Console.WriteLine("1e: {0}, 2e: {1}", args[0], args[1]);
        //Console.WriteLine("1e: " + args[0] + ", 2e: " + args[1]);
    }
}
