using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss
{
    internal class AdatOsztaly
    {
        double min;
        double max;
        List<double> osztalyAdatok = new List<double>();
        int gyakorisag = 0;

        public double Min { get => min; set => min = value; }
        public double Max { get => max; set => max = value; }
        public int Gyakorisag { get => gyakorisag; set => gyakorisag = value; }

        public AdatOsztaly(double min, double max)
        {
            this.min = min;
            this.max = max;
        }
        public double osztalyKoz()
        {
            return (min + max) / 2.0;
        }
        public void adatHozzaAd(double adat)
        {
            osztalyAdatok.Add(adat);
            gyakorisag++;
        }
        public double relativGyakorisag(int osszAdat)
        {
            return gyakorisag / (double)osszAdat;// nulla és egy közötti szám
        }
        
    }
}
