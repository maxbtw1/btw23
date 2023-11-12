double x0, xn, xnp1, e, m;
m = 1.3;
e = 0.001;
x0 = 2.8;
xn = x0 - ((x0 * Math.Sin(x0) - 1) / (Math.Sin(x0) + x0 * Math.Cos(x0)));
Console.WriteLine(xn);
xnp1 = (Math.Abs(xn * Math.Sin(xn) - 1)) / m;
Console.WriteLine(xnp1);
int i = 0;
while (!(xnp1 < Math.Pow(10, -3)))
{
    xn = xn - ((xn * Math.Sin(xn) - 1) / (Math.Sin(xn) + xn * Math.Cos(xn)));
    xnp1 = (Math.Abs(xn * Math.Sin(xn) - 1)) / m;
    Console.WriteLine(xn);
    Console.WriteLine(i);
    Console.WriteLine();
    i++;
}
Console.WriteLine();
Console.WriteLine(xn);
Console.WriteLine(xnp1);