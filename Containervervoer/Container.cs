using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer
{
    class Container
    {
        int weight;
        int weight_empty = 4000;
        int weight_full = 30000;
        int weight_top_max = 120000;
        int type;
        bool valuable;
        bool cool;
        bool content;
        public Container(int type)
        {
            if (type == 1)
            {
                weight = 30000;
            }
            else
            {
                weight = 4000;
            }
        }
    }
}
