using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
   sealed class MultiBuilding:Building
    {
        int floors;

        public int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                if (int.TryParse(value.ToString(), out int b))
                {
                    if (b > 0)
                    {
                        floors = value;
                    }
                }
                else
                {
                    floors = 0;
                }
            }
        }
        public MultiBuilding(string address_, int length_, int width_, int height_, int floors_)
        : base(address_,length_,width_,height_)
        {
            this.Floors = floors_;
        }

        public string Print()
        {
            string result = base.Print();
            result += "\nКол-во этажей: " + floors;
            return result;
        }
    }
}
