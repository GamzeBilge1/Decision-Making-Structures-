
Console.Write("Lütfen bir sayı giriniz: ");

int number = int.Parse(Console.ReadLine());

if (number < 10)
{
    Console.WriteLine("Girilen sayı 10 dan küçüktür.");
   
}

else if (number > 10)
{
    Console.WriteLine("Girilen sayı 10 dan büyüktür.");
   
}

else
{
    Console.WriteLine("Girilen sayı 10 a eşittir.");
  

}

if (number % 2 == 0)
{
    Console.WriteLine("Girilen sayı çifttir.");
}
else
{
    Console.WriteLine("Girilen sayı tektir.");
}