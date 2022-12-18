using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingapp.Models
{
    public class Parking
    {
        public int id { get; set; }
        public int capacity { get; set; }
        public int free_spaces { get; set; }
        public int city_id { get; set; }
    }
}
