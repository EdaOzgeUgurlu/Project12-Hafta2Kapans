int yasi;
Console.Write(  "Yaşınız : ");
yasi = Convert.ToInt32(Console.ReadLine());

#region yöntem 1

if (yasi >= 18 )
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}

#endregion

Console.WriteLine( "-----------------------------------------------------------");

#region yöntem 2


Console.WriteLine(yasi >= 18 ? "+" : "-");


#endregion