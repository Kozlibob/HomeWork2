Console.WriteLine("Введите число - ");
int number = int.Parse(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Это выходной день");
}
else if (number >= 1 && number <= 5)
{
    Console.WriteLine("Это будний день");
}
else if (number < 1 || number > 7)
{
    Console.WriteLine("Это не день недели");
}