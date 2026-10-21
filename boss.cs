/// <summary>
/// Představuje silného nepřítele (Bosse) v počítačové hře.
/// Boss má jméno, počet životů a několik fází souboje.
/// Dokáže útočit, zastrašovat protivníka a měnit
/// své chování podle aktuální fáze.
/// </summary>
public class Boss : Postava
{
    /// <summary>
    /// Jméno bosse.
    /// </summary>
    // SEM DOPLŇ VLASTNOST


    /// <summary>
    /// Aktuální počet životů bosse.
    /// </summary>
    public int Zivoty { get; set; }

    public int aktualniZivoty { get; private set; } = 100;


    /// <summary>
    /// Aktuální fáze souboje.
    /// Výchozí hodnota je 1.
    /// </summary>
    public int Faze { get;private set; } = 1;


    /// <summary>
    /// Vytvoří nového bosse se zadaným jménem
    /// a počtem životů.
    /// </summary>
    /// <param name="jmeno">Jméno bosse.</param>
    /// <param name="zivoty">Počáteční počet životů.</param>
    /// <param name="zivoty">Počáteční počet životů.</param>
    public Boss(int id, string jmeno, int zivoty) : base(jmeno, id)
    {
        this.Zivoty = zivoty;
        this.aktualniZivoty = zivoty;
    }


    /// <summary>
    /// Provede útok podle aktuální fáze bosse.
    /// </summary>
    /// <remarks>
    /// Fáze 1: Boss útočí mečem.
    /// Fáze 2: Boss používá ohnivý útok.
    /// Fáze 3: Boss používá smrtící kouzlo.
    /// </remarks>
    public override void Utoc()
    {
        switch (Faze)
        {
            case 1:
                Console.WriteLine($"boss útočí mečem!");
                break;
            case 2:
                Console.WriteLine($"boss používá ohnivý útok!");
                break;
            case 3:
                Console.WriteLine($"boss používá smrtící kouzlo!");
                break;
            default:
                base.Utoc();
                break;
        }
    }


    /// <summary>
    /// Změní fázi bosse podle zbývajících životů.
    /// </summary>
    /// <remarks>
    /// Více než 50 % životů: fáze 1.
    /// 21–50 % životů: fáze 2.
    /// 20 % životů a méně: fáze 3.
    /// </remarks>
    public void ZmenFazi()
    {
        float procentaZivotu = (float)aktualniZivoty / Zivoty * 100;
        if (procentaZivotu > 50)
        {
            Faze = 1;
        }
        else if (procentaZivotu > 20 && procentaZivotu <= 50)
        {
            Faze = 2;
        }
        else
        {
            Faze = 3;
        }
    }


    /// <summary>
    /// Vypíše zastrašující hlášku bosse.
    /// </summary>
    public void Zastras()
    {
        Console.WriteLine("Boss: Připrav se na porážku!");

        float procentaZivotu = (float)aktualniZivoty / Zivoty * 100;
        if (procentaZivotu > 50)
        {
            Console.WriteLine("Boss: Jsem silný a nezastavitelný!");
        }
        else if (procentaZivotu > 20 && procentaZivotu <= 50)
        {
            Console.WriteLine("Boss: Jsem zraněný a používám ohnivý útok!");
        }
        else if (procentaZivotu > 0 && procentaZivotu <= 20)
        {
            Console.WriteLine("Boss: Jsem na pokraji smrti a používám smrtící kouzlo!");
        }
        else
        {
            Console.WriteLine("Boss: Jsem poražen! Vyhrál jsi!");
        }
    }


    /// <summary>
    /// Vypočítá poškození útoku podle aktuální fáze.
    /// </summary>
    /// <param name="zakladniPoskozeni">
    /// Základní hodnota poškození útoku.
    /// </param>
    /// <returns>
    /// Celkové poškození po zohlednění fáze bosse.
    /// </returns>
    // SEM DOPLŇ METODU
}