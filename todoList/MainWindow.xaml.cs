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

namespace todoList
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddBtn_click(object sender, RoutedEventArgs e)
        {
            // create a new rectangle
            TodoItem Item = new TodoItem();

            // put it to Todostack
            TodoItemList.Children.Add(Item) ;
        }

        // 關閉視窗的事件
        private void Window_Closed(object sender, EventArgs e)
        {
            string data = "";

            foreach (TodoItem item in TodoItemList.Children)
            {
                // 打勾符號
                if (item.IsChecked == true)
                    data += "+";
                else
                    data += "-";
                // 文字
                data += item.ItemName + "\r\n";
            }
            // 存檔
            System.IO.File.WriteAllText(@"C:\todoData.txt", data);
        }


        private void SaveBtn_MouseDown(object sender,MouseButtonEventArgs e) {
            // create a "List" to save every word of "item" 
            List<string> all = new List<string>() ;

            string data = "";

            foreach (TodoItem item in TodoItemList.Children)
            {
                // 打勾符號
                if (item.IsChecked == true)
                    data += "+";
                else
                    data += "-";
                // 文字
                data += item.ItemName + "\r\n";
            }

            System.IO.File.WriteAllLines(@"c:\todoData.txt",all);
        }
       private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 讀檔
            string[] lines = System.IO.File.ReadAllLines(@"c:\todoData.txt");

            // 逐行產生元件
            foreach (string line in lines)
            {
                // 用符號分隔
                string[] parts = line.Split();
                
                // 建立元件
                TodoItem item = new TodoItem();
                item.ItemName = parts[1];

                if (parts[0] == "+")
                    item.IsChecked = true;
                else
                    item.IsChecked = false;
                
                // 放入到 StackPanel
                TodoItemList.Children.Add(item);
            }
        }
    }
}
