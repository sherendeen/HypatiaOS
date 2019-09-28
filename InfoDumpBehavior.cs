using Sys = Cosmos.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hypatia
{
    class InfoDumpBehavior : Behavior
    {
        private Kernel kernel;

        public InfoDumpBehavior() { }
        public InfoDumpBehavior(Kernel kernel)
        {
            this.kernel = kernel;
        }
        public override void Execute()
        {
            if (this.kernel == null)
            {
                Console.WriteLine("Warning: no kernel access has been given to this behavior.");
            }

            //test file system functionality
            File.WriteAllText(@"0\TEXT.TXT", "testificate\n1235\n384g8sf9");
        }

    }
}
