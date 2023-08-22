using MathCalculationsConsoleApp.Helpers;
using MathCalculationsConsoleApp.Models.Base;


Console.WriteLine($"-----------------------------------");
Helper helpers = new Helper();
bool isContinue = true;

do
{
	try
	{
		helpers.StartInfo();

		BaseFigure figure = helpers.GetFigure();
		figure.InputInfo();
		figure.OutputInfo();

		helpers.ContinueInfo(ref isContinue);
	}
	catch (Exception ex)
	{
		Console.WriteLine($"Произошла ошибка: {ex.Message}");
        Console.WriteLine();
    }
} while (isContinue);

