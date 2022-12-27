using KrasnovExam2022.DataBase;
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
    /// Логика взаимодействия для WinADDClient.xaml
    /// </summary>
    public partial class WinADDClient : Window
    {
        public event Action AddClients;
        public WinADDClient()
        {
            InitializeComponent();
        }
        private void BtnADDtoDB_Click(object sender, RoutedEventArgs e)
        {
            var client1s = App.DB.Clients.Where(x => x.Phone == TbPhoenCl.Text.Trim().ToLower().ToUpper()).FirstOrDefault(); //Проверка Клиента по телефону на совпадение в БД
            if (client1s != null)
            {
                MessageBox.Show("Клиент с таким телефоном уже есть!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TbFirstNameCL.Text.Trim() == "" || TbNameCl.Text.Trim() == "" || TbSurNameCl.Text.Trim() == "" || TbPhoenCl.Text.Trim() == "")
            {
                MessageBox.Show("Пожалуйста не оставляйте поля пустыми!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                Clients clients = new Clients();
                {
                    clients.Id_Client = clients.Id_Client;
                    clients.Name = TbNameCl.Text.Trim();
                    clients.Surname = TbSurNameCl.Text.Trim();
                    clients.FirsName = TbFirstNameCL.Text.Trim();
                    clients.Phone = TbPhoenCl.Text.Trim();
                }
                App.DB.Clients.Add(clients);
                App.DB.SaveChanges();
                AddClients?.Invoke();
                MessageBox.Show("Добавление произошло успешно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                TbNameCl.Clear();
                TbPhoenCl.Clear();
                TbSurNameCl.Clear();
                TbFirstNameCL.Clear();
            }

        }
    }
}
