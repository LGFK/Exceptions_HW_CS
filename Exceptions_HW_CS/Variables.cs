using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HW_CS
{
    internal class Variables
    {
        double a;
        double b;
        double c;
        public Variables(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }

        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public static Variables Parse(string var)
        {
            string[] tmp = var.Split(',');
            if(tmp.GetLength(0)!=3)
            {
                throw new FormatException();
            }
            Variables res = new Variables(double.Parse(tmp[0]), double.Parse(tmp[1]), double.Parse(tmp[2]));
            return res;
            
        }
        public static (double,double) Solve(Variables v1,Variables v2)
        
        {
            double[,] A = new double[2, 2];
            A[0, 0] = v1.A;
            A[1, 0] = v2.A;
            A[0, 1] = v1.B;
            A[1,1] = v2.B;
            double deltA = A[0, 0] * A[1,1] - A[1, 0]*A[0,1];
            if(deltA==0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double delta1 = v1.C * A[1, 1] - A[0, 1] * v2.C;
            double delta2 = A[0,0] * v2.C - v1.C * A[1,0];
            double x = delta1 / deltA;
            double y = delta2 / deltA;
            return (x,y);
        }
    }
}
