using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojStozek
{
    class Czworoscian : Bryla
    {
        private double a;
        
       
        public Czworoscian(double a): base((a*Math.Sqrt(6))/3)
        {
            this.a = a;

            
        }
        public override double PolePodstawy()
        {
            return (a * a * Math.Sqrt(3)) / 4;
        }
        public override double PoleBoczne()
        {
            return 3 * PolePodstawy(); 
        }
        public override double PoleCalkowite()
        {
            return PolePodstawy() + PoleBoczne();
        }

    }
}
