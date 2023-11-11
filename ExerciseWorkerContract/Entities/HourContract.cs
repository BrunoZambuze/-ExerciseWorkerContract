using System;

namespace ExerciseWorkerContract.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; private set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Construtor
        public HourContract()
        {
        }

        public HourContract(DateTime date, double value, int hours)
        {
            Date = date;
            ValuePerHour = value;
            Hours = hours;
        }

        //Função
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
