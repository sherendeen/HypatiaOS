using System;
using System.Collections.Generic;
using System.Text;

namespace Hypatia
{
    /// <summary>
    /// Simple behavior that lists anything given to it
    /// </summary>
    public class ListBehavior : Behavior
    {

        private string[] list;
        public string[] List
        {
            set
            {
                this.list = value;
            }

            get
            {
                return this.list;
            }
        }

        /// <summary>
        /// Default empty constructor
        /// </summary>
        public ListBehavior() { }

        /// <summary>
        /// 
        /// </summary>
        public ListBehavior(string[] list)
        {
            this.list = list;
        }

        public override void Execute()
        {
            foreach(string str in list)
            {
                Console.WriteLine(str);
            }
        }


    }
}
