using System.ComponentModel.DataAnnotations;

namespace CloudDigitalSolution.ViewModel
{
    public class UserViewModel
    {
        // public string this[string columnName] => throw new NotImplementedException();

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

        public long MobileNumber { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression("/(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8}/g", ErrorMessage = "Password must meet requirements")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //public string Error => throw new NotImplementedException();

        //public string this[string propertyName]
        //{
        //    get
        //    {
        //        switch (propertyName)
        //        {
        //            case "UserName":
        //                return ValidateProperty(this.UserName, propertyName);

        //            case "FirstName":
        //                return ValidateProperty(this.FirstName, propertyName);

        //            case "LastName":
        //                return ValidateProperty(this.LastName, propertyName);

        //            case "EmailAddress":
        //                return ValidateProperty(this.EmailAddress, propertyName);

        //            case "Gender":
        //                return ValidateProperty(this.Gender, propertyName);

        //            default:
        //                return string.Empty;
        //        };
        //    }
        //}

        //protected string ValidateProperty(object value, string propertyName)
        //{
        //    var info = this.GetType().GetProperty(propertyName);
        //    IEnumerable<string> errorInfos =
        //          (from va in info.GetCustomAttributes(true).OfType<ValidationAttribute>()
        //           where !va.IsValid(value)
        //           select va.FormatErrorMessage(string.Empty)).ToList();

        //    if (errorInfos.Count() > 0)
        //    {
        //        return errorInfos.FirstOrDefault<string>();
        //    }
        //    return null;
        //}
    }
}