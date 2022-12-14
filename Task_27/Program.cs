
/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
	int array = Convert.ToString(number).Length;
	int count = 0;
	int summa = 0;

	for (int i = 0; i < array; i++)
	{
		count = number - number % 10;
		summa = summa + (number - count);
		number = number / 10;
	}
	return summa;
}

int sumNumber = Sum(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);