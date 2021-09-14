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
    /// Логика взаимодействия для Window_Change_Way.xaml
    /// </summary>
    public partial class Window_Change_Way : Window
    {
        AppContext_for_way db;
        public Window_Change_Way()
        {
            InitializeComponent();
            db = new AppContext_for_way();
            Text_way.Text = "Укажите путь папки Steam";
            b_ok.IsEnabled = false;
        }

        private void b_exit_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void b_no_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void b_way_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            Text_way.Text = dialog.SelectedPath;
            if (Text_way.Text == "")
            {
                Text_way.Text = "Вы не указали путь папки Steam";
            }
            if (Text_way.Text == "Вы не указали путь папки Steam")
            {
                b_ok.IsEnabled = false;
            }
            else
            {
                b_ok.IsEnabled = true;
            }
        }

        private void b_ok_Click(object sender, RoutedEventArgs e)
        {
            string way_steam = Text_way.Text;
            Way way = new Way(way_steam);
            var del_way = db.Ways.First(x => x.Way_Steam != null);
            db.Ways.Remove(del_way);
            db.Ways.Add(way);
            db.SaveChanges();
            this.Close();
        }

        private void border_win_d_MLBD(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
