using AulaDoze.Entites.Enums;
namespace AulaDoze.Entites
{
    public class Clircle : Shape
    {
        public double Radius { get; set; }

        public Clircle (double radius, Color color) : base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
    }
}