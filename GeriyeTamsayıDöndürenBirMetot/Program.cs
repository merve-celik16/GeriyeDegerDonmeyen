class Program
{
    static void Main()
    {
        // Metodu çağırıyoruz ve sonucu yazdırıyoruz
        int kalan = RastgeleSayininKalaniniBul();
        Console.WriteLine("Rastgele sayının 2'ye bölümünden kalan: " + kalan);
    }

    // Geriye tamsayı döndüren metot
    static int RastgeleSayininKalaniniBul()
    {
        Random random = new Random(); // Rastgele sayı üretmek için
        int rastgeleSayi = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı üret
        Console.WriteLine("Üretilen rastgele sayı: " + rastgeleSayi);

        return rastgeleSayi % 2; // 2'ye bölümünden kalanı döndür
    }
}