using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Bat : Mammal , Flying
    {
        ////////////////////Attributes//////////////////////////////






        /////////////////////Constructors//////////////////////////////
        ///







        //////////////////////////Methods///////////////////////////////
        public override void Eat(string food)
        {
            // implement this later
        }

        public void Flight()
        {
            Console.WriteLine("I am flying");
        }

        public void Landing()
        {
            throw new NotImplementedException();
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }
    }
}
