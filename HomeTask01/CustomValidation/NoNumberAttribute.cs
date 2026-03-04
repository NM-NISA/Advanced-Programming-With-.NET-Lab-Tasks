using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HomeTask01.CustomValidation
{
    public class NoNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string name = value.ToString();

                if (Regex.IsMatch(name, @"\d"))
                {
                    return new ValidationResult("Name cannot contain numbers.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
