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
        Factory f = new Factory();
        Ship s = new Ship();
        Container c = new Container();

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
            if (Get_fit() == false)
            {
                Get_containers();
            }
            else
            {
                Sort_containers();

                if (c.Type == 1)
                {
                    Check();
                }
                else if (c.Type == 2)
                {
                    Check();
                }
                else if (c.Type == 3)
                {
                    Check();
                }
                else if (c.Type != 1 && c.Type != 2 && c.Type != 3)
                {
                    Check();
                }
            }
        }
        public void Check()
        {
            if (Width() == true)
            {
                containers.Add(c);
                if (Cool() == false && Normal() == false && Empty() == false)
                {
                    if (Valuable() == true)
                    {
                        containers.Add(c);
                    }
                    else if (Valuable() == false)
                    {
                        Visualise_ship = true;
                    }
                }
                else
                {
                    Set_row();
                }
            }
            else if (Width() == false)
            {
                if (Length() == true)
                {
                    Row row = new Row();

                    if (Cool() == false && Normal() == false && Empty() == false)
                    {
                        if (Valuable() == true)
                        {
                            containers.Add(c);
                        }
                        else if (Valuable() == false)
                        {
                            Visualise_ship = true;
                        }
                    }
                    else
                    {
                        Set_row();
                    }
                }
                else if (Length() == false)
                {
                    Layer layer = new Layer();

                    if (Cool() == false && Normal() == false && Empty() == false)
                    {
                        if (Valuable() == true)
                        {
                            containers.Add(c);
                        }
                        else if (Valuable() == false)
                        {
                            Visualise_ship = true;
                        }
                    }
                    else
                    {
                        Set_row();
                    }
                }
            }
        }

        // sort
        public void Get_containers()
        {
            ToBe_sorted = f.Get_random_containers();
        }

        public bool Get_fit()
        {
            if (containers.Count() > s.Max_containers())
            {
                containers.Clear();
                ToBe_sorted.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Container> Sort_containers()
        {
            foreach (Container cool in ToBe_sorted)
            {
                if (c.Type == 1)
                {
                    containers.Add(c);
                }
                foreach (Container normal in ToBe_sorted)
                {
                    if (c.Type == 2)
                    {
                        containers.Add(c);
                    }
                    foreach (Container empty in ToBe_sorted)
                    {
                        if (c.Type != 1 && c.Type != 2 && c.Type != 3)
                        {
                            containers.Add(c);
                        }
                        foreach (Container valuable in ToBe_sorted)
                        {
                            if (c.Type == 3)
                            {
                                containers.Add(c);
                            }
                        }
                    }
                }
            }
            ToBe_sorted.Clear();
            return containers;
        }

        //

        // 

        public bool Width()
        {
            if (containers.Count < s.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Cool()
        {
            if (Convert.ToInt32(containers.First().Type) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Valuable()
        {
            if (Convert.ToInt32(containers.First().Type) == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Normal()
        {
            if (Convert.ToInt32(containers.First().Type) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Empty()
        {
            if (Convert.ToInt32(containers.First().Type) != 1 && Convert.ToInt32(containers.First().Type) != 2 && Convert.ToInt32(containers.First().Type) != 3)
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
