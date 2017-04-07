using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDots
{
    public class ThreeDotsModel
    {
        public List<Dot> Dots { get; }
        private Dot _Selected;
        public Dot Selected {
            get { return _Selected; }
            set {
                _Selected = value;
                if (NewSelection != null)
                    NewSelection(_Selected);
            }
        }
        public event Action<Dot> NewSelection;

        public ThreeDotsModel(int width, int height)
        {
            Dots = new List<Dot>();
            int r = Dot.Radius;
            Random rnd = new Random();
            Color[] cols = { Color.Red, Color.Green, Color.Blue };
            for( int i = 0; i < 3; i++)
            {
                int randX = (rnd.Next() % (width-2*r)) + r;
                int randY = (rnd.Next() % (height-2*r)) + r;
                Dot d = new Dot();
                d.X = randX;
                d.Y = randY;
                d.Color = cols[i];
                Dots.Add(d);
            }
        }
    }
}
