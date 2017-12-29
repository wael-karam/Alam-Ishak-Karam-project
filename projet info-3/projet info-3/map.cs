
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace projet_info_3
{
    class map
    {
        public route route1;
        public route route2;
        public route route3;
        public route route4;
        public TrafficLightGrp traf_light;
    public map()
     {

         route1 = new route(1,new Point(300,375),new Point(550,400));
         route2 = new route(2, new Point(720, 750), new Point(720, 450));
         route3 = new route(3, new Point(1000, 305), new Point(600, 305));
         route4 = new route(4, new Point(700, 150), new Point(700, 400));
         traf_light = new TrafficLightGrp();
     }

        public route Route1
        {
            get { return route1; }
            set { route1 = value; }
        }
        public route Route2
        {
            get { return route2; }
            set { route2 = value; }
        }
        public route Route3
        {
            get { return route3; }
            set { route3 = value; }
        }
        public route Route4
        {
            get { return route4; }
            set { route4 = value; }
        }

    }
    

}

   

