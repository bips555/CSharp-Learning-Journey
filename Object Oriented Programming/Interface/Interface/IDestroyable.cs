using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IDestroyable
    {

        //CLass cannot have multiple base classes

        string DestructionSound { get; set; }


        public void Destroy();
    }
}
