using KrasnovExam2022.DataBase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KrasnovExam2022
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static  ShopEnitites DB = new ShopEnitites();
        public static Users users;
        public static Auths auths;
    }
}
