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
using bd.db;

namespace bd
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (studentsEntities7 db = new studentsEntities7())
            {
                List<student1> user = (from us in db.student1 where us.login == login.Text && us.password == password.Password select us).ToList();
                if (user.Count != 0)
                {
                    var Win = new Window2();
                    Win.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }


            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Win = new Window1();
            Win.Show();
            this.Close();
        }
    }
}
