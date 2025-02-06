using CloudDigitalSolution.ViewModel;
using System.ComponentModel.DataAnnotations;
using System.Windows;

namespace CloudDigitalSolution.UI;

/// <summary>
/// Interaction logic for UserRegistration.xaml
/// </summary>
public partial class UserRegistration : Window
{
    private UserViewModel user;

    public UserRegistration()
    {
        InitializeComponent();
        user = new UserViewModel();
        DataContext = user;
    }

    private void Reset(object sender, RoutedEventArgs e)
    {
        FirstName.Text = string.Empty;
        LastName.Text = string.Empty;
        EmailAddress.Text = string.Empty;
        Gender.Text = string.Empty;
        MobileNumber.Text = string.Empty;
        Password.Password = string.Empty;
        //ConfirmPassword.Password = string.Empty;
    }

    private void Register(object sender, RoutedEventArgs e)
    {
        var confirmPassword = ConfirmPassword.Password;
        var pass = Password.Password;
        if (pass != confirmPassword)
        {
            MessageBox.Show("Password and Confirm Password do not match");
            return;
        }
        user.Password = pass;
        var error = ValidateProperty(user);
        if (!string.IsNullOrEmpty(error))
        {
            MessageBox.Show(error);
            return;
        }
        MessageBox.Show("User Created");
        return;
    }

    protected string? ValidateProperty(UserViewModel userView)
    {
        ValidationContext vc = null;
        List<ValidationResult> validationResults = new List<ValidationResult>();

        vc = new ValidationContext(userView, null, null);
        var result = Validator.TryValidateObject(userView, vc, validationResults, true);
        if (!result)
        {
            return validationResults.First().ErrorMessage;
        }
        return string.Empty;
    }
}