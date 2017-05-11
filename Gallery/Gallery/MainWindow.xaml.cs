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
using System.IO;
using Microsoft.Win32;
using forms= System.Windows.Forms;

namespace Gallery
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = null;
        public MainWindow()
        {
            InitializeComponent();
            //im_userImage.Source = new BitmapImage(new Uri(listView.SelectedItem.ToString()));
            
        }

        private void bt_openImages_Click(object sender, RoutedEventArgs e)
        {
            forms.FolderBrowserDialog fbs = new forms.FolderBrowserDialog();
            if (fbs.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                path = fbs.SelectedPath;
                //MessageBox.Show(path);
                var dir = new DirectoryInfo(path);
                FileInfo[] files = dir.GetFiles("*.jpg");
                listView.Items.Clear();
                listView.ItemsSource = files;
                listView.DisplayMemberPath = "FullName";
            }
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(listView.SelectedItem.ToString());
            bmp.EndInit();
            im_userImage.Source = bmp;

        }
    }
}
