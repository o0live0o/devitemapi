using System.ComponentModel.DataAnnotations;

namespace devitemapi.Attributes
{
    public class RegexValidateAttribute : ValidationAttribute
    {
        private string regex;

        public RegexValidateAttribute(string regex)
        {
            this.regex = regex;
        }

        public string GetErrorMsg => $"{regex} 校验失败";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}