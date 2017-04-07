using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeDots
{
    public partial class ThreeDotControl : UserControl
    {
        private ThreeDotsModel _Model;
        public ThreeDotsModel Model {
            get { return _Model; }
            set {
                _Model = value;
                if ( _Model != null)
                    _Model.NewSelection += GotNewSelection;
            }
        }

        private void GotNewSelection(Dot obj)
        {
            this.Refresh();
        }

        public ThreeDotControl()
        {   
            InitializeComponent();
        }

        private void PaintMe(object sender, PaintEventArgs e)
        {
            if (Model == null) return;

            foreach (var dot in Model.Dots)
            {
                Rectangle r = new Rectangle(dot.X - Dot.Radius, 
                    dot.Y - Dot.Radius, 
                    2 * Dot.Radius, 
                    2 * Dot.Radius);
                e.Graphics.FillEllipse(new SolidBrush(dot.Color), r);
                int width = Model.Selected == dot ? 3 : 1;
                e.Graphics.DrawEllipse(new Pen(Color.Black, width), r);
            }
        }

        private void Select(object sender, EventArgs e)
        { //if (e.Button == System.Windows.Forms.MouseButtons.Right
            if (Model == null) return;
            MouseEventArgs me = (MouseEventArgs)e;
            Point p = me.Location;
            foreach( Dot dot in Model.Dots)
            {
                if ( Within(p, dot))
                {
                    Model.Selected = dot;
                    return;
                }
            }
            Model.Selected = null;
        }

        private bool Within(Point p, Dot dot)
        {
            double xx = Math.Pow(p.X - dot.X, 2);
            double yy = Math.Pow(p.Y - dot.Y, 2);
            double dist = Math.Sqrt(xx + yy);
            return dist <= Dot.Radius;
        }
        
    }
}
