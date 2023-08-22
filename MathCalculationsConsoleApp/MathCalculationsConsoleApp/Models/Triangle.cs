using MathCalculationsConsoleApp.Models.Base;
using System;

namespace MathCalculationsConsoleApp.Models
{
	public class Triangle : BaseFigure
	{
		private double _p;
		private double _a;
		private double _b;
		private double _c;

		public Triangle() { }

		public Triangle(double a, double b, double c)
        {
            _a = a;
			_b = b;
			_c = c;
        }

        public override void InputInfo()
		{
			Console.Write($"Введите стророну треугольника. А: ");
			_a = Convert.ToDouble(Console.ReadLine());

			Console.Write($"Введите стророну треугольника. B: ");
			_b = Convert.ToDouble(Console.ReadLine());

			Console.Write($"Введите стророну треугольника. C: ");
			_c = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine();
		}

		public override void OutputInfo()
		{
			Console.WriteLine($"Площадь треугольника по трем сторонам: {Square()}");

			if (IsRectangular())
				Console.WriteLine($"Треугольник является прямоугольным");
			else
				Console.WriteLine($"Треугольник не является прямоугольным");

            Console.WriteLine();
        }

		public override double Square()
		{
			_p = GetPerimeter();

			return Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p - _c));
		}

		private double GetPerimeter() => (_a + _b + _c) / 2;

		public bool IsRectangular() => Math.Pow(_a, 2) + Math.Pow(_b, 2) == Math.Pow(_c, 2);
	}
}
