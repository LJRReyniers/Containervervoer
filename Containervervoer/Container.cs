using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer
{
    public class Container
    {
        int weight;
        private int type;

        public int Type { get { return this.type; } set { this.type = value; } }

        public Container(int type)
        {
            if (type == 1)
            {
                weight = 30000;
            }
            if (type == 2)
            {
                weight = 30000;
            }
            if (type == 3)
            {
                weight = 30000;
            }
            else
            {
                weight = 4000;
            }
        }
        public int Get_weight()
        {
            return weight;
        }
        public int Get_type()
        {
            return type;
        }
    }
}
