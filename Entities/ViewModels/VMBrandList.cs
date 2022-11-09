using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class VMBrandList
    {
        public List<VehicleModel> data { get; set; }
    }

    public class VehicleModel
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
