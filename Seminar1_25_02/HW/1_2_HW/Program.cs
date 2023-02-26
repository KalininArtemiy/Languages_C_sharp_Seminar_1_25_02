// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine())!;
int b = int.Parse(Console.ReadLine())!;
int c = int.Parse(Console.ReadLine())!;
int max = a;
if (a > b)
{
  max = a;
}
else max = b;
if (max > c)
{
  Console.WriteLine("Max is " + max);
}
else Console.WriteLine("Max is " + c);