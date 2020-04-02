using System;

namespace Opdracht_2
{
    public class Customer
    {
        private string name;
        private DateTime birth;

        public DateTime Signup
        {
            get;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name string cannot be empty");
                }

                name = value;
            }
        }

        public DateTime Birth
        {
            get
            {
                return birth;
            }

            set
            {
                if (value >= DateTime.Now)
                {
                    throw new Exception("Birth DateTime cannot be now or in the future");
                }

                birth = value;
            }
        }

        public int Age
        {
            get
            {
                TimeSpan diffrenceTimeSpan = DateTime.Now - Birth;
                DateTime diffrenceDateTime = new DateTime(1, 1, 1) + diffrenceTimeSpan;

                return diffrenceDateTime.Year - 1;
            }
        }

        public bool Discount
        {
            get
            {
                TimeSpan diffrenceTimeSpan = DateTime.Now - Signup;
                DateTime diffrenceDateTime = new DateTime(1, 1, 1) + diffrenceTimeSpan;

                return diffrenceDateTime.Year - 1 > 1;
            }
        }

        public Customer(String name, DateTime birth)
        {
            this.Name = name;
            this.Birth = birth;
            this.Signup = DateTime.Now;
        }
    }
}
