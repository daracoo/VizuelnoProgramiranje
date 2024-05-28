using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes
{
    public class Scene
    {
        public List<Shape> Shapes {  get; set; } = new List<Shape>();
        Shape selectedShape = null;

        public Scene()
        {
            Shapes = new List<Shape>();
        }

        public void AddShape(Shape s)
        {
            Shapes.Add(s);

        } 

        public void Draw(Graphics g)
        {
            foreach (var shape in Shapes)
            {
                shape.Draw(g);
            }
        }

        public void Hit(Point location)
        {
            foreach (var shape in Shapes)
            {
                if(shape.Hit(location))
                    if(selectedShape == null)
                    {
                        selectedShape = shape;
                        shape.isSelected= !shape.isSelected;
                    }
                    else // veke imame selektirano forma
                    {
                        //selektiranata forma da se diselektira
                        selectedShape.isSelected = false;
                        selectedShape = shape;
                        selectedShape.isSelected = true;
                    }
            }
        }
    } 
}
