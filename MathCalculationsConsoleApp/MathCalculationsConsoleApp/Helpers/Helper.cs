using MathCalculationsConsoleApp.Assets;
using MathCalculationsConsoleApp.Models;
using MathCalculationsConsoleApp.Models.Base;

namespace MathCalculationsConsoleApp.Helpers
{
	public class Helper
	{
		private FigureEnum _figure;

		public BaseFigure GetFigure()
		{
			switch (_figure) {
				case FigureEnum.Circle: 
					return new Circle();
				case FigureEnum.Triangle:
					return new Triangle();
				default:
					throw new Exception("Указана не верная цифра, повторите попытку \n");
			}
		}

		public void StartInfo()
		{
			Console.WriteLine($"Выберите фигуру для расчета площади");
			Console.WriteLine($"Цифра 1: Площадь круга по радиусу");
			Console.WriteLine($"Цифра 2: Площадь треугольника по трем сторонам");

			Console.Write($"Укажите цифру: ");
			_figure = (FigureEnum)Convert.ToInt32(Console.ReadLine());
		}

		public void ContinueInfo(ref bool isContinue)
		{
			Console.WriteLine($"Продолжить вычисление?");
			bool isEnter;

			do
			{
				Console.Write($"Введите да или нет: ");
				string continueCalc = Console.ReadLine()?.ToLower();

				isEnter = false;
				switch (continueCalc)
				{
					case "да":
						isContinue = true;
						break;
					case "нет":
						isContinue = false;
						break;
					default:
						isEnter = true;
						Console.WriteLine($"Не верно указали ключевое слово продолжения, повторите.");
						break;
				}

			} while (isEnter);

			Console.WriteLine();
		}
    }
}
