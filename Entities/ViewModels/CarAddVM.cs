﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class CarAddVM
    {
        public string Name { get; set; }
        public short ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Description { get; set; }

    }
}
