using System;
using System.ComponentModel.DataAnnotations;


namespace Crud.Models

{
    public class Post
    {
        [Key]
        public int PostId{get;set;}
        [Required]
        [MinLength(2, ErrorMessage ="Must be more than 2 characters.")]
        [MaxLength(45, ErrorMessage = "Must be less than 45 characters.")]

        public string Topic {get;set;}

        [Required]
        [MinLength(2,ErrorMessage="Must be more than 2 characters.")]
        public string Body {get;set;}
        public string ImgUrl{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;

        public DateTime UpdatedAt{get;set;} = DateTime.Now;
        
        public int UserId {get;set;}

        public User Author {get;set;}

    }
}