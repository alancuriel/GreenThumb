using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenThumb.Client.Models
{
    public class GridItem
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string ColorString { get; set; }
        public string Text { get; set; }
        public GridType GridType {get; set;} = GridType.GRASS;

    }
}
