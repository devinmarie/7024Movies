using _7024Movies.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _7024Movies.Models
{
    public class MovieReviewComedy
    {
        public int MovieReviewComedyId { get; set; }

        [DisplayName("Movie")]
        [Required]
        [DataType(DataType.Text)]
        public string MovieNameC { get; set; }

        [DisplayName("User Reviews")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string MovieReviewC { get; set; }




    }
}
