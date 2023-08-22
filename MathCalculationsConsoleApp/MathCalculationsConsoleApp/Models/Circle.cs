using MathCalculationsConsoleApp.Models.Base;

namespace MathCalculationsConsoleApp.Models
{
	public class Circle : BaseFigure
	{
		private double _r;

        public Circle() { }

		public Circle(double r)
        {
            _r = r;
        }

        public override void InputInfo()
		{
			Console.Write($"Введите радиус круга: ");
			_r = Convert.ToDouble(Console.ReadLine());
        }

		public override void OutputInfo()
		{
			Console.WriteLine($"Площадь круга по радиусу = {Square()}");
            Console.WriteLine();
        }

		public override double Square() => Math.Sqrt(_r) * Math.PI;
	}
}
