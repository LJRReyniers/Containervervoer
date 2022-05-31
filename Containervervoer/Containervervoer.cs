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
        Sort sort = new Sort();

        public Containervervoer()
        {
            InitializeComponent();
        }
        
        private void Containervervoer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sort.Layout());
            sort.Set_row();
            if (sort.Visualise_ship == true)
            {
                pictureBox1.Image = Properties.Resources.ship;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.wrong;
            }
        }
    }
}
