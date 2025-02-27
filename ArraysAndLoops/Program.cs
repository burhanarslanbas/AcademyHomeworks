
using System.Diagnostics.Metrics;

while (true)
{
    //1 - For döngüsü ile sayının rakamlarının toplamını bulan algoritmayı yazınız.
    //2 -  while döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritmayı yazınız(Kullanıcıdan 10 ile 100 arasında bir sayı al ve eğer bu aralık dışında girerse tekrar iste.)
    //3 -  foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritmayı yazınız.(0 - 12: Çocuk, 13 - 19: Genç, 20 - 64: Yetişkin, 65 +: Yaşlı.)
    //4 - Bir dizide tekrar eden elemanları bulan algoritmayı yazınız.
    //5 - Bir dizide en uzun ve en kısa kelimeyi bulan algoritmayı yazınız.
    //6 - Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritmayı yazınız.
    //7 - Bir string dizisinin boyutunu dinamik olarak genişleten algoritmayı yazınız.
    //8 - Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran algoritmayı yazınız.
    //9 - Kullanıcıdan ratgele sayılar alıp listeye ekleyen,bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritmayı yazınız.
    //10 - Bir sayı listesinde 10’dan küçük olanları silen algoritmayı yazınız.
    //11 - Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.

    Console.WriteLine("\n=== .Net React Ödev 2 ===");
    Console.WriteLine("1 - Sayının Rakamları Toplamı");
    Console.WriteLine("2 - Belirli Şartlara Uyan Değeri Alan Program");
    Console.WriteLine("3 - Yaş Kategorisi Belirleyen Program");
    Console.WriteLine("4 - Dizide Tekrar Eden Elemanları Bulan Program");
    Console.WriteLine("5 - Dizide En Uzun ve En Kısa Kelimeyi Bulan Program");
    Console.WriteLine("6 - Cümleyi Diziye Kaydeden ve Alfabetik Sıralayan Program");
    Console.WriteLine("7 - String Dizisinin Boyutunu Dinamik Olarak Genişleten Program");
    Console.WriteLine("8 - Kullanıcının Girdiği Kelimeleri Listeye Kaydeden ve Tersten Yazdıran Program");
    Console.WriteLine("9 - Kullanıcının Girdiği Sayıları Listeye Ekleyen ve Ortalamasını Alan ve Sıralayan Program");
    Console.WriteLine("10 - Sayı Listesinde 10’dan Küçük Olanları Silen Program");
    Console.WriteLine("11 - Öğrenci Notlarını Güncelleyen Program");
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
        case 1: SayininRakamlariToplami(); break;
        case 2: SartiSaglayanDegeriAl(); break;
        case 3: YasKategorisiBelirle(); break;
        case 4: TekrarEdenElemanlarıBul(); break;
        case 5: EnUzunVeEnKisaKelimeyiBul(); break;
        case 6: CumleyiDiziyeKaydetVeSirala(); break;
        case 7: StringDizisininBoyutunuGenislet(); break;
        case 8: KelimeleriListeyeKaydetVeTerstenYazdir(); break;
        case 9: SayilariListeyeEkleOrtalamasiniAlVeSirala(); break;
        case 10: OndanKucukOlanlariSil(); break;
        case 11: OgrenciNotlariniGuncelle(); break;
        case 0: return;
        default: Console.WriteLine("Geçersiz seçim!"); break;
    }
}

// Generic listedeki tüm elemanları yazdıran metot
static void Listele<T>(List<T> liste)
{
    foreach (T eleman in liste)
    {
        Console.Write(eleman + " ");
    }
    Console.WriteLine();
}

void OgrenciNotlariniGuncelle()
{
    // Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.
    List<int> notlar = new List<int> { 15, 25, 30, 45, 60, 75, 30, 85, 40, 55, 90, 25, 80 };
    Console.Write("Öğrenci Notları:");
    Listele(notlar);
    foreach (int not in notlar.ToList()) // ToList kullanılmadığında hata veriyor. Hata açıklamasında koleksiyonun değiştiği belirtiliyor.
    {
        if (not < 50)
        {
            int index = notlar.IndexOf(not);
            notlar[index] = 50;
        }
    }
    Console.WriteLine("50 altı notlar 50 olarak güncellenmiş öğrenci notları:");
    Listele(notlar);

    // NOT: lambda ifadesi ile de yapılabilir
    // notlar.ForEach(not => { if (not < 50) not = 50; });
}

void OndanKucukOlanlariSil()
{
    List<int> sayilar = new List<int> { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
    Listele(sayilar);
    sayilar.RemoveAll(sayi => sayi < 10);
    Listele(sayilar);
}

void SayilariListeyeEkleOrtalamasiniAlVeSirala()
{
    List<int> sayilar = new List<int>();
    while (true)
    {
        Console.Write("Lütfen bir sayı girin (Çıkmak için 0'a basın): ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi == 0)
        {
            break;
        }
        sayilar.Add(sayi);
    }
    Listele(sayilar);
    double ortalama = sayilar.Average();
    Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
    // Küçükten büyüğe sıralama
    sayilar.Sort();
    Listele(sayilar);
}

void KelimeleriListeyeKaydetVeTerstenYazdir()
{
    List<string> kelimeler = new List<string>();
    while (true)
    {
        Console.Write("Lütfen bir kelime girin (Çıkmak için 'exit' yazın): ");
        string kelime = Console.ReadLine();
        if (kelime.ToLower() == "exit")
        {
            break;
        }
        kelimeler.Add(kelime);
    }
    // Kelimeleri tersine çeviren algoritma
    foreach (string kelime in kelimeler.ToList())
    {
        char[] karakterler = kelime.ToCharArray();
        Array.Reverse(karakterler);
        kelimeler[kelimeler.IndexOf(kelime)] = new string(karakterler);
    }
    Listele(kelimeler);
}

void StringDizisininBoyutunuGenislet()
{
    string[] isimler = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet" };
    Console.WriteLine("Dizi boyutu: " + isimler.Length);
    Array.Resize(ref isimler, isimler.Length + 1);
    isimler[isimler.Length - 1] = "Ahmet";
    Console.WriteLine("Dizi boyutu: " + isimler.Length);
}

void CumleyiDiziyeKaydetVeSirala()
{
    Console.Write("Lütfen bir cümle girin: ");
    string cumle = Console.ReadLine();
    string[] kelimeler = cumle.Split(' ');
    Array.Sort(kelimeler);
    Listele(kelimeler.ToList());
}

void EnUzunVeEnKisaKelimeyiBul()
{
    string[] kelimeler = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet", "Muhammet", "Arda" };
    string enUzunKelime = kelimeler[0];
    string enKisaKelime = kelimeler[0];
    foreach (string kelime in kelimeler)
    {
        if (kelime.Length > enUzunKelime.Length)
        {
            enUzunKelime = kelime;
        }
        if (kelime.Length < enKisaKelime.Length)
        {
            enKisaKelime = kelime;
        }
    }
    Console.WriteLine($"En uzun kelime: {enUzunKelime}\nEn kısa kelime: {enKisaKelime}");
}

void TekrarEdenElemanlarıBul()
{
    string[] kelimeler = { "Ali", "Veli", "Ayşe", "Fatma", "Ali", "Mehmet", "Mehmet", "Muhammet", "Arda" };
    List<string> tekrarEdenler = new List<string>();
    foreach (string kelime in kelimeler)
    {
        // Eğer kelime listede 1'den fazla varsa ve daha önce tekrarEdenler listesine eklenmemişse ekle
        if (kelimeler.Count(k => k == kelime) > 1 && !tekrarEdenler.Contains(kelime))
        {
            tekrarEdenler.Add(kelime);
        }
    }
    Listele(tekrarEdenler);
}

void YasKategorisiBelirle()
{
    byte[] yaslar = { 5, 45, 34, 12, 26, 15, 25, 58, 75, 85 };
    foreach (byte yas in yaslar)
    {
        if (yas >= 0 && yas <= 12)
            Console.WriteLine(yas + " yaşındaki kişi bir çocuktur.");
        else if (yas >= 13 && yas <= 19)
            Console.WriteLine(yas + " yaşındaki kişi bir gençtir.");
        else if (yas >= 20 && yas <= 64)
            Console.WriteLine(yas + " yaşındaki kişi bir yetişkindir.");
        else
            Console.WriteLine(yas + " yaşındaki kişi bir yaşlıdır.");
    }
}

void SartiSaglayanDegeriAl()
{
    while (true)
    {
        Console.Write("Lütfen 10 ile 100 arasında bir sayı giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi >= 10 && sayi <= 100)
        {
            Console.WriteLine($"Doğru giriş! Girilen sayı: {sayi}");
            break;
        }
        else
        {
            Console.WriteLine("Hatalı giriş! Girilen sayı 10 ile 100 arasında değil!");
        }
    }
}

void SayininRakamlariToplami()
{
    Console.Write("Bir sayı girin: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    byte basamakSayisi = (byte)sayi.ToString().Length;
    int rakamlarToplami = 0;
    for (int i = 0; i < basamakSayisi; i++)
    {
        rakamlarToplami += sayi % 10;
        sayi /= 10;
    }
    Console.WriteLine($"Girilen sayının rakamları toplamı: {rakamlarToplami}");
}