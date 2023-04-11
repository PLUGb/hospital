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
    /// Логика взаимодействия для history.xaml
    /// </summary>
    public partial class history : Page
    {
        public history()
        {
            InitializeComponent();
            MaterialList.ItemsSource = odbConnectHelper.poliklinikEntities.history.Take(15).ToList();

        }

        private void MaterialList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                MaterialList.ItemsSource = odbConnectHelper.poliklinikEntities.history.Take(15).ToList();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Упс, что-то пошло не так!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MaterialList.ItemsSource = odbConnectHelper.poliklinikEntities.history.Where(x => x.disease.Contains(TxbSearch.Text)).Take(15).ToList();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
