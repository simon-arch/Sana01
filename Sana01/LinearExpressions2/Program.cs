class Program
{
    static void Main(string[] args)
    {
        double a, b, m, n, x;
        double z1, z2, y;

        while (true) {Console.Write("M: ");
            if (double.TryParse(Console.ReadLine(), out m)) break;
            else Console.WriteLine("Wrong input.");}
        
        while (true) {Console.Write("N: ");
            if (double.TryParse(Console.ReadLine(), out n)) break;
            else Console.WriteLine("Wrong input.");}

        z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
        z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        Console.WriteLine("z1 = {0}", z1);
        Console.WriteLine("z2 = {0}", z2);

        while (true) {Console.Write("\nX: ");
            if (double.TryParse(Console.ReadLine(), out x)) break;
            else Console.WriteLine("Wrong input.");}

        while (true) {Console.Write("A: ");
            if (double.TryParse(Console.ReadLine(), out a)) break;
            else Console.WriteLine("Wrong input.");}

        while (true) {Console.Write("B: ");
            if (double.TryParse(Console.ReadLine(), out b)) break;
            else Console.WriteLine("Wrong input.");}

        y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
        Console.WriteLine("y = {0}", y);
    }
}
