using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _7024Movies.Models
{
    public class MovieReviewThriller
    {
              public int MovieReviewThrillerId { get; set; }

        [DisplayName("Title of Review")]
        [Required]
        [DataType(DataType.Text)]
        public string MovieNameT { get; set; }

        [DisplayName("User Reviews")]
            [Required]
            [DataType(DataType.MultilineText)]
            public string MovieReviewT{ get; set; }



        }
    }

