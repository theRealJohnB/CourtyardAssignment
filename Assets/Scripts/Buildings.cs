using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class Buildings
    {
        public List<Building> buildings = new List<Building>();
        public int Add(Building b)
        {
            buildings.Add(b);
            return buildings.Count;
        }
    }
}
