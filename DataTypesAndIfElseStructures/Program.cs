using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== C# Console Uygulaması ===");
            Console.WriteLine("1 - Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme");
            Console.WriteLine("2 - Gün İsmi Belirleme");
            Console.WriteLine("3 - Basit Hesap Makinesi");
            Console.WriteLine("4 - Üç Sayının En Büyüğünü Bulma");
            Console.WriteLine("5 - Şifre Güçlülüğünü Kontrol Etme");
            Console.WriteLine("0 - Çıkış");
            Console.Write("Seçiminizi yapın: ");

            int secim;
            if (!int.TryParse(Console.ReadLine(), out secim))
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin!");
                continue;
            }

            switch (secim)
            {
                case 1: SayininDurumunuBelirle(); break;
                case 2: GunIsmiBelirle(); break;
                case 3: HesapMakinesi(); break;
                case 4: EnBuyukSayiyiBul(); break;
                case 5: SifreKontrolEt(); break;
                case 0: return;
                default: Console.WriteLine("Geçersiz seçim!"); break;
            }
        }
    }

    // 1. Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme
    static void SayininDurumunuBelirle()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 0)
            Console.WriteLine("Sayı pozitiftir.");
        else if (sayi < 0)
            Console.WriteLine("Sayı negatiftir.");
        else
            Console.WriteLine("Sayı sıfırdır.");
    }

    // 2. Gün İsmi Belirleme
    static void GunIsmiBelirle()
    {
        Console.Write("1-7 arasında bir sayı girin: ");
        int gun = Convert.ToInt32(Console.ReadLine());

        switch (gun)
        {
            case 1: Console.WriteLine("Pazartesi"); break;
            case 2: Console.WriteLine("Salı"); break;
            case 3: Console.WriteLine("Çarşamba"); break;
            case 4: Console.WriteLine("Perşembe"); break;
            case 5: Console.WriteLine("Cuma"); break;
            case 6: Console.WriteLine("Cumartesi"); break;
            case 7: Console.WriteLine("Pazar"); break;
            default: Console.WriteLine("Geçersiz giriş! 1-7 arasında bir sayı girin."); break;
        }
    }

    // 3. Basit Hesap Makinesi
    static void HesapMakinesi()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İşlem seçin (+, -, *, /): ");
        char islem = Convert.ToChar(Console.ReadLine());

        switch (islem)
        {
            case '+': Console.WriteLine($"Sonuç: {sayi1 + sayi2}"); break;
            case '-': Console.WriteLine($"Sonuç: {sayi1 - sayi2}"); break;
            case '*': Console.WriteLine($"Sonuç: {sayi1 * sayi2}"); break;
            case '/':
                if (sayi2 != 0)
                    Console.WriteLine($"Sonuç: {sayi1 / sayi2}");
                else
                    Console.WriteLine("Sıfıra bölme hatası!");
                break;
            default: Console.WriteLine("Geçersiz işlem!"); break;
        }
    }

    // 4. Üç Sayının En Büyüğünü Bulma
    static void EnBuyukSayiyiBul()
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü sayıyı girin: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        int enBuyuk;

        if (sayi1 >= sayi2 && sayi1 >= sayi3)
            enBuyuk = sayi1;
        else if (sayi2 >= sayi1 && sayi2 >= sayi3)
            enBuyuk = sayi2;
        else
            enBuyuk = sayi3;

        Console.WriteLine($"En büyük sayı: {enBuyuk}");
    }

    // 5. Şifre Güçlülüğünü Kontrol Etme
    static void SifreKontrolEt()
    {
        Console.Write("Şifre girin: ");
        string sifre = Console.ReadLine();

        if (sifre.Length >= 8 &&
            Regex.IsMatch(sifre, @"[A-Z]") &&
            Regex.IsMatch(sifre, @"[@#$%]"))
        {
            Console.WriteLine("Şifre güçlü.");
        }
        else
        {
            Console.WriteLine("Şifre zayıf! Şu kurallara dikkat edin:");
            Console.WriteLine("- En az 8 karakter uzunluğunda olmalı.");
            Console.WriteLine("- En az 1 büyük harf içermeli.");
            Console.WriteLine("- @, #, $, % gibi özel karakterlerden biri bulunmalı.");
        }
    }
}
