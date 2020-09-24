using System;
using System.Collections;

namespace StudentMS
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Program a = new Program();
            int choice;
            Console.WriteLine("1. Insert new Student");
            Console.WriteLine("2. View list of Student");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Exit");
            do
            {
                Console.WriteLine("\nPlease select an item: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch(choice)
                {
                    case 1: a.AddStudent();
                    break;
                    case 2: a.ViewlistofStudents();
                    break;
                    case 3: a.SearchStudent();
                    break;
                    case 4: return;
                }
            } while(choice !=4);
        }


        int count = 0;
        Hashtable ListStudent = new Hashtable();
        public void AddStudent()
        {
            Student s = new Student();
            s.ID = 1;
            Console.WriteLine("FullName: ");
            s.FullName = Console.ReadLine();
            Console.WriteLine("Date of Birth:");
            s.DateofBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Native: ");
            s.Native = Console.ReadLine();
            Console.WriteLine("Class: ");
            s.CLASS = Console.ReadLine();
            Console.WriteLine("PhoneNo: ");
            s.PhoneNo = Console.ReadLine();
            Console.WriteLine("Mobile: ");
            s.Mobile = int.Parse(Console.ReadLine());
            ListStudent.Add(count, s);
            count++;            
        }

        public void ViewlistofStudents()
        {
            foreach(Student item in ListStudent.Values){
                item.Display();
            }
        }

        public void SearchStudent()
        {
            string name;
            Console.Write("Enter student search: ");
            name = Console.ReadLine();
            foreach(Student item in ListStudent.Values)
                if(item.FullName.Equals(name)){
                    item.Display();
                }
                else{
                    Console.WriteLine("Name not found");
                }
        }
    }
}

