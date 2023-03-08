namespace HelloWorld
{

    // Custom type
    class Auto
    {
        // Eigenschappen sla je op fields!! (veredelde variabelen)
        private int snelheid = 100;
        // private ConsoleColor kleur = ConsoleColor.Black;

        // Property. 
        // Geeft gecontroleerd toegang tot jouw private fields (Encapsulation)
        public int Snelheid
        {
            get
            {
                return snelheid;
            }
            set
            {
                if (value >= -100 && value <= 250)
                {
                    snelheid = value;
                }
            }
        }

        // Auto generating property
        // Genereert zijn eigen private field (backing-field)
        public ConsoleColor Kleur { get; set; } = ConsoleColor.DarkBlue;

        // Gedrag sla je op in Methods!! (veredelde functies of procedures)
        // Virtual maakt het gedrag polymorf-ready.
        // Optioneel kan dit gedrag in afgeleide classen overschreven worden.
        public virtual void Versnel(int aantal)
        {
            Console.ForegroundColor = Kleur;
            Snelheid += aantal;
            Console.WriteLine($"De auto versnelt naar {Snelheid}km/h");
            Console.ResetColor();
        }
        public virtual void Rem(int aantal)
        {
            Console.ForegroundColor = Kleur;
            Snelheid -= aantal;
            Console.WriteLine($"De auto remt naar {Snelheid}km/h");
            Console.ResetColor();
        }
    }
}
