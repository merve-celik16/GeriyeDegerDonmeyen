using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan iki sayı alıyoruz
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        // Metodu çağırıyoruz ve sonucu yazdırıyoruz
        int carpimSonucu = Carp(sayi1, sayi2);
        Console.WriteLine($"Girdiğiniz sayıların çarpımı: {carpimSonucu}");
    }

    // Parametre alan ve geriye değer döndüren metot
    static int Carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2; // İki sayının çarpımını döndür
    }
}
