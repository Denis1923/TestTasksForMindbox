using MathCalculationsConsoleApp.Models;

namespace TestMathCalculationsConsoleApp
{
	public class UnitTestTriangle
	{
		[Test]
		public void TestSquare1()
		{
			Triangle triangle = new Triangle(3, 4, 5);
			double testResult = triangle.Square();

			Assert.AreEqual(6, testResult);
		}

		[Test]
		public void TestSquare2()
		{
			Triangle triangle = new Triangle(5, 6, 7);
			double testResult = triangle.Square();

			Assert.AreEqual(4, testResult);
		}

		[Test]
		public void TestIsRectangular1()
		{
			Triangle triangle = new Triangle(3, 4, 5);
			bool testResult = triangle.IsRectangular();

			Assert.AreEqual(true, testResult);
		}

		[Test]
		public void TestIsRectangular2()
		{
			Triangle triangle = new Triangle(5, 6, 7);
			bool testResult = triangle.IsRectangular();

			Assert.AreEqual(true, testResult);
		}
	}
}
