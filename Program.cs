using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Implement start position, width and height, symbol, message input

                //Create Box class instance

                //Use  Box.Draw() method

                Console.WriteLine("Type a message");


                Box box = new Box() { Message = Console.ReadLine() };
                box.FillTestData();
                box.Draw();

                Console.WriteLine("Press any enter key...");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error! {e.Message}");
                Console.ReadKey();
            }
            
        }
    }
}
