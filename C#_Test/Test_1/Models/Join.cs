using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test_1.Models
{
    public class Join
    {
        [Key]
        public int JoinId {get;set;}

        public int UserId{get;set;}
        public User Guest{get;set;}

        public int ActivitiesId {get;set;}

        public Activityy activities{get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}