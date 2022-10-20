Console.Write("Введи число: ");
int Number = int.Parse(Console.ReadLine());
string anyNumber = Convert.ToString(Number);
if (anyNumber.Length > 2)
{
    Console.WriteLine("Третья цифра - " + anyNumber[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}