using Core;
using System;
using Entities.DTOs;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentCarDetailDto: IDto
    {
        public int RentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CarName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
