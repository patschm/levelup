namespace HelloWorld
{
    internal class RaceAuto : Auto
    {
        public bool HasRollbar { get; set; }

        // Override maakt dit gedrag echt polymorf
        public override void Versnel(int aantal)
        {
            Console.ForegroundColor = Kleur;
            Snelheid += aantal;
            Console.WriteLine($"De raceauto brult naar {Snelheid}km/h");
            Console.ResetColor();
        }
        public override void Rem(int aantal)
        {
            Console.ForegroundColor = Kleur;
            Snelheid -= aantal;
            Console.WriteLine($"De raceauto piept naar {Snelheid}km/h");
            Console.ResetColor();
        }
    }
}
