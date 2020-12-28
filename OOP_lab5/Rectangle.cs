using System;


namespace lab6
{
    class Rectangle : Figure
    {
        public Rectangle(Point[] cords)
        {
            _countSides = 4;
            _cords = new Point[_countSides];

            for(int i=0;i<_countSides;i++)
            {
                _cords[i].x = cords[i].x;
                _cords[i].y = cords[i].y;
            }
        }
       public override double Area()
        {
          return GetLength(_cords[0], _cords[1]) * GetLength(_cords[1], _cords[2]);
        }
        public override Point CenterGravity()
        {
            Point centerGravity;

            centerGravity.x = _cords[0].x + (_cords[1].x - _cords[0].x) / 2;
            centerGravity.y = _cords[0].y + (_cords[3].y - _cords[0].y) / 2;

            return centerGravity;
        }

    }
}
