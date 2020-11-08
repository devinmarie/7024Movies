using _7024Movies.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _7024Movies.Models
{
    public class MovieReview
    {
        public int MovieReviewId { get; set; }

  

        [DisplayName("Review")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string MReviewText { get; set; }



    }
}
