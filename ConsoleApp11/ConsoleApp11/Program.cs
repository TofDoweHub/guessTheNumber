using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number;
			int triesCount = 5;
			int numberUserInput;
			Random random = new Random();

			Console.WriteLine("Игра ,,Отгадай число``.");
			Console.WriteLine("Введите число от 1 до 10 включительно:");
			number = random.Next(1, 10);

			while (triesCount-- > 0)
			{
				numberUserInput = Convert.ToInt32(Console.ReadLine());
				if (numberUserInput == number)
				{
					Console.WriteLine("Поздравляем! Вы выиграли.");
					Console.ReadLine();
					break;
				}
				else if (numberUserInput != number)
				{
					Console.WriteLine("Вы ввели не то число! попробуйте ещё раз.");
					Console.WriteLine($"У вас осталось попыток: {triesCount}");
				}

				else
				{
					Console.WriteLine($"Увы, вы проиграли. Число было равно {number}.");
				}
			}
		}
	}
}
