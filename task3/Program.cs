// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
System.Console.WriteLine("Введите чисо N");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"таблица кубов чисел от 1 до {n}: ");
for (int i = 1; i <= n; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)} ");
}
