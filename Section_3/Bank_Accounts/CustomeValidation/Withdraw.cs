// using System;
// using System.ComponentModel.DataAnnotations;


// namespace Chefs_N_Dishes.CustomValidation
// {
//     public class WithdrawAttribute: ValidationAttribute
//     {
//         protected override ValidationResult IsValid(object Value, ValidationContext validationContext)
//         {

//             if(Value != null)
//             {
//                 Int money = (int)Value;
//                 if(Amount< date.D)
//             {
//                 return ValidationResult.Success;
//             }
//             }
//             return new ValidationResult("Must be in the past date");
              
//         }
//     }
// }

//                 DateTime date = (DateTime)Value;
//                 if(DateTime.Now.Date > date.Date)