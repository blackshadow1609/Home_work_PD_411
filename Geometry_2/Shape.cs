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
	public abstract class Shape
	{
		public Color Color { get; set; }

		public abstract void Info();
		public abstract double GetArea();
		public abstract double GetPerimeter();
		public abstract void Draw(Graphics graphics, int x, int y);

		protected void PrintProperties()
		{
			Console.WriteLine($"Цвет: {Color.Name}");
			Console.WriteLine($"Площадь: {GetArea():F2}");
			Console.WriteLine($"Периметр: {GetPerimeter():F2}");
		}
	}
}

