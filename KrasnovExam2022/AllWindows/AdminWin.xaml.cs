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
using System.Windows.Shapes;

namespace KrasnovExam2022.AllWindows
{
    /// <summary>
    /// Логика взаимодействия для AdminWin.xaml
    /// </summary>
    public partial class AdminWin : Window
    {
        public AdminWin()
        {
            InitializeComponent();
            ListPhones.ItemsSource = App.DB.Phones.ToList();
            ListClients.ItemsSource = App.DB.Clients.ToList();
        }
        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            WinADDClient winADDClient = new WinADDClient();
            winADDClient.AddClients += () => { ListClients.ItemsSource = App.DB.Clients.ToList(); };
            winADDClient.Show();
        }

        private void BtnUpdateList_Click(object sender, RoutedEventArgs e)
        {
            WinADDClient winADDClient = new WinADDClient();
            winADDClient.AddClients += () => { ListClients.ItemsSource = App.DB.Clients.ToList(); };
        }
    }
}
