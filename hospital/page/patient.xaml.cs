using hospital.db;
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

namespace hospital.page
{
    /// <summary>
    /// Логика взаимодействия для patient.xaml
    /// </summary>
    public partial class patient : Page
    {
        public patient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmName.frmObj.Navigate(new doctorInfo());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frmName.frmObj.Navigate(new addComment(null));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frmName.frmObj.NavigationService.GoBack();
        }
    }
}
