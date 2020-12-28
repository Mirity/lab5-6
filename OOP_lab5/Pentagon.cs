using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Pentagon : Figure
    {
        public Pentagon(Point[] cords)
        {
            _countSides = 5;
            _cords = new Point[_countSides];

            for (int i = 0; i < _countSides; i++)
            {
                _cords[i].x = cords[i].x;
                _cords[i].y = cords[i].y;
            }
        }
        public override double Area()
        {
            double area;
            double areaOfTriangle1 = AreaOfTriangle(_cords[0], _cords[1], _cords[2]);
            double areaOfTriangle2 = AreaOfTriangle(_cords[2], _cords[3], _cords[4]);
            double areaOfTriangle3 = AreaOfTriangle(_cords[0], _cords[4], _cords[2]);
            return area = areaOfTriangle1 + areaOfTriangle2 + areaOfTriangle3; ;
        }
        public override Point CenterGravity()
        {
            Point centerGravity;

            Point centerOfTriangle1 = CenterOfTriangle(_cords[0], _cords[1], _cords[2]);
            Point centerOfTriangle2 = CenterOfTriangle(_cords[2], _cords[3], _cords[4]);
            Point centerOfTriangle3 = CenterOfTriangle(_cords[0], _cords[4], _cords[2]);

            double areaOfTriangle1 = AreaOfTriangle(_cords[0], _cords[1], _cords[2]);
            double areaOfTriangle2 = AreaOfTriangle(_cords[2], _cords[3], _cords[4]);
            double areaOfTriangle3 = AreaOfTriangle(_cords[0], _cords[4], _cords[2]);

            centerGravity.x = (centerOfTriangle1.x * areaOfTriangle1 + centerOfTriangle2.x * areaOfTriangle2 + centerOfTriangle3.x * areaOfTriangle3) / (areaOfTriangle1 + areaOfTriangle2 + areaOfTriangle3);
            centerGravity.y = (centerOfTriangle1.y * areaOfTriangle1 + centerOfTriangle2.y * areaOfTriangle2 + centerOfTriangle3.y * areaOfTriangle3) / (areaOfTriangle1 + areaOfTriangle2 + areaOfTriangle3);

            return centerGravity;
        }
        protected Point CenterOfTriangle(Point a, Point b, Point c)
        {
            Point result;
            result.x = (a.x + b.x + c.x) / 3;
            result.y = (a.y + b.y + c.y) / 3;
            return result;
        }
        protected double AreaOfTriangle(Point a, Point b, Point c)
        {
            return Math.Abs(0.5 * ((a.x - c.x) * (b.y - c.y) - (a.y - c.y) * (b.x - c.x)));
        }
    }
}
