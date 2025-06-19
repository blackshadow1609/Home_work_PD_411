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
	public class Circle : Shape
	{
		public double Radius { get; }

		public Circle(double radius, Color color)
		{
			Radius = radius;
			Color = color;
		}

		public override void Info()
		{
			Console.WriteLine("=== Круг ===");
			Console.WriteLine($"Радиус: {Radius}");
			PrintProperties();
		}

		public override double GetArea() => Math.PI * Radius * Radius;

		public override double GetPerimeter() => 2 * Math.PI * Radius;

		public override void Draw(Graphics graphics, int x, int y)
		{
			using (var pen = new Pen(Color, 2))
			{
				graphics.DrawEllipse(pen, x, y, (float)Radius * 20, (float)Radius * 20);
			}
		}
	}
}
