using System;

namespace StudentMS
{
    class Student : IStudent
    {

        public string FullName {get;set;}
        public int ID {get;set;}
        public DateTime DateofBirth {get;set;}
        public string Native {get;set;}
        public string CLASS {get;set;}
        public string PhoneNo {get;set;}
        public int Mobile {get;set;}



        public void Display()
        {
            Console.WriteLine("ID: "+ID+" FullName: "+FullName+" Date of Birth: "+DateofBirth+" Native: "+Native+" Class: "+CLASS+" PhoneNo: "+PhoneNo+" Mobile: "+Mobile);
        }
    }
}