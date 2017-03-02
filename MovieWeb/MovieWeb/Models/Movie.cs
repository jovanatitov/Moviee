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
        public string Name { get; set; }
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string Genre { get; set; }
        public string Director { get; set; }
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfRelease { get; set; }
        

    }
}