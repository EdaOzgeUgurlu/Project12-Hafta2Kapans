// Rastgele bir sayı üretip , ekrana yazdırınız.
Random rnd = new Random();  //Random sayı için random method kullanıyoruz
int sayi = rnd.Next(1, 101); //1 ile 100 arasında random sayı
Console.WriteLine("1-100 aralığında rastgele bir sayı: " + sayi);

