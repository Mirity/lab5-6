using System;


namespace lab6
{
    class Factory
    {
        public Figure createFigure(Point[] cords, int count)
        {

            if (count == 4)
                return new Rectangle(cords);
            else
                return new Pentagon(cords);
        }
    }
}
