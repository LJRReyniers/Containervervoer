using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer
{
    public class Factory
    {
        

        Random t = new Random();
        Random n = new Random();

        public Container Get_random_container()
        {
            int r = t.Next(0, 3);
            Container container = new Container(r);
            return container;
        }
        public List<Container> Get_random_containers()
        {
            List<Container> containers = new List<Container>();

            int r = t.Next(0, 3);
            int c = n.Next(0, 10);
            while (c > 0)
            {
                containers.Add(new Container(r));
                c--;
            }
            return containers;
        }
    }
}
