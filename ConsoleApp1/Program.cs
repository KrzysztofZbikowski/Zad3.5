class Zad
{
    static void Main(string[] args)
    {
        double a, b, c, delta, x1, x2;
        Console.WriteLine("Dane jest równanie ax^2+bx+c=0");
        Console.WriteLine("Podaj a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj c:");
        c = double.Parse(Console.ReadLine());
        delta = Math.Pow(b, 2) - 4 * a * c;
        if(delta<0)
        {
            Console.WriteLine("brak pierwiastków równania kwadratowego");
        }
        else if (delta==0)
        {
            x1 = (-1*b) / (2 * a);
            Console.WriteLine("Pierwiastek równania kwadratowego wynosi {0}", x1);
        }
        else
        {
            x1 = (-1 * b) - Math.Sqrt(delta) / (2 * a);
            Console.WriteLine("Pierwiastek nr 1 równania kwadratowego wynosi {0}", x1);
            x2 = (-1 * b) + Math.Sqrt(delta) / (2 * a);
            Console.WriteLine("Pierwiastek nr 2 równania kwadratowego wynosi {0}", x2);
        }
        Console.ReadKey();
    }
}