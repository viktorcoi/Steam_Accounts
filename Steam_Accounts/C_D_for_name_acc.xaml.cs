using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
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
    /// Логика взаимодействия для C_D_for_name_acc.xaml
    /// </summary>
    public partial class C_D_for_name_acc : Window
    {
        AppContext_for_acc db_acc; // Подключаем базу данных (Аккаунты)
        public C_D_for_name_acc()
        {
            InitializeComponent();
            db_acc = new AppContext_for_acc(); // Создаем БД для работы через форму (Аккаунты)
        }

        private void border_win_d_MLBD(object sender, MouseButtonEventArgs e) // Слушатель на бордюр приложения
        {
            this.DragMove(); // Двигать окно
        }

        private void b_exit_MouseUp(object sender, MouseButtonEventArgs e) // Слушатель на Крестик
        {
            this.Close(); // Закрыть форму
        }

        private void b_add_acc_Click(object sender, RoutedEventArgs e) // Слушатель на Принять
        {

            if (text_box_name_acc.Text == "" || text_box_name_acc.Text == " " || text_box_name_acc.Text == "  " || text_box_name_acc.Text == "   ") // Условие если поле пустое
            {
                LinearGradientBrush gradientBrush = new LinearGradientBrush(Color.FromRgb(30, 29, 29), Color.FromRgb(41, 52, 73), new Point(0.5, 1), new Point(0.5, 0)); // Программное описание градиента для фона
                Window_Error window_error = new Window_Error(); // Создание формы с ошибкой
                window_error.Text_error.Text = "Поле не может быть пустым!"; // Текст ошибки
                window_error.grid_win_error.Background = gradientBrush; // Установка градиента на фон ошибки
                window_error.ShowDialog(); // Показать окно ошибки
            }
            else  // Продолжение условия "Если условие не сработало то"
            {
                string name_acc = text_box_name_acc.Text; // Перенос из заполняемого текста на форме в строку
                try
                {
                    Account account = new Account(name_acc); // Создание строки в БД для аккантов
                    db_acc.Accounts.Add(account); // Добавление строки в БД для аккантов
                    db_acc.SaveChanges(); // Сохранение новых данных в БД  
                    List<Account> accounts = db_acc.Accounts.ToList(); // Перенос всех данных "Аккаунты" с БД в новый лист
                    var name = (accounts.Last().id); // Определение последнего id в таблице "Аккаунты"
                    string a = Convert.ToString("Steam_Accounts_" + name); // Конвертирование из var в string 
                    try 
                    {
                        DirectoryEntry AD = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer"); // Создание процесса для создания учетнной записи
                        DirectoryEntry NewUser = AD.Children.Add(a, "user"); // Указываем имя учетной записи
                        NewUser.Invoke("SetPassword", new object[] { "123" }); // Указываем пароль учетной записи
                        NewUser.Invoke("Put", new object[] { "Description", "Steam Accounts" }); // Добовляем описание для учетной записи
                        NewUser.CommitChanges(); // Сохраняем учетную запись
                        this.Close(); // Закрываем форму
                        Window_Error window_error = new Window_Error();
                        window_error.Width = 500;
                        window_error.Height = 215;
                        window_error.border_win_d.Width = 500;
                        window_error.Text_error.Text = "При первом запуске добавленного аккаунта:\r1. Steam запустится на английском языке\r(при повторном запуске язык будет по умолчанию)\r2. нужно ввести логин и пароль от аккаунта Steam\r(Steam Guard при необходимости)";
                        window_error.Text_error.FontSize = 20;
                        window_error.ShowDialog();
                    } 
                    catch
                    {
                        this.Close();
                        Window_Error window_error = new Window_Error();
                        window_error.Text_error.Text = "Возможно программа запущена не от имени администратора";
                        window_error.Text_error.FontSize = 20;
                        window_error.ShowDialog();
                        try 
                        {
                            var del_way = db_acc.Accounts.First(x => x.id == name); // Ищем эллемент в БД "Аккаунты" который подходит по id 
                            db_acc.Accounts.Remove(del_way); // Удаляем строку в БД "Аккаунты"
                            db_acc.SaveChanges(); // Сохраняем БД "Аккаунты"
                        }
                        catch { }
                    }
                }
                catch
                {
                    this.Close();
                    Window_Error window_error = new Window_Error();
                    window_error.Text_error.Text = "Запись акканта с названием " + "\"" + name_acc + "\"" + " уже существует";
                    window_error.Text_error.FontSize = 20;
                    window_error.ShowDialog();
                }   
            }
        }

        private void b_not_Click(object sender, RoutedEventArgs e) // Слушаеть для кнопки отмена
        {
            this.Close(); // Закрыть форму
        }
    }
}
