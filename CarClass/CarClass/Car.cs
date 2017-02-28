using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class Car
    {
        private string _Brand;
        private string _Model;
        //private decimal _Price;
        //private double _Speed;
        //private double _Power;
        

        public Car(string brand, string model,decimal price, DateTime BirthDate,double speed, double power, string fuel)
        {
            this.BirthDate = BirthDate;
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
            this.Power = power;
            this.Speed = speed;
            this.Fuel = fuel;
        }

        public DateTime BirthDate { get; private set; }
        public TimeSpan Age
        {
            get { return DateTime.Now - BirthDate; }
        }
        public string Brand
        {
            get {return this._Brand ;}
            set
            {
                if (string.IsNullOrWhiteSpace(this._Brand))
                {
                    this._Brand = value;
                }
                else
                {
                    throw new ArgumentNullException("Cannot rename a brand!");
                };
            }
        }
        public string Model
        {
            get { return this._Model; }
            set
            {
                if (string.IsNullOrWhiteSpace(this._Model))
                {
                    this._Model = value;
                }
                else
                {
                    throw new ArgumentNullException("Cannot rename a model!");
                };
            }
        }
        public decimal Price { get; set; }
        public double Speed { get; set; }
        public double Power { get; set; }
        public string Fuel { get; private set; }



    }
}
