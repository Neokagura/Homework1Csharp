// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Add a number");
int N = Convert.ToInt32(Console.ReadLine());
int EvenN = 2;

while (EvenN<=N)
{
    Console.WriteLine(EvenN);
    EvenN = EvenN + 2;
}

