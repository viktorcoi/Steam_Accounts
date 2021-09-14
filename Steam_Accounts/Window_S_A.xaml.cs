using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Steam_Accounts
{
    /// <summary>
    /// Логика взаимодействия для Window_S_A.xaml
    /// </summary>
    public partial class Window_S_A : Window
    {
        private string way_steam;
        AppContext_for_way db_way;
        AppContext_for_acc db_acc;
        public Window_S_A()
        {
            InitializeComponent();
            db_way = new AppContext_for_way();
            db_acc = new AppContext_for_acc();
            List<Account> accounts = db_acc.Accounts.ToList();
            List_for_acc.ItemsSource = accounts;
        }

        private void b_roll_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void b_exit_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void border_win_d_MLBD(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void get_way_Steam()
        {
            List<Way> ways = db_way.Ways.ToList();
            foreach (Way way in ways)
            way_steam = way.Way_Steam;
        }

        private void b_steam_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                foreach (Process currentProcess in Process.GetProcessesByName("Steam")) // Найти процесс
                    currentProcess.Kill(); // Завершение процесса Steam
                get_way_Steam();
                Process.Start(way_steam + "/steam.exe");
            }
            catch
            {
                Window_Error window_error = new Window_Error();
                window_error.Text_error.Text = "Ошибка запуска Steam!\r- либо неверно указан путь папки\r- либо файл запуска steam.exe был переиминован";
                window_error.Text_error.FontSize = 15.5;
                window_error.ShowDialog();
            }
        }

        private void b_acc_MouseUp(object sender, MouseButtonEventArgs e)
        {
            C_D_for_name_acc c_d_for_name_acc = new C_D_for_name_acc();
            c_d_for_name_acc.ShowDialog();
            List<Account> accounts = db_acc.Accounts.ToList();
            List_for_acc.ItemsSource = accounts;
        }

        private void b_change_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window_Change_Way window_change_way = new Window_Change_Way();
            window_change_way.Show();
        }

        private void WrapPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            foreach (Process currentProcess in Process.GetProcessesByName("Steam")) // Найти процесс
                currentProcess.Kill(); // Завершение процесса Steam
            var name = (List_for_acc.SelectedItem as Account).id;
            get_way_Steam();
            try
            {
                SecureString theSecureString = new NetworkCredential("", "123").SecurePassword;
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo = new ProcessStartInfo()
                {
                    WorkingDirectory = way_steam,
                    UseShellExecute = false,
                    FileName = way_steam + "/steam.exe",
                    UserName = "Steam_Accounts_" + name,
                    Password = theSecureString,
                    LoadUserProfile = true
                };
                Process.Start(startInfo);
            }
            catch
            {
                Window_Error window_error = new Window_Error();
                window_error.Text_error.Text = "Возможно вы удалили пользователя для запуска: \"Steam_Account_" + name + "\"";
                window_error.Text_error.FontSize = 20;
                window_error.ShowDialog();
            }
        }

        private void WrapPanel_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            var name = (List_for_acc.SelectedItem as Account).id;
            delete = name;
        }
        int delete;
        string a;
        private static string[] extra = new string[] { "SID", "\r", "\n", " " };
        private void MenuItem_Click_delete(object sender, RoutedEventArgs e) // Кнопка "Удалить" в контекст меню
        {
            try
            {
                a = Convert.ToString("Steam_Accounts_" + delete); // Конвертирование из int в string 
                var del_way = db_acc.Accounts.First(x => x.id == delete); // Ищем эллемент в БД "Аккаунты" который подходит по id 
                db_acc.Accounts.Remove(del_way); // Удаляем строку в БД "Аккаунты"
                db_acc.SaveChanges(); // Сохраняем БД "Аккаунты"
                List<Account> accounts = db_acc.Accounts.ToList(); // Достаем данные из БД "Аккаунты"
                List_for_acc.ItemsSource = accounts; // Отображаем данные из БД "Аккаунты" в ListVIew
                ProcessStartInfo startInfo = new ProcessStartInfo(); // Создаем новый процесс для отрытия cmd
                startInfo = new ProcessStartInfo() // Описываем процесс
                {
                    WindowStyle = ProcessWindowStyle.Hidden, // Делаем cmd скрытой
                    FileName = "cmd", // Указываем, что нужно запускать
                    Arguments = "/c RD /s/q \"C:/Users/" + a + "\"" // Указываем, что нужно писать в cmd
                };
                Process.Start(startInfo); // Запускаем созданный процесс
                Process process = new Process();
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c wmic useraccount where name=\"" + a + "\" get sid";
                process.Start();
                string output = process.StandardOutput.ReadToEnd().Trim();
                process.WaitForExit();
                foreach (string f in extra)
                {
                    output = output.Replace(f.ToString(), "");
                }
                Microsoft.Win32.RegistryKey RegKeyDel = Microsoft.Win32.Registry.LocalMachine;
                RegKeyDel.DeleteSubKeyTree("Software\\Microsoft\\Windows NT\\CurrentVersion\\ProfileList\\" + output);
                RegKeyDel.Close();
                try
                {
                    DirectoryEntry REMOVE = new DirectoryEntry("WinNT://" + Environment.MachineName.ToString()); // Создание процесса для удаления учетнной записи
                    DirectoryEntries RemoveUser = REMOVE.Children; // Заходим в список пользователей
                    DirectoryEntry user = RemoveUser.Find(a); // Ищем пользователя по указанному имени
                    RemoveUser.Remove(user); // Удаляем пользователя
                }
                catch { }
            }
            catch
            {
                Window_Error window_error = new Window_Error();
                window_error.Text_error.Text = "Возможно программа запущена не от имени администратора";
                window_error.Text_error.FontSize = 20;
                window_error.ShowDialog();
            }
        }
    }
}
