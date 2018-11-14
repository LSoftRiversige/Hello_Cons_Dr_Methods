using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    public class Box
    {
        private Random MyRandom;
        private int Delta;

        public Box()
        {
            StartPosition = new Point();
            MyRandom = new Random();
        }


        public void FillTestData()
        {
            StartPosition.Left = 2;
            StartPosition.Top = 5;

            //Message = "Message from user input that is very long...";
            //Message = message;

            

            Width = Message.Length;
            Delta = 10;
            Height = Width < Delta ? Delta : Width / 2 ;

            ValidCharacters = new char[] { '#', '@', '*', '%', '|', '\\', '?', '^', ':', '(', ')', '{', '}', '=', '+' };
        }


       //1.  Implement public  auto-implement properties for start position (point position)
        public Point StartPosition { get; set; }

        //auto-implement properties for width and height of the box
        public int Width { get; set; }
        public int Height { get; set; }

        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        public char[] ValidCharacters { get; set; }

        //and a message inside the box
        public string Message { get; set; }

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message
        public void Draw()
        {
            DrawBox();
            PlaceCursor(StartPosition.Left + Delta, StartPosition.Top + Height/2);
            Console.Write(Message);
            PlaceCursor(StartPosition.Left, StartPosition.Top + Height+2);
        }

        private void DrawBox()
        {
            PlaceCursor(StartPosition);
            WriteCharLine();
            WriteSides(Height, StartPosition.Top);
            PlaceCursor(StartPosition.Left, StartPosition.Top + Height - 1);
            WriteCharLine();
        }

        private void WriteSides(int messageHeight, int startTop)
        {
            for (int i = 1; i < messageHeight - 1; i++)
            {
                PlaceCursor(StartPosition.Left, startTop+i);
                Console.Write(DefineChar());
                PlaceCursor(StartPosition.Left + Width+2*Delta, startTop+i);
                Console.Write(DefineChar());
            }
        }

        public void PlaceCursor(int left, int top)
        {
            Console.CursorLeft = left > Console.LargestWindowWidth ? Console.LargestWindowWidth : left;
            Console.CursorTop = top > Console.LargestWindowHeight ? Console.LargestWindowHeight : top;
        }

        public void PlaceCursor(Point p)
        {
            PlaceCursor(p.Left, p.Top);
        }

        public char DefineChar()
        {
            
            return ValidCharacters[MyRandom.Next(0, ValidCharacters.Length - 1)];
        }

        private void WriteCharLine()
        {
            for (int i = 0; i <= Width+2*Delta; i++)
            {
                Console.Write(DefineChar());
            }
        }

        public class Point
        {
            public int Top;
            public int Left;
            
        }



        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary


    }
}
