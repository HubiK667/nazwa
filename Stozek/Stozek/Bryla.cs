using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojStozek
{
    public abstract class Bryla
    {
        protected double h;
        public Bryla(double h)
        { 
        this.h = h;
        }
        public abstract double PolePodstawy();
        public abstract double PoleBoczne();
        public abstract double PoleCalkowite();
        public double Objetosc()
        { return h * PolePodstawy() / 3.0; }
        
        
        
    }
}
