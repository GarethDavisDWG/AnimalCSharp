using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Animal
    {
        /////////////////////////////////////////Attributes///////////////////////////////////////////
        
        public int Age { get; private set; }
        public String Name { get; private set; }

        //////////////////////////////////////////Constructors//////////////////////////////////////////
        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }


        //////////////////////////////////////////Methods//////////////////////////////////////////////////  
        public abstract void Eat(String food);

        public void Sleep(int lengthOfSleep)
        {
            // sleep method
        }

        public abstract Animal Reproduce(Animal otherParent);

        public abstract void Breathe();

        public String Poo()
        {
            Age = 16;
            return "I have logged this";
            
        }
        
        public void Die()
        {
            // add die method
        }

       

        
    }
}
