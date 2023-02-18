using System;

namespace QuintaAula
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;
        

        public double areaTriangulo(double A, double B, double C)
        {
            double p = (A+B+C) / 2.0;

            return Math.Sqrt(p * (p-A)*(p-B)*(p-C));           
        }
    }
}