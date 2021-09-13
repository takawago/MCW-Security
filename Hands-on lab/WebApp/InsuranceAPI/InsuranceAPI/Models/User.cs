using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceAPI.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime? Dob { get; set; }
        public string SSN { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}