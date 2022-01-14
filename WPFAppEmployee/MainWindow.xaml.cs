using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DAL_SQLite_;
using Library_BLL;

namespace WPFAppEmployee
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            bool isLogin, isPass, isPass2, isEmail;
            string login, pass, pass2, email;
            login = txtBoxLogin.Text.Trim();
            email = txtBoxEmail.Text.Trim().ToLower();
            pass = passBox.Password.Trim();
            pass2 = passBoxRepeat.Password.Trim();
            do
            {
                if (login.Length < 5)
                {
                    isLogin = true;
                    txtBoxLogin.ToolTip = "Login is too short !";
                    txtBoxLogin.Background = Brushes.Red;
                }
                else
                {
                    isLogin = false;
                    txtBoxLogin.ToolTip = "";
                    txtBoxLogin.Background = Brushes.Transparent;
                }

                if (pass.Length < 5)
                {
                    isPass = true;
                    passBox.ToolTip = "Password is too short !";
                    passBox.Background = Brushes.Red;
                }
                else
                {
                    isPass = false;
                    passBox.ToolTip = "";
                    passBox.Background = Brushes.Transparent;
                }

                if (pass != pass2)
                {
                    isPass2 = true;
                    passBoxRepeat.ToolTip = "Your passwords don't equal's";
                    passBoxRepeat.Background = Brushes.Red;
                }
                else
                {
                    isPass2 = false;
                    passBoxRepeat.ToolTip = "";
                    passBoxRepeat.Background = Brushes.Transparent;
                }

                if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
                {
                    isEmail = true;
                    txtBoxEmail.ToolTip = "Your Email doesn't correct !";
                    txtBoxEmail.Background = Brushes.Red;
                }
                else
                {
                    isEmail = false;
                    txtBoxEmail.ToolTip = "";
                    txtBoxEmail.Background = Brushes.Transparent;
                }
            } while (isLogin == true && isPass == true && isPass2 == true && isEmail == true);
            Employee employee = new Employee(login, pass, email);
            EmployeeHelper helper = new EmployeeHelper();
            helper.AddEmployee(employee);
            MessageBox.Show("U've been registered !");
        }
    }
}
