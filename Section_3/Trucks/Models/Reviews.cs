using System;
using System.ComponentModel.DataAnnotations;
namespace Trucks.Models
{
    public class Review
    {
        [Key]
        public int ReviewId {get;set;}

        [Required(ErrorMessage="is required")]
        public string Body {get;set;}

        [Required(ErrorMessage="is required")]
        [Range(1,5, ErrorMessage="Rating must be between 1 and 5")]
        public int? Rating{get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int UserId {get;set;}

        public int TruckId{get;set;}

        public User Author{get;set;}

        public Truck Truck {get;set;}
    }
}