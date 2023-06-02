string CheckKoord(int x)
{
    int num5 = x % 10;
    int num4 = x / 10 % 10;
    int num2 = x / 1000 % 10;
    int num1 = x / 10000 % 10;

    string result = "";
    if (num5 == num1 && num4 == num2)
        result = "палиндром";
    else
        result = "не палиндром";
    return result;
}



System.Console.WriteLine("Введите пятизначное число");
int x = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"введеное число {CheckKoord(x)} ");



// int num5 = x % 10;
// int num4 = x / 10 % 10;
// int num2 = x / 1000 % 10;
// int num1 = x / 10000 % 10;
// if (num5 == num1 && num4 == num2)
// System.Console.WriteLine($"число {x} является палиндромом");
// else if (num5 != num1 || num4 != num2)
// System.Console.WriteLine($"число {x} не является палиндромом");


