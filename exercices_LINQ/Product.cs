using System;
namespace exercices_LINQ
{
	public class Product
	{
        public  int ID { get; set; }
        public string Name { get; set; }
		public int Price { get; set; }
		
        public Product(int iD, string name, int price)
        {
            ID = iD;
            Name = name;
            Price = price;
        }
    }
}

