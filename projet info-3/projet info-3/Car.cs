using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projet_info_3
{
    class Car
    {

        Point location; // location of the car in the windows 
        int width; // width of the car 
        int height; // height of the car
        int direction; // number of lane  
        bool moving; // true if moving


        public Car(Point loc, int dirct)
        {
            location = loc;
            direction = dirct;
            width = 10;
            height = 10;
            moving = true;
        }

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        public int Direction
        {
            get { return direction;}
            set { direction = value; }
        }

        public void draw ( ref Graphics gr)
        {
            gr.FillRectangle(Brushes.Aqua, this.location.X, this.location.Y, this.width, this.height);
        }
    }
}
