using System.Runtime.CompilerServices;

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

public class PosisiKarakter
{
    private POSISI awal;

    public PosisiKarakter()
    {
        awal = POSISI.BERDIRI;
    }

    TriggerKarakter[] transisi =
    {
            new TriggerKarakter(POSISI.JONGKOK, POSISI.BERDIRI, TRIGGER_POS.TOMBOL_W),
            new TriggerKarakter(POSISI.BERDIRI, POSISI.TERBANG, TRIGGER_POS.TOMBOL_W),
            new TriggerKarakter(POSISI.TENGKURAP, POSISI.JONGKOK, TRIGGER_POS.TOMBOL_W),
            new TriggerKarakter(POSISI.JONGKOK, POSISI.TENGKURAP, TRIGGER_POS.TOMBOL_S),
            new TriggerKarakter(POSISI.BERDIRI, POSISI.JONGKOK, TRIGGER_POS.TOMBOL_S),
            new TriggerKarakter(POSISI.TERBANG, POSISI.BERDIRI, TRIGGER_POS.TOMBOL_S),
            new TriggerKarakter(POSISI.TERBANG, POSISI.JONGKOK, TRIGGER_POS.TOMBOL_X)
    };

    public POSISI getNextPos(POSISI posAwal, TRIGGER_POS trigger)
    {
        POSISI posAkhir = posAwal;
        for(int i = 0; i < transisi.Length; i++)
        {
            TriggerKarakter perubahan = transisi[i];
            if(posAwal == perubahan.posAwal && trigger == perubahan.posTrigger)
            {
                posAkhir = perubahan.posAkhir;
            }
        }
        return posAkhir;
    }

    public void aktivasi(TRIGGER_POS triggerPos)
    {
        awal = getNextPos(awal, triggerPos);
        awal = getNextPos(awal, triggerPos);
    }
}

public class TriggerKarakter
{
    public POSISI posAwal;
    public POSISI posAkhir;
    public TRIGGER_POS posTrigger;

    public TriggerKarakter(POSISI posAwal, POSISI posAkhir, TRIGGER_POS posTrigger)
    {
        this.posAwal = posAwal;
        this.posAkhir = posAkhir;
        this.posTrigger = posTrigger;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}