using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AshokaGraphics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Job> jobs = null;
        string filePath = ConfigurationManager.AppSettings.Get("filePath");
        public MainWindow()
        {
            InitializeComponent();
            
            //this.BindGrid(@"C:\Program Files (x86)\PrinterManager\PrintedArea.Log");
            this.BindGrid(filePath);
        }
        public void BindGrid(string path)
        {
            try
            {
                Job job = new Job();
                if (job.CheckFileExists(path))
                {
                    jobs = job.GetAllJobs(path);
                    if (jobs != null || jobs.Count >= 0)
                    {
                        DataGrid1.ItemsSource = jobs;
                        lblStatus.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        DataGrid1.Visibility = Visibility.Hidden;
                        lblStatus.Visibility = Visibility.Visible;
                        lblStatus.Content = "No data to display";
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLogs(ex.Message);
            }

        }
        public void CheckFiles(string path)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (jobs != null)
                {
                    DataGrid1.ItemsSource = jobs.FindAll(x => x.JobDate.ToString().Contains(searchTxtBox.Text) || x.FilePath.ToLower().Contains(searchTxtBox.Text.ToLower()) || x.PercentComplete.Contains(searchTxtBox.Text));
                }
            }
            catch (Exception ex)
            {
                WriteLogs(ex.Message);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                searchTxtBox.Text = "";
                if (jobs != null)
                {
                    DataGrid1.ItemsSource = jobs;
                }
            }
            catch (Exception ex)
            {
                WriteLogs(ex.Message);
            }

        }

        public static void WriteLogs(string message)
        {
            File.AppendAllText("logs.txt", DateTime.Now + " " + message + "\n", Encoding.UTF8);
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            this.BindGrid(filePath);
        }
    }
}
