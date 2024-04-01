using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using bd.db;

namespace bd
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            student1 users = new student1();
            users.login = login.Text;
            users.password = password.Text;
            users.name = name.Text;
            users.surname = surname.Text;
            users.Fields_of_study = feilds.Text;
            users.GPA = gpa.Text;

            Class1.db.student1.Add(users);
            Class1.db.SaveChanges();
            MessageBox.Show("Пользователь зарегестрирован!");
            var newForm = new MainWindow();
            newForm.Show();
            this.Close();
        }
        private void Button_click_4(object sender, RoutedEventArgs e)
        {
            var newForm = new Window4();
            newForm.Show();
        }


    }
}