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
    /// Логика взаимодействия для addDoctor.xaml
    /// </summary>
    public partial class addDoctor : Page
    {
        private doctor _doctor = new doctor();
        public addDoctor(doctor selectedUser)
        {
            InitializeComponent();
            CmbPatientId.ItemsSource = odbConnectHelper.poliklinikEntities.doctor.ToList();
            CmbPatientId.SelectedValuePath = "rating";
            CmbPatientId.DisplayMemberPath = "fullName";
            if (selectedUser != null)
            {
                _doctor = selectedUser;
            }
            DataContext = _doctor;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             if (odbConnectHelper.poliklinikEntities.doctor.Count(x => x.fullName == TxbLogin.Text) < 1)
                        {
                            if (TxbPassword.Text == TxbPassword.Text)
                            {
                                user user = new user
                                {
                                    login = TxbLogin.Text,
                                    password = TxbPassword.Text,
                                };
                                odbConnectHelper.poliklinikEntities.user.Add(user);
                                odbConnectHelper.poliklinikEntities.SaveChanges();
                                frmName.frmObj.Navigate(new log());
                            }
                        }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmName.frmObj.NavigationService.GoBack();
        }
    }
}
