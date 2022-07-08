/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int GetNumber(string message)
{
int resalt=0;
while(true)
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out resalt))
    {
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Вы ввели не число. Введите число:");
    }
}
return resalt;
}

int firstNumber=GetNumber("Введите первое число:");
int secondNumber=GetNumber("Введите второе число:");
int result=firstNumber;

for(int i=1;i<secondNumber; i++)
{
    result=result*firstNumber;
}

Console.WriteLine($"{result}");