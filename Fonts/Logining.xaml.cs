using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TestingApp.DataBasesWork;
using TestingApp.ConstantManager;
namespace TestingApp
{
    /// <summary>
    /// Логика взаимодействия для Logining.xaml
    /// </summary>
    public partial class Logining : Window
    {
        DbManager manager;
        MainWindow mainWindow;
        public Logining(MainWindow mainWindow)
        {
            InitializeComponent();
            manager = new DbManager(new Context.TestContext());
            this.mainWindow = mainWindow;
            mainWindow.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = uName.Text;
            string pass = uPass.Password;
            //hash
            string flag = manager.ChekLogin(name,pass);
            //вызов функции
            if (flag==ConstManager.correctinfo)
            {
                mainWindow.Show();
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show(flag);
            }
            
        }
    }
}
