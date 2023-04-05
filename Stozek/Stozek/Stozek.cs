using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojStozek
{
    public class Stozek:Bryla
    {
        private double promien;

        public Stozek(double r, double h):
            base(h)
        {
            promien = r;
         
        }

        public override double PolePodstawy()
        {
            return Math.PI * promien* promien;
        }
        public override double PoleBoczne()
        {
            return Math.PI * promien * Math.Sqrt(promien*promien+h*h);
        }
        public override double PoleCalkowite()
        {
            return PolePodstawy() + PoleBoczne();
        }
    }
}

