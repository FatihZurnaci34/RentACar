using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PopularCarDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public decimal DailyPrice { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }

    }
}
