using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containervervoer
{
    public partial class Containervervoer : Form
    {
        int aant_normaal;
        int aant_waardevol;
        int aant_gekoeld;
        int aant_beide;
        int aant_leeg;
        int hoeveelheid;
        int hoogte;
        int breedte;

        public Containervervoer()
        {
            InitializeComponent();
        }

        private void Containervervoer_Load(object sender, EventArgs e)
        {

        }
    }
}
