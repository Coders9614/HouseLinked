using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseLinked
{
    public class House
    {
        public int houseId { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public House Next { get; set; }

        public House(int houseid, string address, string type)
        {
            houseId = houseid;
            Address = address;
            Type = type;
            Next = null;
        }
    }

}
