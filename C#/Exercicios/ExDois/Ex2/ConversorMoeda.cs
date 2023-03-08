namespace Ex2
{
    public class ConversorMoeda
    {
        public const double iof = 0.6;

        public static double Conversor(double x, double y){
            return (x * y) / 0.943;
        }
    }
}