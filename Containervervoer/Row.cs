using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer
{
    public class Row
    {
        List<Container> containers = new List<Container>();
        List<Container> ToBe_sorted = new List<Container>();

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
        public void Get_containers(Factory factory)
        {
            ToBe_sorted = factory.Get_random_containers();
        }

        public List<Container> Sort_containers(Container container)
        {
            foreach (Container cool in ToBe_sorted)
            {
                int type = container.Get_type();
                if (type == 1)
                {
                    containers.Add(container);
                }
                foreach (Container normal in ToBe_sorted)
                {
                    if (type == 2)
                    {
                        containers.Add(container);
                    }
                    foreach (Container empty in ToBe_sorted)
                    {
                        if (type != 1 && type != 2 && type != 3)
                        {
                            containers.Add(container);
                        }
                        foreach (Container valuable in ToBe_sorted)
                        {
                            if (type == 3)
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
    }
}
