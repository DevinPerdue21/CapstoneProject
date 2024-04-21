using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCapstone.Model
{
    public class Part
    {
        public int PartID {  get; set; }
        public string Name { get; set; }
        public int Inventory {  get; set; }
        public decimal Price { get; set; }

        public static int CurrentPartID { get; set; }
    }
}
