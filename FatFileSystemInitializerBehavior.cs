using Sys = Cosmos.System;
using System;
using System.Collections.Generic;
using System.Text;



namespace Hypatia
{
    /// <summary>
    /// This class is somewhat obtuse
    /// </summary>
    class FatSystemInitializationBehavior : Behavior
    {
        /// <summary>
        /// Kernel access
        /// </summary>
        private Kernel instance;
        

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public FatSystemInitializationBehavior()
        {
        }

        /// <summary>
        /// Initializes the FatSystemInitializationBehavior 
        /// and provides kernel access.
        /// </summary>
        /// <param name="instance">the access object to the kernel</param>
        public FatSystemInitializationBehavior(Kernel instance)
        {
            this.instance = instance;
            instance.fileSystem = new Cosmos.System.FileSystem.CosmosVFS();
        }

        public void SetInstance(Kernel instance)
        {
            this.instance = instance;
        }

        public void InitializeFileSystem()
        {
            if ( this.instance.fileSystem!= null)
            {
                this.instance.fileSystem = new Cosmos.System.FileSystem.CosmosVFS();
            }
            else
            {
                Console.WriteLine("Cannot reinitialize file system: it already has been initialized.");
            }
        }

    }
}
