using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13
{
    public interface AnimalInterface
    {
        string Info();
    }

    public abstract class Animal : AnimalInterface
    {
        private double weight;
        private int age;
        private double cost;

        public double Weight { get { return weight; } }
        public int Age { get { return age; } }
        public double Cost { get { return cost; } }

        protected Animal(double weight, int age, double cost)
        {
            this.weight = weight;
            this.age = age;
            this.cost = cost;
        }

        public virtual string Info()
        {
            return "Вага: " + Weight + " кг; " +
                   "Вік: " + Age + " років; " +
                   "Вартість на добу: " + Cost + " грн; ";
        }
    }

}
