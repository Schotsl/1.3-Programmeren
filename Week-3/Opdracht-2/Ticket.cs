using System;
using System.Linq;

namespace Opdracht_2
{
    public class Ticket
    {
        private int age;
        private int hall;
        private string movie;
        private DateTime reception;

        public double price;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                int[] ages = { 0, 6, 9, 12, 16 };

                if (!ages.Contains(value))
                {
                    throw new Exception($"{value} is an invalid age rating");
                }

                age = value;
            }
        }

        public int Hall
        {
            get
            {
                return hall;
            }

            set
            {
                int[] halls = { 1, 2, 3 };

                if (!halls.Contains(value))
                {
                    throw new Exception($"{value} is an invalid hall number");
                }

                hall = value;
            }
        }

        public string Movie
        {
            get
            {
                return movie;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Movie string cannot be empty");
                }

                movie = value;
            }
        }

        public DateTime Reception
        {
            get
            {
                return reception;
            }

            set
            {
                if (value.Minute % 30 != 0)
                {
                    throw new Exception("Reception DateTime must be at a full or half hour");
                }

                reception = value;
            }
        }

        public bool Discount
        {
            get
            {
                DayOfWeek day = reception.DayOfWeek;
                return day == DayOfWeek.Monday || day == DayOfWeek.Tuesday;
            }
        }

        public Ticket(String movie, int price, DateTime reception, int hall, int age)
        {
            this.Age = age;
            this.Hall = hall;
            this.price = price;
            this.Movie = movie;
            this.Reception = reception;
        }
    }
}
