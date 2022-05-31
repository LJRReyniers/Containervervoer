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

        // place
        List<Row> rows = new List<Row>();
        private bool visualise_ship = false;

        // place
        public bool Visualise_ship { get { return this.visualise_ship; } set { this.visualise_ship = value; } }
        public bool Length(Ship ship)
        {
            if (rows.Count < ship.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Layer> Layout()
        {
            // return list( layers( rows( containers ) ) )
        }
        public void Set_row(Factory factory, Ship ship, Container container)
        {
            Get_containers(factory);
            if (Get_fit(ship) == false)
            {
                Get_containers(factory);
            }
            else
            {
                Sort_containers(container);

                if (container.Type == 1)
                {
                    Check(factory, ship, container);
                }
                else if (container.Type == 2)
                {
                    Check(factory, ship, container);
                }
                else if (container.Type == 3)
                {
                    Check(factory, ship, container);
                }
                else if (container.Type != 1 && container.Type != 2 && container.Type != 3)
                {
                    Check(factory, ship, container);
                }
            }
        }
        public void Check(Factory factory, Ship ship, Container container)
        {
            if (Width(ship) == true)
            {
                containers.Add(container);
                if (Cool() == false && Normal() == false && Empty() == false)
                {
                    if (Valuable() == true)
                    {
                        containers.Add(container);
                    }
                    else if (Valuable() == false)
                    {
                        Visualise_ship = true;
                    }
                }
                else
                {
                    Set_row(factory, ship, container);
                }
            }
            else if (Width(ship) == false)
            {
                if (Length(ship) == true)
                {
                    Row row = new Row();

                    if (Cool() == false && Normal() == false && Empty() == false)
                    {
                        if (Valuable() == true)
                        {
                            containers.Add(container);
                        }
                        else if (Valuable() == false)
                        {
                            Visualise_ship = true;
                        }
                    }
                    else
                    {
                        Set_row(factory, ship, container);
                    }
                }
                else if (Length(ship) == false)
                {
                    Layer layer = new Layer();

                    if (Cool() == false && Normal() == false && Empty() == false)
                    {
                        if (Valuable() == true)
                        {
                            containers.Add(container);
                        }
                        else if (Valuable() == false)
                        {
                            Visualise_ship = true;
                        }
                    }
                    else
                    {
                        Set_row(factory, ship, container);
                    }
                }
            }
        }

        // sort
        public void Get_containers(Factory factory)
        {
            ToBe_sorted = factory.Get_random_containers();
        }

        public bool Get_fit(Ship ship)
        {
            if (containers.Count() > ship.Max_containers())
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

        public List<Container> Sort_containers(Container container)
        {
            foreach (Container cool in ToBe_sorted)
            {
                if (container.Type == 1)
                {
                    containers.Add(container);
                }
                foreach (Container normal in ToBe_sorted)
                {
                    if (container.Type == 2)
                    {
                        containers.Add(container);
                    }
                    foreach (Container empty in ToBe_sorted)
                    {
                        if (container.Type != 1 && container.Type != 2 && container.Type != 3)
                        {
                            containers.Add(container);
                        }
                        foreach (Container valuable in ToBe_sorted)
                        {
                            if (container.Type == 3)
                            {
                                containers.Add(container);
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

        public bool Width(Ship ship)
        {
            if (containers.Count < ship.Width)
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
