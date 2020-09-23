using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalMS
{
    interface IAnimal
    {
        int ID {get;set;}
        string Name {get;set;}
        int Age {get;set;}
    }
}