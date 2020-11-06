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

        [DisplayName("Rooms")]
        [Range(1, 5, ErrorMessage = "Please rate the movie from 1=Best to 5=Worst")]
        [Required]
        public int MReviewScore { get; set; }

        [DisplayName("Review")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string MReviewText { get; set; }

        [DisplayName("Actors")]
        public List<ActorReview> ActorReviews { get; set; }

    }
}
