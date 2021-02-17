using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }


    }
}
