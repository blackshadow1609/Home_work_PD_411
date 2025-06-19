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
	public class Triangle : Shape
	{
		public double SideA { get; }
		public double SideB { get; }
		public double SideC { get; }

		public Triangle(double sideA, double sideB, double sideC, Color color)
		{
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
			Color = color;
		}

		public override void Info()
		{
			Console.WriteLine("=== Треугольник ===");
			Console.WriteLine($"Сторона A: {SideA}");
			Console.WriteLine($"Сторона B: {SideB}");
			Console.WriteLine($"Сторона C: {SideC}");
			PrintProperties();
		}

		public override double GetArea()
		{
			// Формула Герона
			double p = GetPerimeter() / 2;
			return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
		}

		public override double GetPerimeter() => SideA + SideB + SideC;

		public override void Draw(Graphics graphics, int x, int y)
		{
			PointF[] points = {
			new PointF(x, y + (float)SideA * 10),
			new PointF(x + (float)SideB * 10, y + (float)SideA * 10),
			new PointF(x + (float)SideB * 5, y)
		};

			using (var pen = new Pen(Color, 2))
			{
				graphics.DrawPolygon(pen, points);
			}
		}
	}
}

