Console.WriteLine("İKİ SAYI GİRİN");
int a=Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

double Toplam(double a, double b)
{
    return a + b;
}

Console.WriteLine( $" İki sayının toplamı: {Toplam (a,b)}");