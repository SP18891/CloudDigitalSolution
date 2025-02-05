using System.Windows;

namespace CloudDigitalSolution.UI;

/// <summary>
/// Interaction logic for UserRegistration.xaml
/// </summary>
public partial class UserRegistration : Window
{
    public UserRegistration()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        FirstName.Text = string.Empty;
        LastName.Text = string.Empty;
        EmailAddress.Text = string.Empty;
        Gender.Text = string.Empty;
        MobileNumber.Text = string.Empty;
        Password.Text = string.Empty;
        ConfirmPassword.Text = string.Empty;
    }
}