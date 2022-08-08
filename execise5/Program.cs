//5 Показать число -N до N.
Console.Write("ввести число");
int a = int.Parse(Console.ReadLine());
int x = -a;

while(x<=a)
{
    Console.Write(x + "");
    x++;
}