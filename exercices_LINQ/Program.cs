using System.Collections;

namespace exercices_LINQ;

class Program
{
    static void Main(string[] args)
    {
        // ressortir les notes au dessus de 80 d'un dictionnaire

        Dictionary<string, int> StudentNotes = new Dictionary<string, int>()
        {
            {"Français", 80 },
            {"Anglais", 70 },
            {"Math", 82 },
            {"Physique", 10 },
            {"Histoire",  90},
        };

        IEnumerable<KeyValuePair<string, int>> TriNotes = from v in StudentNotes where v.Value >= 80 select v;
        foreach (var notes in TriNotes)
        {
            Console.WriteLine(notes.Key + " " + notes.Value);
        }

        // joindre 2 listes pour ressortir les élèves d'une même classe 

        List<Student> studentList = new List<Student>() {
        new Student ("Jessica", 1, 1),
        new Student ("Mathias", 2, 1),
        new Student ("Cyril", 3, 1),
        };

        List<DepartmentClass> classList = new List<DepartmentClass>() {
        new DepartmentClass ("C#", 1),
        };

        var innerJoin = from student in studentList
                        join classroom in classList
                        on student.Class_Id equals classroom.Id
                        select new
                        {
                            StudentName = student.Name,
                            ClassRoomName = classroom.Name,
                        };

        foreach (var item in innerJoin)
        {
            Console.WriteLine(item.StudentName + " " + item.ClassRoomName);
        }

        // joindre 3 liste pour voir qui a acheté quoi dans quelle quantité

        List<Buyer> buyerList = new List<Buyer>()
        {
            new Buyer(1, "Mathias"),
            new Buyer(2, "Jessica"),
            new Buyer(3, "Cyril"),
        };

        List<Product> productList = new List<Product>()
        {
            new Product(1, "chocolat", 3),
            new Product(2, "car", 10000),
            new Product(3, "glasses", 250),
            new Product(4, "fishing rod", 80),
        };

        List<Commands> commandList = new List<Commands>()
        {
            new Commands(1, 1, 1, "12/12/2012"),
            new Commands(2, 1, 2, "12/12/2012"),
            new Commands(3, 1, 4, "14/12/2012"),
            new Commands(4, 2, 3, "25/07/2023"),
            new Commands(5, 3, 2, "30/09/2023")
        };

        var customerOrders = from buyers in buyerList
                             join command in commandList
                             on buyers.ID equals command.ID_Buyer
                             select new
                             {
                                 BuyersName = buyers.Name,
                                 CommandDate = command.Date,
                                 ProductOrders = from command2 in commandList
                                                 join product in productList
                                                 on command2.ID_Product equals product.ID
                                                 group command2 by command2.ID_Buyer
                             };
        
      


        foreach (var group in customerOrders)
        {
            Console.WriteLine(group.BuyersName);
            foreach (var prout in group.ProductOrders)
            {
                Console.WriteLine(prout);
            }
        }


    }
}

