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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            //timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Car c = new Car(new Point(10, 10), 3);
            //Graphics gr = this.CreateGraphics();
            //c.draw(gr);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // DateTime dt = DateTime.Now;
           // double a = dt.Ticks;


         
          
         
           //Queue<double> q= route.expo(3, 10);
           
           

        }

        Graphics gr;
        TrafficLightGrp t = new TrafficLightGrp();
        private void timer1_Tick(object sender, EventArgs e)
        {
            gr = this.CreateGraphics();
            t.inversement1(gr);
            t.inversement2(gr);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}