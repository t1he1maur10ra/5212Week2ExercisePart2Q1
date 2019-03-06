using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            int w = 0;
            int l = 0;

            h = GetData(h, "Height");
            w = GetData(w, "Width");
            l = GetData(l, "Length");

            Box b1 = new Box(h,w,l);

            Console.WriteLine(b1.GetSurfaceArea());
           

            Console.ReadLine();
        }

        static int GetData (int number, string info)
        {
            bool check = true;
            bool confirm = false;

            do
            {

                Console.Write($"Please enter the {info} of the box: ");
                confirm = int.TryParse(Console.ReadLine(), out number);
                do
                {
                    if (!confirm)
                    {
                        Console.Clear();
                        Console.Write($"Error, that was not a valid number please try again\nPlease enter the {info} of the box: ");
                        confirm = int.TryParse(Console.ReadLine(), out number);
                    }
                } while (!confirm);

                Console.WriteLine($"{info} Set\n\n");
                break;

            } while (check);
            return number;
        }
    }

    class Box
    {
        private int Height { get; set; }
        private int Width { get; set; }
        private int Length { get; set; }

        public Box(int _height, int _width, int _length)
        {
            Height = _height;
            Width = _width;
            Length = _length;
            Console.WriteLine("Box object created...");
        }

        public string GetSurfaceArea()
        {
            return $"The surface area of the box is: {2*(Height * Width) + 2 * (Height * Length) + 2 * (Length * Width)}";
        }
    }
}
