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
	public class Rectangle : Shape
	{
		public double Width { get; }
		public double Height { get; }

		public Rectangle(double width, double height, Color color)
		{
			Width = width;
			Height = height;
			Color = color;
		}

		public override void Info()
		{
			Console.WriteLine("=== Прямоугольник ===");
			Console.WriteLine($"Ширина: {Width}");
			Console.WriteLine($"Высота: {Height}");
			PrintProperties();
		}

		public override double GetArea() => Width * Height;

		public override double GetPerimeter() => 2 * (Width + Height);

		public override void Draw(Graphics graphics, int x, int y)
		{
			using (var pen = new Pen(Color, 2))
			{
				graphics.DrawRectangle(pen, x, y, (float)Width * 10, (float)Height * 10);
			}
		}
	}
}

