using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Animal
    {
        public string name;
        public string breed;
        public string color;
        public int age;




        public Animal(string name,string breed,int age)
        { 
            this.name = name;
            this.breed = breed;
            this.age = age;

        }


        public string GetDetails()
        {
            return $"{name} {breed} {color} {age}";
            
        }



    }
}
