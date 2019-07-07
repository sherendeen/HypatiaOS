using System;
using System.Collections.Generic;
using System.Text;

namespace Hypatia
{
    public class ProcedurerBehavior : Behavior
    {
        private string prompt;

        private string[] options;

        private string result;

        public string Prompt
        {
            set
            {
                this.prompt = value;
            }

            get
            {
                return this.prompt;
            }
        }

        public string[] Options
        {
            set
            {
                this.options = value;
            }

            get
            {
                return this.options;
            }
        }

        public string Result
        {
            get
            {
                return this.result;
            }
        }

        public ProcedurerBehavior() { }
        public ProcedurerBehavior(string prompt, string[] options)
        {
            this.prompt = prompt;
            this.options = options;
        }

        //public SimpleDialogueBehavior(string prompt)
        //{

        //}



        private void ShowOptions()
        {

            int count = 0;
            while (count < options.Length)
            {
                Console.WriteLine($"{count++} - {options[count]}");
            }

        }

        private int SelectOption(string input)
        {
            int option;

            int count = 0;
            while (count < options.Length)
            {
                //Console.WriteLine($"{count++} - {options[count]}");
                if(input == options[count] || count == GetNumericalInput(input))
                {
                    option = count;
                }
            }

            return -1;
        }

        private int GetNumericalInput(string input)
        {
            int number;
            if (int.TryParse(input, out number) == false)
            {
                return -1;
            }
            return number;

        }

        /// <summary>
        /// Executes the behavior by
        /// 1. Displaying a prompt
        /// 2. Asking for input
        /// 3. Parsing the input
        /// 4. Registering the input in the result field
        /// </summary>
        public override void Execute()
        {

            Console.WriteLine(prompt);
            ShowOptions();
            var input = Console.ReadLine();

            
            var result = SelectOption(input);
            if (result != -1)
            {
                this.result = options[result];
            }


        }

    }
}
