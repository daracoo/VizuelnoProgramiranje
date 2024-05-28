using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingShapes
{
    public partial class Form1 : Form
    {
        public String ShapeType { get; set; } = "CIRCLE";
        public Scene scene { get; set; }
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = true;
            ShapeType = "SQUARE";
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = true;
            squareToolStripMenuItem.Checked = false;
            ShapeType = "CIRCLE";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (ShapeType.Equals("CIRCLE"))
                {
                    scene.AddShape(new Circle(Color.Red, e.Location, 20));
                }
                else
                {
                    scene.AddShape(new Square(Color.Red, e.Location, 40));
                }  
            }
            else
            {
                scene.Hit(e.Location);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }
    }
}
