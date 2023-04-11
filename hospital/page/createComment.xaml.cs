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
    /// Логика взаимодействия для createComment.xaml
    /// </summary>
    public partial class createComment : Page
    {
        private doctor _product = new doctor();
        public createComment (doctor selectedUser)
        {
            InitializeComponent();
            CmbPatientId.ItemsSource = Class1.entObj.doctor.ToList();
            CmbPatientId.SelectedValuePath = "rating" ;
            CmbPatientId.DisplayMemberPath = "comment";
            if (selectedUser != null)
            {
                _product = selectedUser;
            }
            DataContext = _product;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           frmName.frmObj.GoBack();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmName.frmObj.NavigationService.GoBack();
        }
    }
}
