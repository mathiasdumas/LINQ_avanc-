using System;
namespace exercices_LINQ
{
	public class Commands
	{
		public int ID { get; set; }
		public int ID_Buyer { get; set; }
		public int ID_Product { get; set; }
        public string Date { get; set; }


        public Commands(int iD, int iD_Buyer, int iD_Product, string date)
        {
            ID = iD;
            ID_Buyer = iD_Buyer;
            ID_Product = iD_Product;
            Date = date;
        }
    }
}

