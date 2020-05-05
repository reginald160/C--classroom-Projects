using System;

namespace RestaurantProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Restaurant restaurant = new Restaurant("Mr Biggs!", "Austin House, Ota", 0.15);

            restaurant.GenerateReceipt();
        }
    }
}
