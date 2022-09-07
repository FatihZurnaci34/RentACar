using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
<<<<<<< HEAD
        public string Name { get; set; }
        public short ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
=======
        public int ModelYear { get; set; }
        public short DailyPrice { get; set; }
>>>>>>> 8e45ee2078170a9eeab8cc9ee6b39e2873e153bf
        public string Description { get; set; }

    }
}
