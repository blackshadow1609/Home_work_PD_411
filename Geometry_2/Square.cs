using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Geometry_2
{
	public class Square : Shape
	{
		public double SideLength { get; }

		public Square(double sideLength, Color color)
		{
			SideLength = sideLength;
			Color = color;
		}

		public override void Info()
		{
			Console.WriteLine("=== Квадрат ===");
			Console.WriteLine($"Длина стороны: {SideLength}");
			PrintProperties();
		}

		public override double GetArea() => SideLength * SideLength;

		public override double GetPerimeter() => 4 * SideLength;

		public override void Draw(Graphics graphics, int x, int y)
		{
			using (var pen = new Pen(Color, 2))
			{
				graphics.DrawRectangle(pen, x, y, (float)SideLength * 10, (float)SideLength * 10);
			}
		}
	}
}

