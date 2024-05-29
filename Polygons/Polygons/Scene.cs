using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    [Serializable]
    public class Scene
    {
        public Polygon currentPolygon {  get; set; }
        public List<Polygon> completedPolygons { get; set; }
        public Color Color { get; set; } = Color.Blue;

        public Scene()
        {
            currentPolygon = new Polygon(Color);
            completedPolygons = new List<Polygon>();
        }


        public void addPoint(Point p)
        {
            currentPolygon.addPoint(p);
            if (currentPolygon.isCompleted)
            {
                completedPolygons.Add(currentPolygon);
                currentPolygon = new Polygon(Color);
            }
        }

        public void Draw(Graphics g)
        {
            currentPolygon.Draw(g);
            foreach(var item in completedPolygons)
            {
                item.Draw(g);
            }
         }

        public void updateColor(Color color)
        {
            this.Color = color;
            currentPolygon.Color = color;
        }
    }
}
