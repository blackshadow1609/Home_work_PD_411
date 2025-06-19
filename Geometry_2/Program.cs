using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);

			Console.Clear();
			graphics.Clear(Color.White);

			List<Shape> shapes = new List<Shape>
		{
			new Square(5, Color.Red),
			new Rectangle(6, 4, Color.Blue),
			new Circle(3, Color.Green),
			new Triangle(4, 5, 3, Color.Purple)
		};

			// Меню
			Console.WriteLine("Выберите фигуру:");
			for (int i = 0; i < shapes.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {shapes[i].GetType().Name}");
			}

			int choice;
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > shapes.Count)
			{
				Console.WriteLine("Неверный ввод. Попробуйте снова.");
			}

			Shape selectedShape = shapes[choice - 1];
			selectedShape.Info();

			selectedShape.Draw(graphics, 400, 400);

			Console.WriteLine("\nНажмите любую клавишу для выхода...");
			Console.ReadKey();
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}