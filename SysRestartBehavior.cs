using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
namespace Hypatia
{
    public class SysRestartBehavior : Behavior
    {

        public SysRestartBehavior() { }

        public override void Execute()
        {
            Console.WriteLine("Restarting...");
            Sys.Power.Reboot();
        }
    }
}
