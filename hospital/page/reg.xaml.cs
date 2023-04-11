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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Page
    {
        public reg()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
           frmName.frmObj.NavigationService.GoBack();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (odbConnectHelper.poliklinikEntities.user.Count(x => x.login == txblogin.Text) < 1)
            {
                if (pass.Text == txbPass.Password)
                {
                    user user = new user
                    {
                        login = txblogin.Text,
                        password = txbPass.Password,
                        idRole = 2
                    };
                    odbConnectHelper.poliklinikEntities.user.Add(user);
                    odbConnectHelper.poliklinikEntities.SaveChanges();
                    frmName.frmObj.Navigate(new log());
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmName.frmObj.Navigate(new chooseClass());
        }
    }
}
