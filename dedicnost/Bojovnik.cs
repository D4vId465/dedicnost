namespace Dedicnost
{

    /// <summary>
    /// Bojovník je třída, která dědí z třídy Postava a přidává specifické vlastnosti a metody pro bojovníka, jako je zbraň a schopnost zvednout štít.
    /// </summary>
    class Bojovnik : Postava
    {

        /// <summary>
        /// obsahuje zvolenou zbraň bojovníka, která je použita při útoku.
        /// </summary>
        private string zbran;

        /// <summary>
        /// vytvoří nového bojovníka
        /// </summary>
        /// <param name="id">Jednoznačný identifikátor bojovníka</param>
        /// <param name="jmeno">Jméno bojovníka</param>
        /// <param name="zbran">Zbraň bojovníka</param>
        public Bojovnik(int id, string jmeno, string zbran) : base(jmeno, id)
        {
            this.zbran = zbran;
        }
        public void ZvedniStit()
        {
            Console.WriteLine("Bojovník zvedá štít a brání se...");
        }
        public override void Utoc()
        {
            Console.WriteLine("útočím s " + zbran + "!");
        }
    }
}