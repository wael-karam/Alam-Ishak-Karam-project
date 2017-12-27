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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           
            g.FillRectangle(Brushes.Black, new Rectangle(new Point(300, 300), new Size(750, 150)));
            g.FillRectangle(Brushes.Black, new Rectangle(new Point(600, 0), new Size(150, 700)));
            g.FillRectangle(Brushes.LimeGreen, new Rectangle(new Point(300, 0), new Size(300, 300)));
            g.FillRectangle(Brushes.LimeGreen, new Rectangle(new Point(750, 0), new Size(300, 300)));
            g.FillRectangle(Brushes.LimeGreen, new Rectangle(new Point(750, 450), new Size(300, 250)));
            g.FillRectangle(Brushes.LimeGreen, new Rectangle(new Point(300, 450), new Size(300, 250)));
      Brush br=  new SolidBrush(Color.White);
            Pen p=new Pen(br);
            g.DrawLine(p,new Point(300,375),new Point(600,375));
            g.DrawLine(p, new Point(750, 375), new Point(1050, 375));
            g.DrawLine(p, new Point(675, 0), new Point(675, 300));
            g.DrawLine(p, new Point(675, 450), new Point(675, 700));
           
        }
    }
}