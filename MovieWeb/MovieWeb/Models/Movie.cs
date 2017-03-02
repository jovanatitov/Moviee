using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieWeb.Models
{
    public class Movie
    {
        public string ID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string Genre { get; set; }
        public string Director { get; set; }
        [DataType(DataType.Date)]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public string DateOfRelease { get; set; }
        


    }
}