using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vält ett av alternativen");
        Console.WriteLine("1. Är n ett primtal?");
        Console.WriteLine("2. Antalet primtal mindre än n");
        Console.WriteLine("3. Avsluta programmet");
        int val = int.Parse(Console.ReadLine());

        switch (val)
        {
            case 1:
                Console.WriteLine("Skriv in ett tal du vill undersöka");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(Primtal(x));
                break;

            case 2:
                Console.WriteLine("Skriv in ett heltal");
                int tal = int.Parse(Console.ReadLine());
                Console.WriteLine($"Antalet primtal mindre än {tal} är {Mindreän(tal)}");
                break;

            case 3:
                Console.WriteLine("Progammet avslutas");
                break;

        }


    }

    static bool Primtal(int x)
    {

        int delx = 0;
        for (int i = 2; i < x; i++)
        {
            if (x % i == 0)
            {
                delx++;
            }
        }
        if (delx == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //metod 2
    static bool Ärprimtal(int x)
    {
        
        for (int i = 2; i < x; i++)
        {
            if (x % i == 0)
            {
                return false;
            }
        }
        return true;

    }
    static int Mindreän(int y)
    {
        int antal = 0;

        for (int i = 2; i < y; i++)
        {
            if (Ärprimtal(i))
            {
                antal++;
            }
        }

        return antal;
    }
}
