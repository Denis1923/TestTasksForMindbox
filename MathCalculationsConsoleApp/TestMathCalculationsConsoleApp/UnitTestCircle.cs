using MathCalculationsConsoleApp.Models;

namespace TestMathCalculationsConsoleApp
{
	public class UnitTestCircle
	{
		[Test]
		public void TestSquare1()
		{
			Circle circle = new Circle(3);
			double testResult = Math.Round(circle.Square(), 1);
			Assert.AreEqual(5.4, testResult);
		}

		[Test]
		public void TestSquare2()
		{
			Circle circle = new Circle(5);
			double testResult = Math.Round(circle.Square(), 1);
			Assert.AreEqual(4.1, testResult);
		}
	}
}