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

namespace IdealApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Name { get; set; }
        public string Password { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen; //spawn window in center
            Name = "Ricardo";
            Password = "kek2009";
            SetDefaultSettings();
        }

        private void Start_BTN_Click(object sender, RoutedEventArgs e)
        {
            if (Name == Name_TB.Text && Password == Password_TB.Text)
            {
                LobbyWindow lw = new LobbyWindow();
                lw.Show();
                this.Close();
            }

        }

        private void SetDefaultSettings()
        {
            Name_TB.Text = Name;
            Password_TB.Text = Password;
        }
    }
}
