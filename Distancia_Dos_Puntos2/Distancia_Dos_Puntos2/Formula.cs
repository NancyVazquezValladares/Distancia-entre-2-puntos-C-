using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia_Dos_Puntos2
{
    public class Formula
    {
        public double x11, x22, y11, y22, distancia1;

        public Formula()
        {
        }

        public Formula(double x1, double x2, double y1, double y2, double distancia) {
            x11 = x1;
            x22 = x2;
            y11 = y1;
            y22 = y2;
            distancia1 = distancia;
   }
        public double formula(double x1, double x2, double y1, double y2) {
            double distancia1 = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)), 3);
        return distancia1;
        }

       
    } }
