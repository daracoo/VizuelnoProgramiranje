using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCircles
{
    [Serializable]
    public class Scene
    {
       public List<Ball> Balls {  get; set; }
        public int Points { get; set; } = 0;
        public Random Random { get; set; } = new Random();
        public Ball MarkedForDeletion { get; set; }

        public Scene() {
            Balls = new List<Ball>();
        }

        public void addBall(Ball b)
        {
            foreach (Ball ball in Balls)
            {
                if (ball.Overlap(b))//onevozmozuva da se dodava edno topce vrz drugo 
                {
                    return;
                }
            }
            Balls.Add(b);
        }

        public void Draw(Graphics g)
        {
            foreach (var ball in Balls)
            {
                ball.Draw(g);
            }
        }

        internal void Click(Point location)
        {
            foreach (Ball b in Balls)
            {
                if (b.isHit(location) && !b.MarkedForDeletion)
                {
                    b.Saved = true;
                    Points += 5;
                    return;
                }
            }
        }

        public bool GameOver()
        {
            foreach (Ball b in Balls)
            {
                if (!b.Saved)
                {
                    return false;
                }
            }
            return true;
        }
        internal void PickRandomBallForDeletion()
        {
            if(MarkedForDeletion != null)
            {
                Balls.Remove(MarkedForDeletion);
            }
            if(Balls.Count > 0 && !GameOver())
            {
                Ball selected = Balls[Random.Next(0, Balls.Count)];
                while (selected.Saved && selected.MarkedForDeletion)
                {
                    selected = Balls[Random.Next(0, Balls.Count)];
                }
                selected.MarkedForDeletion = true;
                MarkedForDeletion = selected;
                Points -= 10;
            }
        }
    }
}
