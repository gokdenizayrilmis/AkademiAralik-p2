﻿internal class Program
{
    private static void Main(string[] args)
    {

        //a = X karenin katsayısını giriniz.
        // b = x değerinin katsayısını veriniz.
        // c = sabit değeri giriniz.
        // delta = (b^2) - 4 * a * c
        // if(delta>0)
        // {
        //  kok1 = (-b + (d^1/2)) / 2a
        //  kok2 = (-b - (d^1/2)) / 2a
        // print kok1 , kok2
        // }
        //
        // else if (delta == 0)
        // {
        //  kok = (-b) / 2a
        //  print kokler esit
        //  print kok
        // }
        //
        //  else
        // {
        //  print reel kök yoktur.
        // }

        Console.Write("X karenin katsayisini giriniz: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("X degerinin katsayisini giriniz: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Sabit degeri giriniz: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = (Math.Pow(b, 2)) - 4 * a * c;

        if (delta > 0)
        {
            double kok1 = (-b + Math.Sqrt(delta)) / 2 * a;
            double kok2 = (-b - Math.Sqrt(delta)) / 2 * a;

            Console.WriteLine(kok1);
            Console.WriteLine(kok2);

        }

        else if (delta == 0)
        {

            double kok = (-b) / 2 * a;
            Console.WriteLine($"Kokler esittir ve {kok} degerindedir.");
        }

        else
        {
            Console.WriteLine("Reel kok yoktur.");

        }











        }
    }