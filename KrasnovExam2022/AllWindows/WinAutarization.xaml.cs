using KrasnovExam2022.AllWindows;
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

namespace KrasnovExam2022
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WinAutarization : Window
    {
        public WinAutarization()
        {
            InitializeComponent();
        }

        private void BtnLOGApp_Click(object sender, RoutedEventArgs e)
        {
            if(TbLOG.Text.Trim() == "" || PbLog.Password.Trim() == "")
            {
                MessageBox.Show("Пожалуйста не оставляйте поля логина или пароля пустыми!","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            else foreach (var user in App.DB.Auths)
                {
                    if(user.Login == TbLOG.Text.Trim())
                    {
                        if(user.Password == PbLog.Password.Trim() && user.Users.Roles.Id_Role == 1)
                        {
                            MessageBox.Show($"С возвращением,ваш id : {user.Id_User} , ваша роль : {user.Users.Roles.Name_Role}", "Привет!", MessageBoxButton.OK, MessageBoxImage.Information);
                            App.users = user.Users;
                            AdminWin adminWin = new AdminWin();
                            adminWin.Show();
                            Close();
                        }
                    } 
                    if(user.Login == TbLOG.Text.Trim())
                    {
                        if(user.Password == PbLog.Password.Trim() && user.Users.Roles.Id_Role == 2)
                        {
                            MessageBox.Show($"С возвращением,ваш id : {user.Id_User} , ваша роль : {user.Users.Roles.Name_Role}", "Привет!", MessageBoxButton.OK, MessageBoxImage.Information);
                            App.users = user.Users;
                            EmployeeSkladWin employeeSkladWin = new EmployeeSkladWin();
                            employeeSkladWin.Show();
                            Close();
                        }
                    } 
                    if(user.Login == TbLOG.Text.Trim())
                    {
                        if(user.Password == PbLog.Password.Trim() && user.Users.Roles.Id_Role == 3)
                        {
                            MessageBox.Show($"С возвращением,ваш id : {user.Id_User} , ваша роль : {user.Users.Roles.Name_Role}", "Привет!", MessageBoxButton.OK, MessageBoxImage.Information);
                            App.users = user.Users;
                            EmployeeShopMasterWin employeeShopMasterWin = new EmployeeShopMasterWin();
                            employeeShopMasterWin.Show();
                            Close();
                        }
                    } 
                    if(user.Login == TbLOG.Text.Trim())
                    {
                        if(user.Password == PbLog.Password.Trim() && user.Users.Roles.Id_Role == 4)
                        {
                            MessageBox.Show($"С возвращением,ваш id : {user.Id_User} , ваша роль : {user.Users.Roles.Name_Role}", "Привет!", MessageBoxButton.OK, MessageBoxImage.Information);
                            App.users = user.Users;
                            VladelecWin vladelecWin = new VladelecWin();
                            vladelecWin.Show();
                            Close();
                        }
                    }
                }
            if(App.users == null)
            {
                MessageBox.Show("Такого пользователя не существует повторите попытку", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                TbLOG.Clear();
                PbLog.Clear();
                return;
               
            }
        }
    }
}
