using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;

namespace Hypatia
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            CommandRegistrar.Register();


            Console.WriteLine("Hypatia booted successfully.");
        }

        protected override void Run()
        {
            string input = "";

            input = Console.ReadLine();

            //    HandleThisCommand(input);
            CommandRegistrar.HandleCmd(input);
        }
    }
}
