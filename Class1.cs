using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Object_Creation
{
    public class Class1
    {

        private double rad1, pie1;
        

        public Class1(double rad1, double pie1)
        {
            this.rad1 = rad1;
            this.pie1 = pie1;
        }

        public void setrad1(double rad1)
        {
            this.rad1 = rad1;
        }

        public double getrad1()
        {
            return this.rad1;
        }

        public void setpie1(double pie1)
        {
            this.pie1 = pie1;
        }

        public double setpie1()
        {
            return this.pie1;
        }

        public void calcVolume()
        {
            double rad1 = this.rad1;
            double pie1 = this.pie1;
            this.rad1 = rad1 * rad1 * rad1;
            this.pie1 = 3.14;
            
        }

        public void calcSurface()
        {
            double rad1 = this.rad1;
            double pie1 = this.pie1;
            this.rad1 = rad1 * rad1;
            this.pie1 = 3.14;

        }
    }
}