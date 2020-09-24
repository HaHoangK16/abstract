using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical3_2
{
    interface INews
    {
        int ID {get;set;}
        string Title {get;set;}
        DateTime publishDate {get;set;}
        string Author {get;set;}
        string Content {get;set;}
        float AverageRate {get;}

        void Display();
    }
}