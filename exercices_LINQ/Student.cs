using System;
namespace exercices_LINQ
{
	public class Student
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public int Class_Id { get; set; }


        public Student(string name, int id, int class_Id)
        {
            Name = name;
            Id = id;
            Class_Id = class_Id;
        }
    }
}

