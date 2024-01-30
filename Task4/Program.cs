int a = 5;
int b = 6;
int c = 98;
int d = 50;
int e = 40;

int max = a;
if (b > a)
{
    max = b;
}
if (c > b)
{
    max = c;
}
if (d > c)
{
    max = d;
}
if (e > d)
{
    max = e;
}
Console.WriteLine(max);