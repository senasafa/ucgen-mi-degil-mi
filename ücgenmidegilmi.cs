using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int sayı1, sayı2, sayı3;

        Console.WriteLine("1.sayı");
        sayı1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2.sayı");
        sayı2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("3.sayı");
        sayı3 = Convert.ToInt32(Console.ReadLine());

        int toplam;
        toplam = sayı1 + sayı2 + sayı3;
        Console.WriteLine("toplam: ");
        Console.Write(toplam);

        Console.ReadLine();

        if (toplam < 180)
        {
            Console.WriteLine("üçgen değil");



        }
        else if (toplam > 180) ;
        {



            Console.WriteLine("ücgen degil");

        }

else
        {
            Console.WriteLine("üçgen");



        }
    }
}
