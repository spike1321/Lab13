using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Building
    {
        string address;
        int length;
        int width;
        int height;

        public string Aaddress
        {
            get
            {
                return address;
            }
            set 
            {
                if (string.IsNullOrEmpty(value) || int.TryParse(value, out int b))
                {
                    address = "Не введён адрес здания!";
                }
                else
                {
                    address = value;
                }
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (int.TryParse(value.ToString(), out int b))
                {
                    if (b > 0)
                    {
                        length = value;
                    }
                }
                else
                {
                    length = 0;
                }
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (int.TryParse(value.ToString(), out int b))
                {
                    if (b > 0)
                    {
                        width = value;
                    }
                }
                else
                {
                    width = 0;
                }
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (int.TryParse(value.ToString(), out int b))
                {
                    if (b > 0)
                    {
                        height = value;
                    }
                }
                else
                {
                    height = 0;
                }
            }
        }

        public Building(string address_, int length_, int width_, int height_)
        {
            this.Aaddress = address_;
            this.Length = length_;
            this.Width = width_;
            this.Height = height_;
        }
        public string Print()
        {
            return @"Адрес здания: "+ address+ "\nДлина здания: " + length + "\nШирина здания: " + width + "\nВысота здания: " + height;
        }
    }
}
