using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Hypatia
{
    class ReadAndPrintBehavior : Behavior
    {


        private string path;
        
        public string Path
        {
            set
            {
                this.path = value;
            }
            get
            {
                return this.path;
            }
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public ReadAndPrintBehavior() { }

        public ReadAndPrintBehavior(string path)
        {
            this.path = path;
        }

        public override void Execute()
        {
            Console.WriteLine("Reading...");
            Console.WriteLine();
            string[] lines = File.ReadAllLines(this.path);
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }
        }

    }
}
