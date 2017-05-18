using System;
using Microsoft.Build.Framework;

namespace SoapService
{
    public class Student
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        [Required]
        public string Id { get; set; }
    }
}
