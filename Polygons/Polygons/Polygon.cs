using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    [Serializable]
    public class Polygon
    {
        public List<Point> Points { get; set; } //tocki

        public bool isCompleted { get; set; } = false;

        public Color Color { get; set; }

        public Polygon(Color color) {
            Points = new List<Point>();
            this.Color = color;
        
        }
        public Point Cursor { get; set; }

        public void addPoint(Point p)
        {
            if (nearStart())
            {
                Points.Add(Points[0]);
                isCompleted = true;
            }
            else
            {
                Points.Add(p);
            }

        }

        public bool nearStart() 
        {
            if(Points.Count >= 3)
            {
                return Math.Sqrt(Math.Pow(Points[0].X - Cursor.X, 2) + Math.Pow(Points[0].Y - Cursor.Y, 2)) < 10;
            }
            else
            {
                return false;
            }
        }

        public void Draw(Graphics g)
        {
            if(Points.Count >= 2)
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawLines(p, Points.ToArray());
                //g.DrawPolygon(p, Points.ToArray());
                p.Dispose();

                if(nearStart() && !isCompleted)
                {
                    p = new Pen(Color.Yellow, 2);
                    g.DrawEllipse(p, Points[0].X - 5, Points[0].Y - 5, 10, 10);
                }
            }

            if (isCompleted)
            {
                Brush b = new SolidBrush(Color);
                g.FillPolygon(b, Points.ToArray());
            }

        }

        public void MoveLeft()
        {
            for(int i=0;i<Points.Count;i++)
            {
                Points[i] = new Point(Points[i].X - 5, Points[i].Y);
            }
        }

        public void MoveRight()
        {
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new Point(Points[i].X + 5, Points[i].Y);
            }
        }
    }
}
