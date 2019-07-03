using System;
using System.Collections.Generic;
using System.Text;

namespace Hypatia
{
    public class Behavior
    {
        public Behavior() { }

        public virtual void Execute()
        {
            Console.WriteLine("Basic Behavior executing...");
        }
    }
}
