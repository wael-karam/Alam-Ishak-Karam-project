using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_info_3
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point loc = new Point (50,50);
            Graphics gr = this.CreateGraphics();
            Car car1 = new Car(loc, 3);
            car1.draw(ref gr);
        }
    }
}
