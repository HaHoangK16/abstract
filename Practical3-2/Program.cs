using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Practical3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            int choice;
            Console.WriteLine("1. Insert news");
            Console.WriteLine("2. View list news");
            Console.WriteLine("3. Averate rate");
            Console.WriteLine("4. Exit");
            while(true)
            {
                Console.WriteLine("Please select an item: ");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1: a.InsertNews();
                    break;
                    case 2: a.ViewNews();
                    break;
                    case 3: a.EverateRate();
                    break;
                }
            }
        }

        Hashtable NewsList = new Hashtable();
        int count = 0;

        public void InsertNews()
        {
            News news = new News();
            news.ID = ++count;
            Console.WriteLine("Title: ");
            news.Title = Console.ReadLine();
            while(true)
            {
                try{
                    Console.WriteLine("Publish date: ");
                    news.publishDate = DateTime.Parse(Console.ReadLine());
                    break;
                } catch(Exception e){
                    Console.WriteLine("Publish date is not formatted");
                }
            }
            Console.WriteLine("Author: ");
            news.Author = Console.ReadLine();
            Console.WriteLine("Content: ");
            news.Content = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Rate"+(i+1)+": ");
                news[i] = int.Parse(Console.ReadLine());
            }
            NewsList.Add(news.ID, news);
        }

        public void ViewNews()
        {
            if(NewsList.Count > 0)
            {
                foreach(News news in NewsList.Values)
                {
                    news.Display();
                }
            } else{
                Console.WriteLine("News not found");
            }
        }

        public void EverateRate()
        {
            if(NewsList.Count > 0)
            {
                foreach(News news in NewsList.Values)
                {
                    news.Calculate();
                    news.Display();
                }
            } else {
                Console.WriteLine("News not found");
            }
        }
    }
}
