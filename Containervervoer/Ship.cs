﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer
{
    public class Ship
    {
        List<Layer> layers = new List<Layer>();

        private int weight;
        private int height = 3;
        private int width = 5;
        private int length = 5;
        int tot_load;
        int max_weight;
        int amount;
        int percent_load;
        int max_containers;

        public int Weight { get { return this.weight; } set { this.weight = value; } }
        public int Height { get { return this.height; } set { this.height = value; } }
        public int Width { get { return this.width; } set { this.width = value; } }
        public int Length { get { return this.length; } set { this.length = value; } }

        public Ship()
        {
            max_containers = Height * Width * Length;
        }

        public int Max_containers()
        {
            return max_containers;
        }
        public void Max_weight(int height, int width)
        {
            max_weight = height * width * 30000;
        }
        public void Tot_amount(int aant_normal, int aant_valuable, int aant_cool)
        {
            amount = aant_normal + aant_valuable + aant_cool;
        }
        public void Tot_load(int amount, int aant_empty)
        {
            tot_load = amount + aant_empty;
        }
        public void Percent_load(int tot_load)
        {
            percent_load = tot_load / 100 * 20;
        }
        public void Get_layout()
        {

        }
    }
}