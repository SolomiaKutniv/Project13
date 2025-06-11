using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13
{

    public class Wolf : Animal, ICloneable, IComparable
    {
        private string breed;
        private string location;

        public string Breed { get { return breed; } }
        public string Location { get { return location; } }

        public Wolf(double weight, int age, double cost, string breed, string location)
            : base(weight, age, cost)
        {
            this.breed = breed;
            this.location = location;
        }

        public override string Info()
        {
            return base.Info() +
                   "Порода: " + Breed + "; " +
                   "Локація: " + Location;
        }

        object ICloneable.Clone()
        {
            return new Wolf(Weight, Age, Cost, Breed, Location);
        }

        public Wolf Clone()
        {
            return (Wolf)((ICloneable)this).Clone();
        }

        int IComparable.CompareTo(object obj)
        {
            Wolf other = obj as Wolf;
            if (other != null)
            {
                return this.Age.CompareTo(other.Age);
            }
            else
            {
                throw new InvalidCastException("Неможливо порівняти з об’єктом іншого типу.");
            }
        }
    }

}
