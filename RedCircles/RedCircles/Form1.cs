using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedCircles
{
    public partial class Form1 : Form
    {
        Scene scene;
        bool gameStarted = false;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameStarted)
            {
                scene.Click(e.Location);
            }
            else // ako nemame kliknato start, da se dodava topcina
            {
                if(e.Button == MouseButtons.Left)
                {
                    scene.addBall(new Ball(e.Location));
                    
                }
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            gameStarted = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.PickRandomBallForDeletion();
            tsslPoints.Text = $"Points: {scene.Points}";

            if (scene.GameOver())
            {
                scene.PickRandomBallForDeletion();
                Invalidate();
                timer1.Stop();
                if(MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scene = new Scene();
                    gameStarted = false;
                }
                else
                {
                    this.Close();
                }
            }
            Invalidate();
        }

        public void saveToFile(String path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, scene);
            fs.Close();
        }

        public void loadFromFile(String path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = formatter.Deserialize(fs) as Scene;
            fs.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveToFile(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                loadFromFile(ofd.FileName);
            }
        }
    }
}
