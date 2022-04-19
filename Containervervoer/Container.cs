using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer
{
    class Container
    {
        int gewicht;
        int gewicht_leeg = 4000;
        int gewicht_vol = 30000;
        int gewicht_bovenop_max = 120000;
        int soort;
        bool waardevol;
        bool gekoeld;
        bool inhoud;
        public Container(int soort)
        {
            if (soort == 1)
            {
                gewicht = 30000;
            }
            else
            {
                gewicht = 4000;
            }
        }
    }
}
