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
using WpfApp1.Model;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public List<Employee> empList;
        public MainWindow()
        {
            InitializeComponent();

            //empList = new List<Employee>();
            //for (int i = 0; i < 10; i++)
            //{
            //    empList.Add(new Employee() { Id = 10001 + i, Age = 21, Name = "张三" + i });
            //}
            //this.listBox.ItemsSource = empList;
            this.DataContext = new MainViewModel();
           
        }
    }
}
