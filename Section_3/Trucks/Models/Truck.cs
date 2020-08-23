using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Trucks.Models
{
    public class Truck
    {
        [Key]
        public int TruckId {get;set;}

        [Required(ErrorMessage="is required.")]
        [MinLength(2, ErrorMessage="must be at least {1} characters.")]
        public string Name{get;set;}
        [Required(ErrorMessage="is required.")]
        [MinLength(3, ErrorMessage="must be at least {1} characters.")]
        public string Style{get;set;}
        [Required(ErrorMessage="is required.")]
        [MinLength(10, ErrorMessage="must be at least {1} characters.")]
        public string Description{set;get;}



        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string ImgUrl {get;set;}

        public int UserId{get;set;}

        public User SubmittedBy {get;set;}
        public List<Review>    Reviews {get;set;}


    }
}