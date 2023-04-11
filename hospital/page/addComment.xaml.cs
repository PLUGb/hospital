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
    /// Логика взаимодействия для addComment.xaml
    /// </summary>
    public partial class addComment : Page
    {
        private doctor doctor = new doctor();
        public addComment(doctor selectedUser)
        {
            InitializeComponent();
            CmbPatientId.ItemsSource = odbConnectHelper.poliklinikEntities.doctor.ToList();
            CmbPatientId.SelectedValuePath = "rating";
            CmbPatientId.DisplayMemberPath = "Fullname";
            if (selectedUser != null)
            {
                doctor = selectedUser;
            }
            DataContext = doctor;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
