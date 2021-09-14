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

namespace Steam_Accounts
{
    /// <summary>
    /// Логика взаимодействия для Window_Error.xaml
    /// </summary>
    public partial class Window_Error : Window
    {
        public Window_Error()
        {
            InitializeComponent();
        }

        private void border_win_d_MLBD(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void b_exit_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void b_error_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
