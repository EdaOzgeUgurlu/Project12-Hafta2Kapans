// Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

int sayi = new Random().Next(100);

Console.WriteLine($"Rastgele bir sayı: {sayi}");

int kalan = sayi % 3;

Console.WriteLine($"Rastgele sayının 3 ile bölümünden kalan: {kalan}");