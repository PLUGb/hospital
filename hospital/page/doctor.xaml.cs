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
using System.Windows.Threading;
using hospital.db;


namespace hospital.page
{
    /// <summary>
    /// Логика взаимодействия для doctor.xaml
    /// </summary>
    public partial class doctor : Page
    {
  

        public doctor()
        {
            InitializeComponent();
        }
       
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            frmName.frmObj.Navigate(new history());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmName.frmObj.Navigate(new addDoctor(null));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frmName.frmObj.NavigationService.GoBack();
        }
    }
}
