using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Route { get; set; } // by zip code
    }
}