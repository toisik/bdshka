using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace bd.db
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public DbSet<Class2> student { get; set; }
        public Window2()
        {
            InitializeComponent();
            using (var context = new studentsEntities7())
            {
                dataGrid.ItemsSource = context.student1.ToList();
            }

        }

        private void Button_click_5(object sender, RoutedEventArgs e)
        {
            var newForm = new Window1();
            newForm.Show();
        }

        private void Button_click_4(object sender, RoutedEventArgs e)
        {
            using (var context = new studentsEntities7())
                dataGrid.ItemsSource = context.student1.ToList();
        }
    }
}



