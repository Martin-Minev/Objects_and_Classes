using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();

                int serialNumber = int.Parse(tokens[0]);
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3]);

                Item item = new Item() 
                {
                     Name = itemName,
                     Price = itemPrice
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = item.Name,
                    ItemQuantity = itemQuantity,
                    PriceForaBox = itemQuantity * item.Price
                };

                boxes.Add(box);
            }
            foreach (Box box in boxes.OrderByDescending(b=>b.PriceForaBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item} - ${(box.PriceForaBox/box.ItemQuantity):F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForaBox:F2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForaBox { get; set; }
    }
}
