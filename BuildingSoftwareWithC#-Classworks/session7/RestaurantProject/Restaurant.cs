using System;
namespace RestaurantProject
{
    public class Restaurant
    {
       // instance variables 
        private string name;
        private string address;
        private double gratuityRate;

        public Restaurant(string name, string address, double gratuityRate)
        {
            Name = name;
            Address = address;
            GratuityRate = gratuityRate;
        }
       
        // properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public double GratuityRate
        {
            get { return gratuityRate; }
            set { 
                if (value >= 0)
                {
                    gratuityRate = value;
                } 
             }
        }

        public void GenerateReceipt()
        {
             double price = 0;
             double subtotal = 0.0;
             double gratuityAmount = 0.0;
             double grandTotal;
             int people;

             while(price != -1)
            {
                subtotal = subtotal + price;
                 Console.Write("Enter price of food item [-1 to quit]: ");
                 price = Convert.ToDouble(Console.ReadLine());
             }

             Console.Write("How many people in party: ");
             people = Convert.ToInt32(Console.ReadLine());

             if (people >= 6)
             {
                 gratuityAmount = subtotal * GratuityRate;
             }

             grandTotal = subtotal + gratuityAmount;

             Console.WriteLine($"Subtotal\t{subtotal:C}\n{GratuityRate*100}% Gratuity:\t{gratuityAmount:C}\nGrand Total\t{grandTotal:C}");
        }
    }
} 