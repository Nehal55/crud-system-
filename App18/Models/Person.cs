using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App18.Models
{
    public class Person
    {
        [Required]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }



        [Range(18,60)]
        public int Age { get; set; }


     
        [Required]
        [StringLength(100)]
        public string Country{ get; set; }

    }
}
