using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeDots
{
    public partial class ThreeDotsForm : Form
    {
        public ThreeDotsForm()
        {
            InitializeComponent();
        }
   
        private void ThreeDotsForm_Load(object sender, EventArgs e)
        {
            threeDotControl.Model = new ThreeDotsModel(threeDotControl.Width, threeDotControl.Height);
            threeDotControl.Model.NewSelection += DotSelected;

        }

        private void DotSelected(Dot d)
        {
            if (d == null)
            {
                colPanel.BackColor = Color.AntiqueWhite;
            }
            else
            {
                colPanel.BackColor = d.Color;
            }
        }
    }
}
