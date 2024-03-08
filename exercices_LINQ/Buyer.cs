using System;
using System.Xml.Linq;

namespace exercices_LINQ
{
	public class Buyer
	{
        public int ID { get; set; }
        public string Name { get; set; }
		
        public Buyer(int iD, string name)
        {
            ID = iD;
            Name = name;
            
        }
    }
}

