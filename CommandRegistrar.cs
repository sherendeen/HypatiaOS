using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
namespace Hypatia
{
    public class CommandRegistrar
    {
        private static List<Command> commands = new List<Command>();
        static Command help;
        static Command info;
        static Command reboot;
        static Command startgfx;
        static Command color;

        /// <summary>
        /// Registers commands, including those requiring instanced kernel access
        /// </summary>
        /// <param name="mind">instanced kernel</param>
        public static void Register(Mind mind)
        {
            help = SetupHelpCmd();
            info = SetUpInfoCmd();
            reboot = SetUpRebootCmd();
            startgfx = SetUpStartGfxCmd(mind);

            commands.Add(help);
            commands.Add(info);
            commands.Add(reboot);
            commands.Add(startgfx);

            help.SetBehaviorAt(0, new ListBehavior(GetTextOfCommands() ));
        }

        /// <summary>
        /// Utility for getting strings of every command's name and description
        /// </summary>
        /// <returns>command names and descriptions as an array of strings</returns>
        private static string[] GetTextOfCommands()
        {

            List<string> myList = new List<string>();

            for(int i = 0; i < commands.Count; i++)
            {
                myList.Add($"{commands[i].Name} --- {commands[i].Desc}");
            }

            string[] commandStrings = myList.ToArray();

            return commandStrings;
        }

        /// <summary>
        /// Registers commands
        /// Excluding startupgfx
        /// </summary>
        public static void Register()
        {
            help = SetupHelpCmd();
            info = SetUpInfoCmd();
            reboot = SetUpRebootCmd();
            //startgfx = SetUpStartGfxCmd();

            commands.Add(help);
            commands.Add(info);
            commands.Add(reboot);
           // commands.Add(startgfx);

            help.SetBehaviorAt(0, new ListBehavior( GetTextOfCommands() ));
        }

        private static Command SetupHelpCmd()
        {
            Behavior[] behaviors =
            {
                new ListBehavior()
            };
            var cmd = new Command("help", "shows this list of commands", behaviors);
            return cmd;
        }

        private static Command SetUpStartGfxCmd(Mind mind)
        {
            Behavior[] behaviors =
            {
                new GraphicsInitBehavior(mind)
            };

            var cmd = new Command("startgfx", "starts graphical mode", behaviors);
            return cmd;
        }

        /// <summary>
        /// Sets up the reboot command
        /// </summary>
        /// <returns>command representing reboot functionality</returns>
        private static Command SetUpRebootCmd()
        {
            Behavior[] behaviors =
            {
                new SysRestartBehavior()
            };

            var cmd = new Command("reboot", "restarts the computer", behaviors);
            return cmd;
        }

        public static void HandleCmd(string input )
        {
            //Console.WriteLine("Handing command via Command Registrar");
            foreach (Command c in commands)
            {
                if (input == c.Name)
                {
                    c.ExecuteBehaviors();
                }
               
            }

        }

        private static Command SetUpInfoCmd()
        {
            Behavior[] behaviors =
            {
                new ShowTextModeInfoBehavior()
            };
            Command info = new Command("info", "shows system information", behaviors );

            return info;
        }

    }
}
