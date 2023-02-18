using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.CarDTOs
{
    public class BrandDetailDto : IDto
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

    }
}
