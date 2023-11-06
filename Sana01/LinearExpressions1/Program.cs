class Program
{
    static void Main(string[] args)
    {
        double a, b, c, d;
        double x, y, z, r;

        while (true) {Console.Write("A: ");
            if (double.TryParse(Console.ReadLine(), out a)) break;
            else Console.WriteLine("Wrong input.");}
        
        while (true) {Console.Write("B: ");
            if (double.TryParse(Console.ReadLine(), out b)) break;
            else Console.WriteLine("Wrong input.");}

        while (true) {Console.Write("C: ");
            if (double.TryParse(Console.ReadLine(), out c)) break;
            else Console.WriteLine("Wrong input.");}

        while (true) {Console.Write("D: ");
            if (double.TryParse(Console.ReadLine(), out d)) break;
            else Console.WriteLine("Wrong input.");}

        x = (a + 2 * b - c + d) / c * d + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
        y = 5 * (a + b) * (c - d) / (1 / 2.0 * c) + (Math.Pow(d, 2)) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
        z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
        r = (1 / 2.0 * a + 3 / 4.0 * b - 7 / 5.0) / (3 * c + 1) + (1 / (a - c));

        Console.Write("\nx = "); Console.WriteLine(x);
        Console.Write("y = "); Console.WriteLine(y);
        Console.Write("z = "); Console.WriteLine(z);
        Console.Write("r = "); Console.WriteLine(r);
    }
}
