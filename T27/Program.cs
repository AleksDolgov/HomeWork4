/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int GetNumber(string message)
{
    int result=0;
while(true)
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out result))
    {
        break;
    }
    else
    Console.Clear();
    Console.WriteLine("Вы ввели не число. Введите число:");
}
    return result;
}
int number=GetNumber("Введите число:");
int result=0;
while(number>0)
{
    result = result +  number%10;
    number = number/10;
}
Console.WriteLine($"Сумма цифр введенного числа равна {result}");