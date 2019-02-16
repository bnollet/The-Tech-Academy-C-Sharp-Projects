using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insurance_Project.Models
{
    public class InsuranceSignIn
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string CarYear { get; set; }
        public string Email { get; set; }
        public int Tickets { get; set; }
        public decimal price { get; set; }
        public string Coverage { get; set; }
    }
}