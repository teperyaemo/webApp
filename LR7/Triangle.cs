using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LR7
{
    class Triangle
    {
        private readonly Point[] _points = new Point[3];

        #region Properties
        public Point A
        {
            get { return _points[0]; }
            set { _points[0] = value; }
        }
        public Point B
        {
            get { return _points[1]; }
            set { _points[1] = value; }
        }
        public Point C
        {
            get { return _points[2]; }
            set { _points[2] = value; }
        }
        public double AB
        {
            get { return Math.Sqrt(Math.Pow(_points[0].X - _points[1].X, 2) + Math.Pow(_points[0].Y - _points[1].Y, 2)); }
        }

        public double BC
        {
            get { return Math.Sqrt(Math.Pow(_points[1].X - _points[2].X, 2) + Math.Pow(_points[1].Y - _points[2].Y, 2)); }
        }

        public double AC
        {
            get { return Math.Sqrt(Math.Pow(_points[0].X - _points[2].X, 2) + Math.Pow(_points[0].Y - _points[2].Y, 2)); }
        }

        public Point Center
        {
            get
            {
                return new Point((A.X + B.X + C.X) / 3,
                                 (A.Y + B.Y + C.Y) / 3);
            }
        }

        public double Perimeter
        {
            get { return AB + BC + AC; }
        }

        public double Square
        {
            get
            {
                double p = Perimeter / 2;
                double temp = p * (p - AB) * (p - BC) * (p - AC);
                return Math.Sqrt(temp);
            }
        }
        #endregion

        public Triangle(int Pos1_x, int Pos1_y, int Pos2_x, int Pos2_y, int Pos3_x, int Pos3_y)
        {
            Point a = new Point(Pos1_x, Pos1_y);
            Point b = new Point(Pos2_x, Pos2_y);
            Point c = new Point(Pos3_x, Pos3_y);
            _points[0] = a;
            _points[1] = b;
            _points[2] = c;


            if (AB >= BC + AC || AC >= BC + AB || BC >= AB + AC)
            {
                throw new ArgumentException("Недопустимый размер треугольника. Точки лежат на одной прямой или длина ребра равна нулю");
            }

        }

    }
}
