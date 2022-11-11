using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class VMCarUpdate
    {
        public VMCar data { get; set; }
    }

    public class VMCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Description { get; set; }
    }
}
