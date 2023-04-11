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
    /// Логика взаимодействия для log.xaml
    /// </summary>
    public partial class log : Page
    {
        public log()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            var userObj = odbConnectHelper.poliklinikEntities.user.FirstOrDefault(
           x => x.login == login.Text && x.password == pass.Text);

            if (userObj == null)
            {
                MessageBox.Show("Такой пользователь не найден.",
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
                frmName.frmObj.Navigate(new reg());

            }
            else
            {
                switch (userObj.idRole)
                {
                    case 2:
                        frmName.frmObj.Navigate(new patient());
                        break;

                    case 1:
                        frmName.frmObj.Navigate(new doctor());
                        break;

                }
            }
            }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            frmName.frmObj.Navigate(new reg());
        }
    }
}
