using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical3_2
{
    public class News : INews
    {
        public int ID {get;set;}
        public string Title {get;set;}
        public DateTime publishDate {get;set;}
        public string Author {get;set;}
        public string Content {get;set;}
        public float AverageRate {get;set;}

        public void Display()
        {
            Console.WriteLine("Title: "+Title);
            Console.WriteLine("Publish date: "+publishDate);
            Console.WriteLine("Author: "+Author);
            Console.WriteLine("Content: "+Content);
            Console.WriteLine("AverageRate: "+AverageRate);
        }

        int[] RateList = new int[3];
        public int this[int index]
        {
            get{
                return RateList[index];
            }
            set{
                RateList[index] = value;
            }
        }

        public void Calculate()
        {
            AverageRate = (float)(RateList[0]+RateList[1]+RateList[2])/3; 
        }
    }
}