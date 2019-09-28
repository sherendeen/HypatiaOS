using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;

namespace Hypatia
{
    public class GraphicsInitBehavior : Behavior
    {

        /// <summary>
        /// Instanced Kernel Access
        /// </summary>
        private Kernel mind;

        public GraphicsInitBehavior() { }

        /// <summary>
        /// GraphicsInitBehavior but with instanced kernel access
        /// </summary>
        /// <param name="mind">instanced kernel access token</param>
        public GraphicsInitBehavior(Kernel mind)
        {
            this.mind = mind;
        }

        public override void Execute()
        {
            Console.WriteLine("Draw Initialization Behavior executing...");

            if (mind == null)
            {
                Console.WriteLine($"Failed.");
                return;
            }
            else
            {
                mind.ActivateGraphicalMode();
            }

            
        }
    }
}
