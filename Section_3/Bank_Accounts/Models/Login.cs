using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_Accounts.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Required(ErrorMessage = "is required.")]
        [EmailAddress]
        [Display(Name ="Email")]
        public string LoginEmail {get; set;}

        [Required(ErrorMessage="is required.")]
        [MinLength(8, ErrorMessage = "must be atleast 8 characters")]
        [DataType(DataType.Password)]
        public string LoginPassword {get;set;}

    }
}