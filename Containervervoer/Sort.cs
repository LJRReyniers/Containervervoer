using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer
{
    public class Sort
    {
        // sort
        List<Container> containers = new List<Container>();
        List<Container> ToBe_sorted = new List<Container>();
        List<Container> sorted = new List<Container>();
        Factory f = new Factory();
        Ship s = new Ship();
        Container c = new Container();
        int weight_containers = 0;

        // place
        List<Row> rows = new List<Row>();
        List<Layer> layers = new List<Layer>();
        private bool visualise_ship = false;

        // place
        public bool Visualise_ship { get { return this.visualise_ship; } set { this.visualise_ship = value; } }
        public bool Length()
        {
            if (rows.Count < s.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Container> Layout()
        {
            // return list( layers( rows( containers ) ) )
            return ToBe_sorted;
        }
        public void Set_row()
        {
            Get_containers();
            if (Get_fit() == false || Fifty_Max_Weight() == false)
            {
                Get_containers();
            }
            else
            {
                Sort_containers();
                Check();
            }
        }
        public void Check() //
        {
            if (Width() == true)
            {
                for (int i = 0; i < sorted.Count(); i++)
                {
                    if (sorted.Count() != 0)
                    {
                        containers.Add(sorted[i]);
                        if (Cool(i) == false && Normal(i) == false && Empty(i) == false)
                        {
                            if (Valuable(i) == true)
                            {
                                containers.Add(sorted[i]);
                            }
                            else if (Valuable(i) == false)
                            {
                                Visualise_ship = true;
                            }
                        }
                    }
                    Visualise_ship = true;
                }
            }
            else if (Width() == false)
            {
                if (Length() == true)
                {
                    Row row = new Row();

                    for (int i = 0; i < sorted.Count(); i++)
                    {
                        if (sorted.Count() != 0)
                        {
                            containers.Add(sorted[i]);
                            if (Cool(i) == false && Normal(i) == false && Empty(i) == false)
                            {
                                if (Valuable(i) == true)
                                {
                                    containers.Add(sorted[i]);
                                }
                                else if (Valuable(i) == false)
                                {
                                    Visualise_ship = true;
                                }
                            }
                        }
                        Visualise_ship = true;
                    }
                }
                else if (Length() == false)
                {
                    Layer layer = new Layer();

                    for (int i = 0; i < sorted.Count(); i++)
                    {
                        if (sorted.Count() != 0)
                        {
                            containers.Add(sorted[i]);
                            if (Cool(i) == false && Normal(i) == false && Empty(i) == false)
                            {
                                if (Valuable(i) == true)
                                {
                                    containers.Add(sorted[i]);
                                }
                                else if (Valuable(i) == false)
                                {
                                    Visualise_ship = true;
                                }
                            }
                        }
                        Visualise_ship = true;
                    }
                }
            }
        }

        // sort
        public List<Container> Get_containers()
        {
            ToBe_sorted = f.Get_random_containers();
            return ToBe_sorted;
        }

        public bool Get_fit()
        {
            if (ToBe_sorted.Count() > s.Max_containers())
            {
                containers.Clear();
                ToBe_sorted.Clear();
                sorted.Clear();
                return false;
            }
            else if (ToBe_sorted.Count == 0)
            {
                containers.Clear();
                ToBe_sorted.Clear();
                sorted.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Container> Containers(int t)
        {
            c.Type = t;
            sorted.Add(c);
            return sorted;
        }

        public List<Container> Sort_containers()
        {
                for (int i = 0; i < ToBe_sorted.Count(); i++)
                {
                    if (ToBe_sorted[i].Type == 1 && ToBe_sorted.Count() != 0)
                    {
                        c.Type = 1;
                        sorted.Add(c);
                    }
                    if (ToBe_sorted[i].Type == 2 && ToBe_sorted.Count() != 0)
                    {
                        c.Type = 2;
                        sorted.Add(c);
                    }
                    if (ToBe_sorted[i].Type != 1 && ToBe_sorted[i].Type != 2 && ToBe_sorted[i].Type != 3 && ToBe_sorted.Count() != 0)
                    {
                        sorted.Add(c);
                    }
                    if (ToBe_sorted[i].Type == 3 && ToBe_sorted.Count() != 0)
                    {
                        c.Type = 3;
                        sorted.Add(c);
                    }

                }
            
            ToBe_sorted.Clear();
            return sorted;
        }

        //

        // 

        public bool Fifty_Max_Weight()
        {
            for (int i = 0; i < sorted.Count(); i++)
            {
                weight_containers = weight_containers + sorted[i].Get_weight();
            }
            if (s.Max_weight(s.Height, s.Width) * 0.5 < weight_containers)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Width()
        {
            if (sorted.Count < s.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Cool(int i)
        {
            if (Convert.ToInt32(sorted[i].Type) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Valuable(int i)
        {
            if (Convert.ToInt32(sorted[i].Type) == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Normal(int i)
        {
            if (Convert.ToInt32(sorted[i].Type) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Empty(int i)
        {
            if (Convert.ToInt32(sorted[i].Type) != 1 && Convert.ToInt32(sorted[i].Type) != 2 && Convert.ToInt32(sorted[i].Type) != 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
