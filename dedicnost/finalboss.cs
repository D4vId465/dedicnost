public sealed class FinalBoss : Boss
{

    public int Pancir { get; private set;}

    public int PocetUtoku { get; private set; } = 0;

    public bool BojovyRezim { get; private set ; } = false;
    public FinalBoss(int id, string jmeno, int zivoty, int pancir) : base(id, jmeno, zivoty)
    {
        Pancir = pancir;
    }
        public override void Utoc()
    {
        PocetUtoku++;
        
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

    public void PrepniBojovyRezim()
    {
        BojovyRezim = !BojovyRezim;
        Console.WriteLine($"Final boss {(BojovyRezim ? "aktivuje" : "deaktivuje")} bojový režim!");
    }

    public int VypocitejPoskozeni(int zakladniPoskozeni)
    {
        int (zakladniposkozeni < 0)
        throw
    }

}