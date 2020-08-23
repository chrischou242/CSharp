using System;
using System.ComponentModel.DataAnnotations;


namespace Chefs_N_Dishes.CustomValidation
{
    public class PastDateAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object Value, ValidationContext validationContext)
        {

            if(Value != null)
            {
                DateTime date = (DateTime)Value;
                if(DateTime.Now.Date > date.Date)
            {
                return ValidationResult.Success;
            }
            }
            return new ValidationResult("Must be in the past date");
              
        }
    }
}