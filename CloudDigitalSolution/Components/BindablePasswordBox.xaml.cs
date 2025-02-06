using System.Windows;
using System.Windows.Controls;

namespace CloudDigitalSolution.Components
{
    /// <summary>
    /// Interaction logic for BindablePassword.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        public static readonly DependencyProperty PasswordProperty
            = DependencyProperty.Register("Password", typeof(string),
                                        typeof(BindablePasswordBox),
                                        new PropertyMetadata(string.Empty));

        public BindablePasswordBox()
        {
            InitializeComponent();
        }

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public void Password_Changed(object sender, RoutedEventArgs e)
        {
            Password = BindablePassword.Password;
        }
    }
}