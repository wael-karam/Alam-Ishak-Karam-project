using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projet_info_3
{
    class TrafficLight
    {
        private int duration;
        private bool isGreen;
        private Point location;

         public TrafficLight(Point location)
        {
            this.duration = 5;
            this.isGreen = false;
            this.location = location;
        }
         public int Duration
         {
             get { return duration; }
             set { duration = value; }
         }

         public bool IsGreen
         {
             get { return isGreen; }
             set { isGreen = value; }
         }

         public Point Location
         {
             get { return location; }
             set { location = value; }
         }

         public void Draw(Graphics gr)
         {
             if (isGreen)
             {
                 SolidBrush myBrush = new SolidBrush(Color.Green);
                 gr.FillEllipse(myBrush, location.X, location.Y, 20, 20);
             }
             else
             {
                 SolidBrush myBrush = new SolidBrush(Color.Red);
                 gr.FillEllipse(myBrush, location.X, location.Y,20, 20);
             }
         }

    }
}
