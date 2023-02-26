// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine()!);
int start_count = 2;
if (a <= 1) Console.WriteLine("Error enter correct number");
else
{
while(start_count <= a)
{
  Console.Write(start_count + " ");
  start_count = start_count + 2;
}}
