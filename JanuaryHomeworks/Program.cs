#region Ocak 1.Hafta Ödevleri
// 3️-) Kullanıcıdan adını alıp ekrana yazdıran basit bir C# programı yazın

Console.Write("Adınızı giriniz: ");
string ad = Console.ReadLine();
Console.WriteLine($"Adınız: {ad}");

#endregion

#region Ocak 2.Hafta Ödevleri

// 3️-) Kullanıcıdan iki sayı alıp toplamını ekrana yazdıran bir program yazın.

Console.Write("Birinci sayıyı girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı girin: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Toplam: " + (sayi1 + sayi2));

#endregion

#region Ocak 3.Hafta Ödevleri 
// Koşullu ifadeler(if-else) ne işe yarar? Gerçek hayattan bir örnek verin.


#endregion

#region Ocak 4.Hafta Ödevleri
// 2-) 1’den 10’a kadar olan sayıları ekrana yazdıran bir for döngüsü yazın.

for (int i = 1; i <= 10; i++)
    Console.WriteLine(i);

// 3-) Kullanıcıdan alınan bir sayıya kadar olan sayıların toplamını hesaplayan bir program yazın.

Console.Write("Bir sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 0;

for (int i = 1; i <= sayi; i++)
{
    toplam += i;
}

Console.WriteLine($"1'den {sayi}'e kadar olan sayıların toplamı: {toplam}");
#endregion