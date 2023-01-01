using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Entities.DTOs
{

    public class GetCarDetailDto
    {
        public List<CarDetailDto> data { get; set; }
    }
    public class CarDetailDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }
}
