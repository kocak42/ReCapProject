﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.CarDTOs
{
   public class CarDetailsDto:IDto
    {
        public int CarsId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public DateTime ModelYear { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ImagePath { get; set; }
        public string ModelName { get; set; }
    }
}
