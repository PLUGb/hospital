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
using hospital.page;
using hospital.db;
using System.Windows.Media.Animation;

namespace hospital
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frmName.frmObj = frmMain;
            frmName.frmObj.Navigate(new log());
            odbConnectHelper.poliklinikEntities = new poliklinikEntities1();
        }

  
    }
}
