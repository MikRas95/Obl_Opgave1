using System;

namespace Obl_Opgave1
{
    public class Car
    {
        private int _id;
        private string _model;
        private double _price;
        private string _licensePlate;

        // LAV ID / Skal der laves en test på id???????
        //public int Id
        //{
        //    get => _id;
        //    set
        //    {

        //    }
        //}

        public string Model
        {
            get => _model;
            set
            {
                if (value == null) throw new ArgumentNullException("model", "Model must not be null");
                if (value.Length < 4) throw new ArgumentException("Model must have at least 4 characters");
                _model = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value == 0) throw new ArgumentNullException("price", "Price must not be 0");
                if (value < 0) throw new ArgumentOutOfRangeException("price", "Price must be higher than 0");
                _price = value;
            } 
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value == null) throw new ArgumentNullException("LicensePlate", "LicensePlate must not be null");
                if (value.Length < 2 || value.Length > 7) throw new ArgumentException("LicensePlate length must be between 2 and 7 characters");
                _licensePlate = value;
            }
        }

        public Car()
        {

        }
        public Car(string model, double price, string licensePlate)
        {
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }
    }

}
