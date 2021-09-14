using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для Window_Dialog.xaml
    /// </summary>
    public partial class Window_Dialog : Window
    {

        AppContext_for_way db;
        public Window_Dialog()
        {
            InitializeComponent();
            db = new AppContext_for_way();
            List<Way> check = db.Ways.ToList();
            if (check.Count != 0)
            {
                Window_S_A window_s_a = new Window_S_A();
                window_s_a.Show();
                this.Close();
            }
            Text_way.Text = "Укажите путь папки Steam";
            b_next.IsEnabled = false;
        }

        private void border_win_d_MLBD(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void b_choose_Click(object sender, RoutedEventArgs e)
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
                b_next.IsEnabled = false;
            }
            else
            {
                b_next.IsEnabled = true;
            }
        }

        private void b_exit_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void b_roll_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void b_next_Click(object sender, RoutedEventArgs e)
        {        
            string way_steam = Text_way.Text;         
            Way way = new Way(way_steam);             
            db.Ways.Add(way);               
            db.SaveChanges();       
            Window_S_A window_s_a = new Window_S_A();            
            window_s_a.Show();           
            this.Close();
        }
    }
}
