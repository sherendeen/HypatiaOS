using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;

namespace Hypatia
{
    public class ShowTextModeInfoBehavior : Behavior
    {
        public ShowTextModeInfoBehavior() { }

        public override void Execute()
        {
            Console.WriteLine($"Number of rows: {Sys.Global.Console.Rows}");
            Console.WriteLine($"Number of cols: {Sys.Global.Console.Cols}");
            Console.WriteLine($"Foreground Console Color: {Sys.Global.Console.Foreground}");
        }
    }
}
