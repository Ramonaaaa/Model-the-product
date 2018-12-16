using System;

namespace OOP_Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dairy dairy = new Dairy();
            dairy.Weight = 1;
            dairy.Name = "Zuzu";
            dairy.Producer = "Zuzu World";
            Console.WriteLine(dairy);

            Console.WriteLine();

            Fruit fruit = new Fruit();
            fruit.Weight = 1.32;
            fruit.Name = "Pomelo";
            fruit.Producer = "World Wide Pomelo";
            Console.WriteLine(fruit);

            Console.WriteLine();

            Beverages beverages = new Beverages();
            beverages.Weight = 1.5;
            beverages.Name = "Fanta";
            beverages.Producer = "Coca-Cola";
            Console.WriteLine(beverages);

            Console.WriteLine();

            Bread bread = new Bread();
            bread.Weight = 0.5;
            bread.Name = "Bagheta";
            bread.Producer = "Panifcom";
            Console.WriteLine(bread);


        }
    }
    public class Product
    {
        private double weight;
        private string name;
        protected DateTime productionDate = DateTime.Now;
        private string producer;

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Producer
        {
            get
            {
                return this.producer;
            }
            set
            {
                this.producer = value;
            }
        }

        public DateTime ProductioDate
        {
            get
            {
                return productionDate;
            }
        }

        public Product() { }
        public Product(string _producer, string _name, double _weight, DateTime _productionDate)
        {
            this.producer = _producer;
            this.name = _name;
            this.weight = _weight;
            this.productionDate = _productionDate;
        }

        public override string ToString()
        {
            return "Producer name: " + producer + ";" + "\nProduct name: " + name + ";"  +
                 "\nProduction date: " + productionDate.ToLongDateString() + ";";
               
        }
    }

    public class Dairy : Product
    {
        public DateTime ExpirationDate
        {
            get
            {
                return productionDate.AddDays(7);
            }
        }

        public Dairy() { }

        public Dairy(string _producer, string _name, double _weight, DateTime _productionDate) : base(_producer,
            _name, _weight, _productionDate)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nWeight: " + Weight.ToString() +  " l" + ";" + "\nEspiration date: " + productionDate.AddDays(7).ToLongDateString();
        }
    }

    public class Fruit : Product
    {
        public DateTime ExpirationDate
        {
            get
            {
                return productionDate.AddDays(2);
            }
        }

        public Fruit() { }
        public Fruit(string _producer, string _name, double _weight, DateTime _productionDate) : base(_producer,
            _name, _weight, _productionDate)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nWeight: " + Weight.ToString() + " kg" + ";" +  "\nExpiration date: " + productionDate.AddDays(2).ToLongDateString();
        }
    }

    public class Beverages : Product
    {
        public DateTime ExpirationDate
        {
            get
            {
                return productionDate.AddYears(3);
            }
        }

        public Beverages() { }
        public Beverages(string _producer, string _name, double _weight, DateTime _productionDate) : base(_producer,
            _name, _weight, _productionDate)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nWeight: " + Weight.ToString() + " l" + ";" +  "\nExpiration date: " + productionDate.AddYears(3).ToLongDateString();
        }
    }

    public class Bread : Product
    {
        public DateTime ExpirationDate
        {
            get
            {
                return productionDate.AddDays(4);
            }
        }

        public Bread() { }
        public Bread(string _producer, string _name, double _weight, DateTime _productionDate) : base(_producer,
            _name, _weight, _productionDate)
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nWeight: " + Weight.ToString() + " kg" + ";" + "\nExpiration date: " + productionDate.AddDays(4).ToLongDateString();
        }
    }
}
