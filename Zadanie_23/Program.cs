
Console.WriteLine("Введите число n  :");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;
for(index=1;index<=n;index++)
{
    Console.WriteLine(Math.Pow(index,3));
}
