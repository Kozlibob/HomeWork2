Console.WriteLine("Введите трехзначное число -");
int i = int.Parse(Console.ReadLine());
if (i < 999 && i > 99)
{
    int secondNumber = i / 10 % 10;
    Console.WriteLine(secondNumber);
}
else Console.WriteLine("Введенное чиcло не трехзначное");