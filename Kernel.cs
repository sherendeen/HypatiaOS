using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos.Core;
using Cosmos.HAL.Drivers.PCI.Video;
using System.IO;
//using Cosmos.Core.IOGroup;
//using Cosmos.Hardware.Drivers.PCI.Video;


namespace Hypatia
{
    public class Kernel : Sys.Kernel
    {

        private Canvas canvas;
        private bool isGuiModeActive = false;

        /// <summary>
        /// Information directly related to the file system object
        /// </summary>
        public Cosmos.System.FileSystem.CosmosVFS fileSystem;

        public string[] ReadLines(string FileAdr)
        {
            string[] FileRead;
            FileRead = File.ReadAllLines(FileAdr);
            return FileRead;
        }

        public string ReadText(string FileAddr)
        {
            string f_contents = "";
            f_contents = File.ReadAllText(FileAddr);
            return f_contents;
        }

        public byte[] ReadByte(string FileAddr)
        {
            byte[] FileRead;
            FileRead = File.ReadAllBytes(FileAddr);
            return FileRead;
        }

        public string[] GetFilesFromAddress(string Addr)
        {
            string[] files = new string[256];
            if (Directory.GetFiles(Addr).Length > 0)
                files = Directory.GetFiles(Addr);
            else
                files[0] = "No files found.";
            return files;
        }

        public string[] GetDirectoryListingFromAddress(string Addr)
        {
            return Directory.GetDirectories(Addr);
        }

        public bool IsGuiModeActive
        {
            get
            {
                return this.isGuiModeActive;
            }

            set
            {
                this.isGuiModeActive = value;
            }
        }

        protected override void BeforeRun()
        {
            CommandRegistrar.Register(this);
            Console.WriteLine("Hypatia booted successfully.");
        }

        public void ActivateGraphicalMode()
        {
            //Initialize the dang canvas
            this.canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Columns;
            Sys.MouseManager.ScreenHeight = (uint)canvas.Mode.Rows;

            this.isGuiModeActive = true;

        }

        private void Draw()
        {
            Pen pen = new Pen(Color.Red);
            int X = (int)Sys.MouseManager.X;
            int Y = (int)Sys.MouseManager.Y;
            canvas.DrawLine(pen, X, Y, X + 5, Y);
            canvas.DrawLine(pen, X, Y, X, Y - 5);
            canvas.DrawLine(pen, X, Y, X + 5, Y - 5);
        }

        protected override void Run()
        {
            string input = "";

            input = Console.ReadLine();
            CommandRegistrar.HandleCmd(input);

            if ( this.isGuiModeActive )
            {
                Draw();
            }

        }


    }
}
