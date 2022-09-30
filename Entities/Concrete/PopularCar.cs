using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class PopularCar:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
    }
}
