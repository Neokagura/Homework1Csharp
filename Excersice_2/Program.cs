// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Add a number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add a number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add a number");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(num > max)
{
    max = num;
}
if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}

Console.WriteLine("max = " + max);
