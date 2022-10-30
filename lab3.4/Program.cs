double y=0, x_start = -1, x_end = 1.5, h = 0.2;
for (double x = x_start; x <= x_end; x += h) {
    if (x > 1)
    {
        y = Math.Sqrt(Math.Tan(x * x - 1));
    }
    else if (x <= 0 && x <= 1)
    {
        y = -2*x;
    }
    else
    {
        Math.Exp(Math.Cos(x));
    }
    Console.WriteLine($"Для х = {x}, y = {y}");
}