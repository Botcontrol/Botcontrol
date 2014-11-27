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
using BotControlClient.CheckControl;

namespace BotControlClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var curClient = new CheckControlClient();
            var info = curClient.GetData();
            foreach (var checkResponse in info)
            {
                CurProblemBox.Items.Add("Ошибка - " + checkResponse.CodeNumber + " " + " " +
                                        checkResponse.CheckTime.ToString("hh':'mm':'ss") + " " +
                                        checkResponse.FolderName);
            }
        }
    }
}
