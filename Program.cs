public enum BUAH
{
    APEL,
    APRIKOT,
    ALPUKAT,
    PISANG,
    PAPRIKA,
    KURMA,
    DURIAN,
    ANGGUR,
    MELON,
    SEMANGKA,
}

public enum POSISI
{
    JONGKOK,
    TENGKURAP,
    BERDIRI,
    TERBANG,
}

public enum TRIGGER_POS
{
    TOMBOL_W,
    TOMBOL_S,
    TOMBOL_X,
}

public class KodeBuah
{
    private string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "K00", "L00", "M00", "N00", "O00" };
    
    public string getKodeBuah(BUAH buah)
    {
        return kodeBuah[(int)buah];
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}