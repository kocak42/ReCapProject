using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.CarDTOs
{
    public class CustomerDetailDto : IDto
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
       
    }
}
