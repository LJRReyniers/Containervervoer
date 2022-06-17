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
            int r = t.Next(1, 3);
            Container container = new Container();
            container.Type = r;
            return container;
        }
        public List<Container> Get_random_containers()
        {
            List<Container> containers = new List<Container>();

            int r = t.Next(1, 3);
            int c = n.Next(0, 10);
            while (c > 0)
            {
                Container container = new Container();
                container.Type = r;
                containers.Add(container);
                c--;
            }
            return containers;
        }
    }
}
