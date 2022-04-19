using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer
{
    class Schip
    {
        int gewicht;
        int hoogte;
        int breedte;
        int tot_lading;
        int max_gewicht;
        int hoeveelheid;
        int percent_lading;
        public void Max_gewicht(int hoogte, int breedte)
        {
            max_gewicht = hoogte * breedte * 30000;
        }
        public void Tot_hoeveelheid(int aant_normaal, int aant_waardevol, int aant_gekoeld, int aant_beide)
        {
            hoeveelheid = aant_normaal + aant_waardevol + aant_gekoeld + aant_beide;
        }
        public void Tot_lading(int hoeveelheid, int aant_leeg)
        {
            tot_lading = hoeveelheid + aant_leeg;
        }
        public void Percent_lading(int tot_lading)
        {
            percent_lading = tot_lading / 100 * 20;
        }
        public void Get_rij()
        {

        }
        public void Get_indeling()
        {

        }
    }
}
