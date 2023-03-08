namespace ExContratoTrabalho.Entities
{
    public class HourContract
    {
        public System.DateTime Date { get; set; }
        public double  ValuePerHour { get; set; }
        public int Hours { get; set; }


        public HourContract ()
        {
        }

        public HourContract(System.DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hour;
        }

        public double totalValue() 
        {
            return Hours * ValuePerHour;
        }
    }
}