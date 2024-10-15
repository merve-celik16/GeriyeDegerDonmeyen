using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan isim ve soyisim alıyoruz
        Console.Write("İsminizi girin: ");
        string isim = Console.ReadLine();

        Console.Write("Soyisminizi girin: ");
        string soyisim = Console.ReadLine();

        // Metodu çağırıyoruz
        HosGeldiniz(isim, soyisim);
    }

    // Parametre alan ve geriye değer döndürmeyen metot
    static void HosGeldiniz(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}"); // İsim ve soyisim ekrana yazdırılır
    }
}
