using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Mammal : Animal
    {
        ///////////////////////////Attributes///////////////////////////////
        




        /////////////////////////////Constructors/////////////////////////




        //////////////////////////////Methods////////////////////////////////

        public override void Breathe()
        {
            // implement breathe method
        }

        public override Mammal Reproduce(Animal otherParent)
        {
            return null;
        }



    }
}
