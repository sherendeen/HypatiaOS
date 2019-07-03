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

        private Canvas canvas;

        private void ActivateGraphicalMode()
        {
            Console.WriteLine("Starting graphical mode...");
            this.canvas = Cosmos.System.Graphics.FullScreenCanvas.GetFullScreenCanvas();
            canvas.Clear(Color.CornflowerBlue);
        }

        //public void ActivateGraphicalMode(Mode mode)
        //{
        //    Console.WriteLine("Starting graphical mode...");
        //    this.canvas = Cosmos.System.Graphics.FullScreenCanvas.GetFullScreenCanvas(mode);

        //    canvas.Clear(Color.CornflowerBlue);

        //}

        //public void ActivateGraphicalMode(Mode mode, Color color)
        //{
        //    Console.WriteLine("Starting graphical mode...");
        //    this.canvas = Cosmos.System.Graphics.FullScreenCanvas.GetFullScreenCanvas(mode);
        //    canvas.Clear(color);
        //}

        //private void DrawBasicShape()
        //{

        //    try
        //    {
        //        /* A red Point */
        //        Pen pen = new Pen(Color.Red);
        //        canvas.DrawPoint(pen, 69, 69);

        //        /* A GreenYellow horizontal line */
        //        pen.Color = Color.GreenYellow;
        //        canvas.DrawLine(pen, 250, 100, 400, 100);

        //        /* An IndianRed vertical line */
        //        pen.Color = Color.IndianRed;
        //        canvas.DrawLine(pen, 350, 150, 350, 250);

        //        /* A MintCream diagonal line */
        //        pen.Color = Color.MintCream;
        //        canvas.DrawLine(pen, 250, 150, 400, 250);

        //        /* A PaleVioletRed rectangle */
        //        pen.Color = Color.PaleVioletRed;
        //        canvas.DrawRectangle(pen, 350, 350, 80, 60);

        //        Console.ReadKey();

        //        /* Let's try to change mode...*/
        //        canvas.Mode = new Mode(800, 600, ColorDepth.ColorDepth32);

        //        /* A LimeGreen rectangle */
        //        pen.Color = Color.LimeGreen;
        //        canvas.DrawRectangle(pen, 450, 450, 80, 60);

        //        Console.ReadKey();

        //        Stop();
        //    }
        //    catch (Exception e)
        //    {
        //        mDebugger.Send("Exception occurred: " + e.Message);
        //        mDebugger.Send(e.Message);
        //        Stop();
        //    }
        //}

        public override void Execute()
        {
            Console.WriteLine("Draw Initialization Behavior executing...");
            ActivateGraphicalMode();
        }
    }
}
