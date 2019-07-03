using System;
using System.Collections.Generic;
using System.Text;

namespace Hypatia
{
    public class Command
    {
        private string name;
        private string desc;
        private Behavior[] behaviorsToExecute;

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Desc
        {
            get
            {
                return this.desc;
            }
        }

        public Behavior[] BehaviorsToExecute
        {
            get
            {
                return this.behaviorsToExecute;
            }
        }

        public void SetBehaviorAt(int index, Behavior behavior)
        {
            this.BehaviorsToExecute[index] = behavior;
        }

        /// <summary>
        /// empty default constructor
        /// </summary>
        public Command( ) { }

        /// <summary>
        /// Sets the fields of name, desc, and behaviorsToExecute
        /// </summary>
        /// <param name="name">the name of the command</param>
        /// <param name="desc">description of what the command does</param>
        /// <param name="behaviorsToExecute">the list of behaviors the command will perform</param>
        public Command(string name, string desc, Behavior[] behaviorsToExecute)
        {
            this.name = name;
            this.desc = desc;
            this.behaviorsToExecute = behaviorsToExecute;
        }

        public void ExecuteBehaviors()
        {
            foreach (Behavior behavior in behaviorsToExecute)
            {
                behavior.Execute();
            }
        }

        /// <summary>
        /// Execute a specific behavior
        /// </summary>
        /// <param name="index">the index of said behavior</param>
        public void ExecuteBehavior(int index)
        {
            this.behaviorsToExecute[index].Execute();
        }

    }
}
