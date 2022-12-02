using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMasterclass
{
    internal class Box
    {
        // members variables
        private int length = 1;
        private int height = 1;
        private int width = 1;
        private int volume;

        public int Height
        {
            get { return height; }
            set {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public int Width
        {
            get { return width; }
            set { 
                if (value < 0)
                {
                    width = -value;
                }
                else
                {
                    width = value; 
                }
                
            }
        }
        public int Length
        {
            get { return length; }
            set { 
                if (value < 0)
                {
                    length = -value;
                }
                else
                {
                    length = value;
                }
            }
        }

        public int Volume
        {
            get { return width * length * height; }
        }

        public int FrontSurface
        {
            get { return length * height; }
        }


        // custom setter method to change private properties
        public void setDimensions(int length, int width, int height)
        {
            if (length <= 0 || width <= 0 || height <= 0)
            {
                throw new Exception("All dimensions must be greater than 0.");
            }

            this.length = length;
            this.width = width;
            this.height = height;
        }

        // custom getter method
        public int getVolume()
        {
            return volume = length * width * height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length}. Height is {height}. Width is {width}. That makes the volume {volume = length*width*height}.");
        }
    }
}
