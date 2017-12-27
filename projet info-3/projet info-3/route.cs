using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projet_info_3
{
    class route
    {
        int routenbr;
        public Point startpoint;
        public Point endpoint;
        public Rectangle boundaries;
        public int height;
        public int width;
        public Point LocBound;
        






        public route(int Routenbr,Point Loc, Point Startpoint, Point Endpoint,int heightRoute, int widthRoute)
        {
            LocBound = Loc;
            routenbr = Routenbr;
            startpoint = Startpoint;
            endpoint = Endpoint;
            width = widthRoute;
            height = heightRoute;
            this.boundaries = new Rectangle(Loc, new Size(widthRoute, heightRoute));
            






        }
        public Rectangle Boundaries { get { return boundaries; } set { boundaries = value; } }

        public Point LocationBound { get { return LocBound; } set { LocBound = value; } }


        public Point StartP
        {
            get { return startpoint; }

            set { startpoint=value;}

        }



        public Point EndP
        {
            get { return endpoint; }

            set { endpoint = value; }

        }
        public int RouteNbr
        {
            get { return routenbr; }

            set { routenbr = value; }

        }



        public static Queue<double> expo(double mean, double period)
        {
            // This method generates a sequence of cars dates arrival
            // in interval [0, period] as double real numbers in minutes
            // Dates are stored in a Queue
            // The model is a Poisson process of 'mean' cars/minute
            // And theory says that inter-arrival dates 
            // form an exponential sequence of parameter 1/mean
            // To retreive dates from the returned Queue, let's name it times:
            // while (times.Count != 0)
            //    Console.WriteLine((double)times.Dequeue());
            Queue<double> q= new Queue<double>();
            Random g = new Random();
            double current_time = 0.0, u, inter;
            while (current_time < period)
            {
                u = g.NextDouble(); // u in [0,1]
                inter = -1.0 / mean * Math.Log(1 - u);
                current_time += inter;
                if (current_time < period) q.Enqueue(current_time);
            }
            return q;
        }


      public  void circuleend(Car c,Graphics gr)    //circulation jusqu'a endpoint

        {
           
            
            if (this.routenbr==1) { // this.startpoint =

               
                c.draw(gr);


            }


            if (this.routenbr == 2) { c.draw(gr); }
            if (this.routenbr == 3) { c.draw(gr); }
            if (this.routenbr == 4) { c.draw(gr); }








        }
    }
}
