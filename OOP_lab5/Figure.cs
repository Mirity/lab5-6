using System;

namespace lab6
{
	abstract class Figure
	{
		public string ToStringFigure()
		{
			string result = "";
			for (int i = 0; i < _countSides; i++)
			{
				result += Convert.ToString(i) + " - " + "( ";
				result += Convert.ToString(_cords[i].x);
				result += ", ";
				result += Convert.ToString(_cords[i].y);
				result += " )\n";

			}
			result += "Area: " + Convert.ToString(Area()) + "\n" + "Perimeter: " + Convert.ToString(Perimeter()) + "\nCenter gravity: x(" + Convert.ToString(CenterGravity().x) +") " + "y: (" + Convert.ToString(CenterGravity().y) + ")\n";
			return result;
		}
		public void Move(string route, int scale)
		{
			switch (route)
			{
				case "right":
					for (int i = 0; i < _countSides; i++)
					{
						_cords[i].x += scale;
					}
					break;
				case "left":
					for (int i = 0; i < _countSides; i++)
					{
						_cords[i].x -= scale;
					}
					break;
				case "down":
					for (int i = 0; i < _countSides; i++)
					{
						_cords[i].y -= scale;
					}
					break;
				case "up":
					for (int i = 0; i < _countSides; i++)
					{
						_cords[i].y += scale;
					}
					break;
			}
		}
		public double Perimeter()
		{
			double per = 0;
			for (int i = 1; i < _countSides; i++)
			{
				per += GetLength(_cords[i], _cords[i - 1]);
			}
			per += GetLength(_cords[_countSides - 1], _cords[0]);
			return per;
		}
		abstract public double Area();
		abstract public Point CenterGravity();

		protected double GetLength(Point point1, Point point2)
		{
			double length = Math.Sqrt(Math.Abs(point1.x - point2.x) * Math.Abs(point1.x - point2.x) + Math.Abs(point1.y - point2.y) * Math.Abs(point1.y - point2.y));
			return length;
		}
		protected Point[] _cords;
		protected int _countSides = 0;
	}
}