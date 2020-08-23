using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Test_1.Models
{
    public class Activityy
    {
        [Key]
        public int ActivityId {get;set;}

        [Required(ErrorMessage="Must have an Activity")]
        public string Title{get;set;}


        [Required(ErrorMessage="Must have a Date Time")]
        [DataType(DataType.DateTime)]
        public DateTime Time{get;set;}

        [Required(ErrorMessage="Must have a Description")]
    
        public string Description{get;set;}
        
        [Required]
        [Display(Name="Duration")]
        public int HowLong {get;set;}
        public string Length{get;set;}
       

        public int UserId {get;set;}

        public User Activiting {get;set;}

        public List<Join> PeopleJoining {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

      



        


        

        
    }
}
