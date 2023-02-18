using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.CarDTOs
{
    public class UserDetailDto
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }


    }
}
